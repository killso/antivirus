using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        // UI ФУНКЦИИ
        public TableLayoutPanel UIHandlerFile(string path)
        {
            ComboBox combobox = new ComboBox();
            combobox.Items.Add("Разрешить");
            combobox.Items.Add("В карантин");
            combobox.Items.Add("Удалить");
            combobox.SelectedIndex = 0;
            

            Label label = new Label();
            label.Text = path;
            label.Anchor = AnchorStyles.Left;
            label.Name = "label";


            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.AutoScroll = true;
            tlp.RowCount = 1;
            tlp.ColumnCount = 2;
            tlp.AutoSize = true;
            tlp.Controls.Add(combobox);
            tlp.Controls.Add(label);

            return tlp;
        }

        public TableLayoutPanel UIHandlerQuarantineFile(string path)
        {
            CheckBox checkbox = new CheckBox();
            checkbox.Text = "Удалить";
            checkbox.Checked = false;
            checkbox.Anchor = AnchorStyles.Left;
            checkbox.ForeColor = Color.Red;


            Label label = new Label();
            label.Text = path;
            label.Anchor = AnchorStyles.Left;
            label.Name = "label";


            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.AutoScroll = true;
            tlp.RowCount = 1;
            tlp.ColumnCount = 2;
            tlp.AutoSize = true;
            tlp.Controls.Add(checkbox);
            tlp.Controls.Add(label);

            return tlp;
        }



        // ОБЩИЕ ФУНКЦИИ 
        public string choosePath(bool isFile)
        {
            string path = "";
            
            if (isFile)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                    path = ofd.FileName;
            } else
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                    path = dlg.SelectedPath;
            }

            return path;
        }



        // SCANNING
        private void scanning_button_choose_file_Click(object sender, EventArgs e)
        {
            string path = choosePath(true);
            scanning_label_path.Text = path;

            scanning_list_result.Controls.Add(UIHandlerQuarantineFile("c:/fdfdf/dsgsfg/"));
            scanning_list_result.Controls.Add(UIHandlerQuarantineFile("c:/fdfdf/dsgsfg/"));
        }

        private void scanning_button_choose_dir_Click(object sender, EventArgs e)
        {
            string path = choosePath(false);
            scanning_label_path.Text = path;
        }

        private void scanning_button_power_Click(object sender, EventArgs e)
        {
            
        }

        private void scanning_button_power_result_Click(object sender, EventArgs e)
        {

        }



        // MONITORING
        private void monitoring_button_choose_file_Click(object sender, EventArgs e)
        {
            string path = choosePath(true);
            monitoring_label_path.Text = path;
        }

        private void monitoring_button_choose_dir_Click(object sender, EventArgs e)
        {
            string path = choosePath(false);
            monitoring_label_path.Text = path;
        }

        private void monitoring_button_power_Click(object sender, EventArgs e)
        {

        }

        private void monitoring_button_power_result_Click(object sender, EventArgs e)
        {

        }



        // INSPECTIONS
        private void inspections_button_choose_file_Click(object sender, EventArgs e)
        {
            string path = choosePath(true);
            inspections_label_path.Text = path;
        }

        private void inspections_button_choose_dir_Click(object sender, EventArgs e)
        {
            string path = choosePath(false);
            inspections_label_path.Text = path;
        }

        private void inspections_button_add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
