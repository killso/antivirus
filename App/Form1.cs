using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WCFService;
using System.Threading;
using System.IO;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inspections_update();
            quarantine_update();
        }



        // UI ФУНКЦИИ
        private ComboBox UIComboBoxHandler()
        {
            ComboBox combobox = new ComboBox();
            combobox.Items.Add("Разрешить");
            combobox.Items.Add("В карантин");
            combobox.Items.Add("Удалить");
            combobox.Width = 130;
            combobox.Height = 50;
            combobox.SelectedIndex = 0;
            combobox.Anchor = AnchorStyles.Left;
            return combobox;
        }
        private ComboBox UIComboBoxQuarantine()
        {
            ComboBox combobox = new ComboBox();
            combobox.Items.Add("Оставить в карантине");
            combobox.Items.Add("Удалить из карантина");
            combobox.Items.Add("Удалить файл");
            combobox.Width = 220;
            combobox.Height = 50;
            combobox.SelectedIndex = 0;
            combobox.Anchor = AnchorStyles.Left;
            return combobox;
        }
        private TableLayoutPanel UIHandlerFile(string path, bool quarantine_handler = false)
        {
            ComboBox combobox;
            if (quarantine_handler)
                combobox = UIComboBoxQuarantine();
            else
                combobox = UIComboBoxHandler();

            Label label = new Label();
            label.Text = path;
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;


            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.AutoScroll = true;
            tlp.RowCount = 1;
            tlp.ColumnCount = 2;
            tlp.AutoSize = true;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            tlp.Size = new Size(0, 50);
            tlp.Controls.Add(combobox);
            tlp.Controls.Add(label);

            return tlp;
        }



        // ОБЩИЕ ФУНКЦИИ 
        public ServiceClient create_client()
        {
            ServiceClient client;
            try
            {
                NetTcpBinding binding = new NetTcpBinding(SecurityMode.Transport);

                binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
                binding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;

                string uri = @"net.tcp://localhost:9002/ServiceSherbakova";

                EndpointAddress endpoint = new EndpointAddress(new Uri(uri));

                client = new ServiceClient(binding, endpoint);
                client.ClientCredentials.Windows.ClientCredential.Domain = "";
            }
            catch (Exception _ex)
            {
                client = null;
            }
            return client;
        }
        public string choosePath(bool isFile)
        {
            string path = "";

            if (isFile)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                    path = ofd.FileName;
            }
            else
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                    path = dlg.SelectedPath;
            }

            return path;
        }
        public void handle_files(Control tlp, TextBox statistic = null)
        {
            List<FileDescription> files = new List<FileDescription>();
            List<TableLayoutPanel> lists = tlp.Controls.OfType<TableLayoutPanel>().ToList();

            foreach (TableLayoutPanel control in lists)
            {
                ComboBox cb = control.Controls.OfType<ComboBox>().ElementAt(0);
                Label label = control.Controls.OfType<Label>().ElementAt(0);
                string path = label.Text;
                int action = cb.SelectedIndex;
                FileDescription file = new FileDescription();
                file.path = path;
                switch (action)
                {
                    case 1:
                        file.state = FileDescription.FilesStates.ToQuarantine;
                        break;
                    case 2:
                        file.state = FileDescription.FilesStates.Delete;
                        break;
                    default:
                        file.state = FileDescription.FilesStates.Allow;
                        break;
                }
                files.Add(file);
            }
            create_client().handle_files(files.ToArray(), null);
            tlp.Controls.Clear();
            if (statistic != null)
                statistic.Text = "";
        }



        // СКАНИРОВАНИЕ
        private void scanning_button_choose_file_Click(object sender, EventArgs e)
        {
            string path = choosePath(true);
            scanning_label_path.Text = path;
            scanning_button_power.Enabled = true;
        }
        private void scanning_button_choose_dir_Click(object sender, EventArgs e)
        {
            string path = choosePath(false);
            scanning_label_path.Text = path;
            scanning_button_power.Enabled = true;
        }
        private void scanning_button_power_Click(object sender, EventArgs e)
        {
            scanning_list_result.Controls.Clear();
            ServiceClient client = create_client();
            if (!client.get_scanner_status())
                scanning_start();
            else
                scanning_stop();
            client.Close();
        }
        private void scanning_button_power_result_Click(object sender, EventArgs e)
        {
            scanning_textbox_log.Text = "";
            this.handle_files(scanning_list_result, scanning_textbox_log);
        }
        async public void scanning_start()
        {
            ServiceClient client = create_client();
            scanning_button_power.Text = "Остановить";
            client.start_scanner(scanning_label_path.Text);
            client.Close();

            var progress = new Progress<string[]>(text => {
                scanning_textbox_log.Text = text[0];
            });

            await Task.Run(() =>
            {
                ServiceClient local = create_client();
                while (local.get_scanner_status())
                {
                    IProgress<string[]> progressSender = progress;
                    string[] statistic = new string[] { local.get_scanner_statistics() };
                    progressSender.Report(statistic);
                    Thread.Sleep(1000);
                }
                local.Close();
            });
            scanning_stop();
        }
        public void scanning_stop()
        {
            scanning_list_result.Controls.Clear();
            ServiceClient client = create_client();
            client.stop_scanner();
            scanning_button_power.Text = "Старт";
            string[] paths = client.get_scanner_result();
            for (int i = 0; i < paths.Length; i += 1)
                scanning_list_result.Controls.Add(UIHandlerFile(paths[i]));
            scanning_textbox_log.Text = client.get_scanner_statistics();
            client.Close();
        }
        


        // МОНИТОРИНГ ДИРЕКТОРИИ
        private void monitoring_button_choose_dir_Click(object sender, EventArgs e)
        {
            string path = choosePath(false);
            monitoring_label_path.Text = path;
            monitoring_button_power.Enabled = true;
        }
        private void monitoring_button_power_Click(object sender, EventArgs e)
        {
            ServiceClient client = create_client();
            if (!client.get_observer_status())
                monitoring_start();
            else
                monitoring_stop();
            client.Close();
        }
        private void monitoring_button_power_result_Click(object sender, EventArgs e)
        {
            this.handle_files(monitoring_list_result);
        }
        async private void monitoring_start()
        {
            monitoring_button_power.Text = "Остановить";

            var progress = new Progress<string[]>(text => {
                ServiceClient client = create_client();
                monitoring_list_result.Controls.Clear();
                string[] paths = client.get_observer_result();
                for (int i = 0; i < paths.Length; i += 1)
                    monitoring_list_result.Controls.Add(UIHandlerFile(paths[i]));
                client.Close();
            });

            await Task.Run(() =>
            {
                ServiceClient client = create_client();
                client.start_observer(monitoring_label_path.Text);
                while (client.get_observer_status())
                {
                    IProgress<string[]> progressSender = progress;
                    progressSender.Report(new string[] { "" });
                    Thread.Sleep(1000);
                }
                client.Close();
            });
        }
        private void monitoring_stop()
        {
            monitoring_button_power.Text = "Старт";
            monitoring_list_result.Controls.Clear();

            ServiceClient client = create_client();
            client.stop_observer();
            string[] paths = client.get_observer_result();
            for (int i = 0; i < paths.Length; i += 1)
                monitoring_list_result.Controls.Add(UIHandlerFile(paths[i]));
            client.Close();
        }



        // ПЛАНОВЫЕ ПРОВЕРКИ
        private Inspection[] inspections;
        private Inspection select_inspection = null;
        private void inspections_button_choose_file_Click(object sender, EventArgs e)
        {
            string path = choosePath(true);
            inspections_label_path.Text = path;
            inspections_button_add.Enabled = true;
        }
        private void inspections_button_choose_dir_Click(object sender, EventArgs e)
        {
            string path = choosePath(false);
            inspections_label_path.Text = path;
            inspections_button_add.Enabled = true;
        }
        private void inspections_button_add_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now >= inspections_date_time_picker.Value)
            {
                MessageBox.Show("Дата и время должны быть установлены в будушем времени");
                return;
            }

            ServiceClient client = create_client();
            Inspection inspection = new Inspection();
            inspection.path = inspections_label_path.Text;
            inspection.time = inspections_date_time_picker.Value;
            client.add_inspection(inspection);
            client.Close();
            inspections_update();
        }
        private void inspections_button_update_Click(object sender, EventArgs e)
        {
            inspections_update();
        }
        private void inspection_button_result_Click(object sender, EventArgs e)
        {
            if (this.select_inspection == null) return;

            List<FileDescription> files = new List<FileDescription>();
            List<TableLayoutPanel> lists = inspection_list.Controls.OfType<TableLayoutPanel>().ToList();

            foreach (TableLayoutPanel control in lists)
            {
                ComboBox cb = control.Controls.OfType<ComboBox>().ElementAt(0);
                Label label = control.Controls.OfType<Label>().ElementAt(0);
                string path = label.Text;
                int action = cb.SelectedIndex;
                FileDescription file = new FileDescription();
                file.path = path;
                switch (action)
                {
                    case 1:
                        file.state = FileDescription.FilesStates.ToQuarantine;
                        break;
                    case 2:
                        file.state = FileDescription.FilesStates.Delete;
                        break;
                    default:
                        file.state = FileDescription.FilesStates.Allow;
                        break;
                }
                files.Add(file);
            }
            ServiceClient client = create_client();
            client.handle_files(files.ToArray(), this.select_inspection);

            client.remove_inspection(this.select_inspection);
            client.Close();
            inspection_list.Controls.Clear();
            inspection_label.Text = "";
            this.select_inspection = null;
            inspections_update();
        }
        private void inspections_button_delete_Click(object sender, EventArgs e)
        {
            inspection_list.Controls.Clear();
            inspection_label.Text = "";

            List<Inspection> files = new List<Inspection>();
            List<TableLayoutPanel> lists = inspections_list.Controls.OfType<TableLayoutPanel>().ToList();

            ServiceClient client = create_client();
            for (int i = 0; i < lists.Count; i += 1)
            {
                TableLayoutPanel tlp = lists.ElementAt(i);
                CheckBox delete_cb = tlp.Controls.OfType<CheckBox>().ElementAt(0);
                if (delete_cb.Checked)
                    client.remove_inspection(this.inspections[i]);
            }
            client.Close();
            inspections_update();
        }
        private void inspections_update()
        {
            ServiceClient client = create_client();
            inspections = client.get_inspections();
            client.Close();

            inspections_list.Controls.Clear();
            for (int i = 0; i < inspections.Length; i += 1)
                inspections_list.Controls.Add(UIInspection(inspections[i]));

            inspection_list.Controls.Clear();
            inspection_label.Text = "";
        }
        private TableLayoutPanel UIInspection(Inspection inspection)
        {
            Button button_open = new Button();
            button_open.Text = "Открыть";
            button_open.Width = 100;
            button_open.Height = 50;
            button_open.BackColor = Color.White;
            button_open.Click += new EventHandler((object sender, EventArgs e) => {
                this.select_inspection = inspection;

                inspection_list.Controls.Clear();

                ServiceClient client = create_client();
                string[] paths = client.get_inspection_results(inspection);
                for (int i = 0; i < paths.Length; i += 1)
                    inspection_list.Controls.Add(UIHandlerFile(paths[i]));

                inspection_label.Text = inspection.time.ToString() + " " + inspection.path;
                client.Close();
            });
            if (!inspection.done)
                button_open.Enabled = false;

            CheckBox checkbox_delete = new CheckBox();
            checkbox_delete.Width = 250;
            checkbox_delete.Anchor = AnchorStyles.Left;
            checkbox_delete.Text = "Пометить на удаление";
            checkbox_delete.Checked = false;

            CheckBox checkbox_done = new CheckBox();
            checkbox_done.Width = 150;
            checkbox_done.Anchor = AnchorStyles.Left;
            checkbox_done.Text = "Выполнена";
            checkbox_done.Checked = inspection.done;
            checkbox_done.Enabled = false;

            Label label_time = new Label();
            label_time.Text = inspection.time.ToString();
            label_time.Anchor = AnchorStyles.Left;
            label_time.AutoSize = true;

            Label label_path = new Label();
            label_path.Text = inspection.path;
            label_path.Anchor = AnchorStyles.Left;
            label_path.AutoSize = true;

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.AutoScroll = true;
            tlp.RowCount = 1;
            tlp.ColumnCount = 5;
            tlp.AutoSize = true;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            tlp.Size = new Size(0, 50);
            tlp.Controls.Add(button_open);
            tlp.Controls.Add(checkbox_delete);
            tlp.Controls.Add(checkbox_done);
            tlp.Controls.Add(label_time);
            tlp.Controls.Add(label_path);
            return tlp;
        }



        // КАРАНТИН
        private void quarantine_button_handle_Click(object sender, EventArgs e)
        {
            List<FileDescription> files = new List<FileDescription>();
            List<TableLayoutPanel> lists = quarantine_list.Controls.OfType<TableLayoutPanel>().ToList();

            foreach (TableLayoutPanel control in lists)
            {
                ComboBox cb = control.Controls.OfType<ComboBox>().ElementAt(0);
                Label label = control.Controls.OfType<Label>().ElementAt(0);
                string path = label.Text;
                int action = cb.SelectedIndex;
                FileDescription file = new FileDescription();
                file.path = path;
                switch (action)
                {
                    case 1:
                        file.state = FileDescription.FilesStates.RemoveFromQuarantine;
                        break;
                    case 2:
                        file.state = FileDescription.FilesStates.Delete;
                        break;
                    default:
                        file.state = FileDescription.FilesStates.Allow;
                        break;
                }
                files.Add(file);
            }
            ServiceClient client = create_client();
            client.handle_files(files.ToArray(), null);
            client.Close();

            quarantine_update();
        }
        private void quarantine_button_update_Click(object sender, EventArgs e)
        {
            quarantine_update();
        }
        private void quarantine_update()
        {
            quarantine_list.Controls.Clear();

            ServiceClient client = create_client();

            string[] paths = client.get_quarantine();
            for (int i = 0; i < paths.Length; i += 1)
                quarantine_list.Controls.Add(UIHandlerFile(paths[i], true));

            client.Close();
        }
    }
}