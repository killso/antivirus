
namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scanning_list_result = new System.Windows.Forms.FlowLayoutPanel();
            this.scanning_button_power_result = new System.Windows.Forms.Button();
            this.scanning_textbox_log = new System.Windows.Forms.TextBox();
            this.scanning_label_path = new System.Windows.Forms.Label();
            this.scanning_label_about_choose_file = new System.Windows.Forms.Label();
            this.scanning_button_power = new System.Windows.Forms.Button();
            this.scanning_button_choose_dir = new System.Windows.Forms.Button();
            this.scanning_button_choose_file = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.monitoring_list_result = new System.Windows.Forms.FlowLayoutPanel();
            this.monitoring_button_power_result = new System.Windows.Forms.Button();
            this.monitoring_label_path = new System.Windows.Forms.Label();
            this.monitoring_label_about_choose_path = new System.Windows.Forms.Label();
            this.monitoring_button_power = new System.Windows.Forms.Button();
            this.monitoring_button_choose_dir = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inspections_label_about_choose_path = new System.Windows.Forms.Label();
            this.inspections_label_path = new System.Windows.Forms.Label();
            this.inspections_list = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.inspections_button_delete = new System.Windows.Forms.Button();
            this.inspections_button_update = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inspection_label = new System.Windows.Forms.Label();
            this.inspection_list = new System.Windows.Forms.FlowLayoutPanel();
            this.inspection_button_result = new System.Windows.Forms.Button();
            this.inspections_date_time_picker = new System.Windows.Forms.DateTimePicker();
            this.inspections_button_add = new System.Windows.Forms.Button();
            this.inspections_button_choose_file = new System.Windows.Forms.Button();
            this.inspections_button_choose_dir = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.quarantine_button_update = new System.Windows.Forms.Button();
            this.quarantine_button_handle = new System.Windows.Forms.Button();
            this.quarantine_list = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.tabPage1);
            this.MainMenu.Controls.Add(this.tabPage2);
            this.MainMenu.Controls.Add(this.tabPage3);
            this.MainMenu.Controls.Add(this.tabPage4);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Font = new System.Drawing.Font("Candara Light", 12F);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Drawing.Point(10, 10);
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(990, 655);
            this.MainMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scanning_list_result);
            this.tabPage1.Controls.Add(this.scanning_button_power_result);
            this.tabPage1.Controls.Add(this.scanning_textbox_log);
            this.tabPage1.Controls.Add(this.scanning_label_path);
            this.tabPage1.Controls.Add(this.scanning_label_about_choose_file);
            this.tabPage1.Controls.Add(this.scanning_button_power);
            this.tabPage1.Controls.Add(this.scanning_button_choose_dir);
            this.tabPage1.Controls.Add(this.scanning_button_choose_file);
            this.tabPage1.Font = new System.Drawing.Font("Candara Light", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сканирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scanning_list_result
            // 
            this.scanning_list_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanning_list_result.AutoScroll = true;
            this.scanning_list_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanning_list_result.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.scanning_list_result.Location = new System.Drawing.Point(3, 219);
            this.scanning_list_result.Name = "scanning_list_result";
            this.scanning_list_result.Size = new System.Drawing.Size(976, 326);
            this.scanning_list_result.TabIndex = 9;
            this.scanning_list_result.WrapContents = false;
            // 
            // scanning_button_power_result
            // 
            this.scanning_button_power_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanning_button_power_result.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.scanning_button_power_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanning_button_power_result.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.scanning_button_power_result.ForeColor = System.Drawing.Color.Black;
            this.scanning_button_power_result.Location = new System.Drawing.Point(3, 551);
            this.scanning_button_power_result.Name = "scanning_button_power_result";
            this.scanning_button_power_result.Size = new System.Drawing.Size(976, 50);
            this.scanning_button_power_result.TabIndex = 8;
            this.scanning_button_power_result.Text = "Обработать результаты";
            this.scanning_button_power_result.UseVisualStyleBackColor = false;
            this.scanning_button_power_result.Click += new System.EventHandler(this.scanning_button_power_result_Click);
            // 
            // scanning_textbox_log
            // 
            this.scanning_textbox_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanning_textbox_log.BackColor = System.Drawing.Color.White;
            this.scanning_textbox_log.Location = new System.Drawing.Point(3, 116);
            this.scanning_textbox_log.Multiline = true;
            this.scanning_textbox_log.Name = "scanning_textbox_log";
            this.scanning_textbox_log.ReadOnly = true;
            this.scanning_textbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scanning_textbox_log.Size = new System.Drawing.Size(976, 97);
            this.scanning_textbox_log.TabIndex = 6;
            // 
            // scanning_label_path
            // 
            this.scanning_label_path.AutoSize = true;
            this.scanning_label_path.Location = new System.Drawing.Point(59, 26);
            this.scanning_label_path.Name = "scanning_label_path";
            this.scanning_label_path.Size = new System.Drawing.Size(25, 24);
            this.scanning_label_path.TabIndex = 5;
            this.scanning_label_path.Text = "...";
            // 
            // scanning_label_about_choose_file
            // 
            this.scanning_label_about_choose_file.AutoSize = true;
            this.scanning_label_about_choose_file.Location = new System.Drawing.Point(9, 26);
            this.scanning_label_about_choose_file.Name = "scanning_label_about_choose_file";
            this.scanning_label_about_choose_file.Size = new System.Drawing.Size(53, 24);
            this.scanning_label_about_choose_file.TabIndex = 4;
            this.scanning_label_about_choose_file.Text = "Путь:";
            // 
            // scanning_button_power
            // 
            this.scanning_button_power.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanning_button_power.BackColor = System.Drawing.SystemColors.Highlight;
            this.scanning_button_power.Enabled = false;
            this.scanning_button_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanning_button_power.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.scanning_button_power.ForeColor = System.Drawing.Color.White;
            this.scanning_button_power.Location = new System.Drawing.Point(426, 60);
            this.scanning_button_power.Name = "scanning_button_power";
            this.scanning_button_power.Size = new System.Drawing.Size(553, 50);
            this.scanning_button_power.TabIndex = 2;
            this.scanning_button_power.Text = "Старт";
            this.scanning_button_power.UseVisualStyleBackColor = false;
            this.scanning_button_power.Click += new System.EventHandler(this.scanning_button_power_Click);
            // 
            // scanning_button_choose_dir
            // 
            this.scanning_button_choose_dir.BackColor = System.Drawing.Color.White;
            this.scanning_button_choose_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanning_button_choose_dir.Location = new System.Drawing.Point(209, 60);
            this.scanning_button_choose_dir.Name = "scanning_button_choose_dir";
            this.scanning_button_choose_dir.Size = new System.Drawing.Size(211, 50);
            this.scanning_button_choose_dir.TabIndex = 1;
            this.scanning_button_choose_dir.Text = "Выбрать директорию";
            this.scanning_button_choose_dir.UseVisualStyleBackColor = false;
            this.scanning_button_choose_dir.Click += new System.EventHandler(this.scanning_button_choose_dir_Click);
            // 
            // scanning_button_choose_file
            // 
            this.scanning_button_choose_file.BackColor = System.Drawing.Color.White;
            this.scanning_button_choose_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanning_button_choose_file.Location = new System.Drawing.Point(3, 60);
            this.scanning_button_choose_file.Name = "scanning_button_choose_file";
            this.scanning_button_choose_file.Size = new System.Drawing.Size(200, 50);
            this.scanning_button_choose_file.TabIndex = 0;
            this.scanning_button_choose_file.Text = "Выбрать файл";
            this.scanning_button_choose_file.UseVisualStyleBackColor = false;
            this.scanning_button_choose_file.Click += new System.EventHandler(this.scanning_button_choose_file_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.monitoring_list_result);
            this.tabPage2.Controls.Add(this.monitoring_button_power_result);
            this.tabPage2.Controls.Add(this.monitoring_label_path);
            this.tabPage2.Controls.Add(this.monitoring_label_about_choose_path);
            this.tabPage2.Controls.Add(this.monitoring_button_power);
            this.tabPage2.Controls.Add(this.monitoring_button_choose_dir);
            this.tabPage2.Font = new System.Drawing.Font("Candara Light", 12F);
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мониторинг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // monitoring_list_result
            // 
            this.monitoring_list_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitoring_list_result.AutoScroll = true;
            this.monitoring_list_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitoring_list_result.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.monitoring_list_result.Location = new System.Drawing.Point(3, 107);
            this.monitoring_list_result.Name = "monitoring_list_result";
            this.monitoring_list_result.Size = new System.Drawing.Size(971, 494);
            this.monitoring_list_result.TabIndex = 16;
            this.monitoring_list_result.WrapContents = false;
            // 
            // monitoring_button_power_result
            // 
            this.monitoring_button_power_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitoring_button_power_result.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.monitoring_button_power_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoring_button_power_result.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.monitoring_button_power_result.ForeColor = System.Drawing.Color.Black;
            this.monitoring_button_power_result.Location = new System.Drawing.Point(621, 51);
            this.monitoring_button_power_result.Name = "monitoring_button_power_result";
            this.monitoring_button_power_result.Size = new System.Drawing.Size(353, 50);
            this.monitoring_button_power_result.TabIndex = 15;
            this.monitoring_button_power_result.Text = "Обработать результаты";
            this.monitoring_button_power_result.UseVisualStyleBackColor = false;
            this.monitoring_button_power_result.Click += new System.EventHandler(this.monitoring_button_power_result_Click);
            // 
            // monitoring_label_path
            // 
            this.monitoring_label_path.AutoSize = true;
            this.monitoring_label_path.Location = new System.Drawing.Point(59, 17);
            this.monitoring_label_path.Name = "monitoring_label_path";
            this.monitoring_label_path.Size = new System.Drawing.Size(25, 24);
            this.monitoring_label_path.TabIndex = 13;
            this.monitoring_label_path.Text = "...";
            // 
            // monitoring_label_about_choose_path
            // 
            this.monitoring_label_about_choose_path.AutoSize = true;
            this.monitoring_label_about_choose_path.Location = new System.Drawing.Point(9, 17);
            this.monitoring_label_about_choose_path.Name = "monitoring_label_about_choose_path";
            this.monitoring_label_about_choose_path.Size = new System.Drawing.Size(53, 24);
            this.monitoring_label_about_choose_path.TabIndex = 12;
            this.monitoring_label_about_choose_path.Text = "Путь:";
            // 
            // monitoring_button_power
            // 
            this.monitoring_button_power.BackColor = System.Drawing.SystemColors.Highlight;
            this.monitoring_button_power.Enabled = false;
            this.monitoring_button_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoring_button_power.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.monitoring_button_power.ForeColor = System.Drawing.Color.White;
            this.monitoring_button_power.Location = new System.Drawing.Point(258, 51);
            this.monitoring_button_power.Name = "monitoring_button_power";
            this.monitoring_button_power.Size = new System.Drawing.Size(357, 50);
            this.monitoring_button_power.TabIndex = 11;
            this.monitoring_button_power.Text = "Старт";
            this.monitoring_button_power.UseVisualStyleBackColor = false;
            this.monitoring_button_power.Click += new System.EventHandler(this.monitoring_button_power_Click);
            // 
            // monitoring_button_choose_dir
            // 
            this.monitoring_button_choose_dir.BackColor = System.Drawing.Color.White;
            this.monitoring_button_choose_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoring_button_choose_dir.Location = new System.Drawing.Point(3, 51);
            this.monitoring_button_choose_dir.Name = "monitoring_button_choose_dir";
            this.monitoring_button_choose_dir.Size = new System.Drawing.Size(249, 50);
            this.monitoring_button_choose_dir.TabIndex = 10;
            this.monitoring_button_choose_dir.Text = "Выбрать директорию";
            this.monitoring_button_choose_dir.UseVisualStyleBackColor = false;
            this.monitoring_button_choose_dir.Click += new System.EventHandler(this.monitoring_button_choose_dir_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Controls.Add(this.inspections_date_time_picker);
            this.tabPage3.Controls.Add(this.inspections_button_add);
            this.tabPage3.Controls.Add(this.inspections_button_choose_file);
            this.tabPage3.Controls.Add(this.inspections_button_choose_dir);
            this.tabPage3.Font = new System.Drawing.Font("Candara Light", 12F);
            this.tabPage3.Location = new System.Drawing.Point(4, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(982, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Плановые проверки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 80);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(966, 516);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.inspections_label_about_choose_path, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inspections_label_path, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.inspections_list, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 252);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // inspections_label_about_choose_path
            // 
            this.inspections_label_about_choose_path.AutoSize = true;
            this.inspections_label_about_choose_path.Location = new System.Drawing.Point(3, 0);
            this.inspections_label_about_choose_path.Name = "inspections_label_about_choose_path";
            this.inspections_label_about_choose_path.Size = new System.Drawing.Size(53, 24);
            this.inspections_label_about_choose_path.TabIndex = 19;
            this.inspections_label_about_choose_path.Text = "Путь:";
            // 
            // inspections_label_path
            // 
            this.inspections_label_path.AutoSize = true;
            this.inspections_label_path.Location = new System.Drawing.Point(3, 35);
            this.inspections_label_path.Name = "inspections_label_path";
            this.inspections_label_path.Size = new System.Drawing.Size(25, 24);
            this.inspections_label_path.TabIndex = 20;
            this.inspections_label_path.Text = "...";
            // 
            // inspections_list
            // 
            this.inspections_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspections_list.AutoScroll = true;
            this.inspections_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspections_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inspections_list.Location = new System.Drawing.Point(3, 73);
            this.inspections_list.Name = "inspections_list";
            this.inspections_list.Size = new System.Drawing.Size(954, 119);
            this.inspections_list.TabIndex = 23;
            this.inspections_list.WrapContents = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.45141F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.54859F));
            this.tableLayoutPanel3.Controls.Add(this.inspections_button_delete, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.inspections_button_update, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 198);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(954, 51);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // inspections_button_delete
            // 
            this.inspections_button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inspections_button_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.inspections_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_delete.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.inspections_button_delete.ForeColor = System.Drawing.Color.White;
            this.inspections_button_delete.Location = new System.Drawing.Point(236, 3);
            this.inspections_button_delete.Name = "inspections_button_delete";
            this.inspections_button_delete.Size = new System.Drawing.Size(333, 45);
            this.inspections_button_delete.TabIndex = 28;
            this.inspections_button_delete.Text = "Удалить  отмеченные из проверок";
            this.inspections_button_delete.UseVisualStyleBackColor = false;
            this.inspections_button_delete.Click += new System.EventHandler(this.inspections_button_delete_Click);
            // 
            // inspections_button_update
            // 
            this.inspections_button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspections_button_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.inspections_button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_update.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.inspections_button_update.ForeColor = System.Drawing.Color.White;
            this.inspections_button_update.Location = new System.Drawing.Point(3, 3);
            this.inspections_button_update.Name = "inspections_button_update";
            this.inspections_button_update.Size = new System.Drawing.Size(227, 45);
            this.inspections_button_update.TabIndex = 29;
            this.inspections_button_update.Text = "Обновить список";
            this.inspections_button_update.UseVisualStyleBackColor = false;
            this.inspections_button_update.Click += new System.EventHandler(this.inspections_button_update_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.inspection_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inspection_list, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inspection_button_result, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 261);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 252);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // inspection_label
            // 
            this.inspection_label.AutoSize = true;
            this.inspection_label.Location = new System.Drawing.Point(3, 0);
            this.inspection_label.Name = "inspection_label";
            this.inspection_label.Size = new System.Drawing.Size(25, 24);
            this.inspection_label.TabIndex = 25;
            this.inspection_label.Text = "...";
            // 
            // inspection_list
            // 
            this.inspection_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspection_list.AutoScroll = true;
            this.inspection_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspection_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inspection_list.Location = new System.Drawing.Point(3, 38);
            this.inspection_list.Name = "inspection_list";
            this.inspection_list.Size = new System.Drawing.Size(954, 154);
            this.inspection_list.TabIndex = 24;
            this.inspection_list.WrapContents = false;
            // 
            // inspection_button_result
            // 
            this.inspection_button_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspection_button_result.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.inspection_button_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspection_button_result.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.inspection_button_result.ForeColor = System.Drawing.Color.Black;
            this.inspection_button_result.Location = new System.Drawing.Point(3, 198);
            this.inspection_button_result.Name = "inspection_button_result";
            this.inspection_button_result.Size = new System.Drawing.Size(954, 50);
            this.inspection_button_result.TabIndex = 26;
            this.inspection_button_result.Text = "Обработать результаты";
            this.inspection_button_result.UseVisualStyleBackColor = false;
            this.inspection_button_result.Click += new System.EventHandler(this.inspection_button_result_Click);
            // 
            // inspections_date_time_picker
            // 
            this.inspections_date_time_picker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.inspections_date_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inspections_date_time_picker.Location = new System.Drawing.Point(385, 24);
            this.inspections_date_time_picker.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.inspections_date_time_picker.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.inspections_date_time_picker.Name = "inspections_date_time_picker";
            this.inspections_date_time_picker.Size = new System.Drawing.Size(223, 32);
            this.inspections_date_time_picker.TabIndex = 0;
            this.inspections_date_time_picker.Value = new System.DateTime(2021, 4, 23, 0, 0, 0, 0);
            // 
            // inspections_button_add
            // 
            this.inspections_button_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspections_button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.inspections_button_add.Enabled = false;
            this.inspections_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_add.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.inspections_button_add.ForeColor = System.Drawing.Color.White;
            this.inspections_button_add.Location = new System.Drawing.Point(614, 24);
            this.inspections_button_add.Name = "inspections_button_add";
            this.inspections_button_add.Size = new System.Drawing.Size(360, 50);
            this.inspections_button_add.TabIndex = 22;
            this.inspections_button_add.Text = "Добавить в расписание";
            this.inspections_button_add.UseVisualStyleBackColor = false;
            this.inspections_button_add.Click += new System.EventHandler(this.inspections_button_add_Click);
            // 
            // inspections_button_choose_file
            // 
            this.inspections_button_choose_file.BackColor = System.Drawing.Color.White;
            this.inspections_button_choose_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_choose_file.Location = new System.Drawing.Point(217, 24);
            this.inspections_button_choose_file.Name = "inspections_button_choose_file";
            this.inspections_button_choose_file.Size = new System.Drawing.Size(162, 50);
            this.inspections_button_choose_file.TabIndex = 17;
            this.inspections_button_choose_file.Text = "Выбрать файл";
            this.inspections_button_choose_file.UseVisualStyleBackColor = false;
            this.inspections_button_choose_file.Click += new System.EventHandler(this.inspections_button_choose_file_Click);
            // 
            // inspections_button_choose_dir
            // 
            this.inspections_button_choose_dir.BackColor = System.Drawing.Color.White;
            this.inspections_button_choose_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_choose_dir.Location = new System.Drawing.Point(8, 24);
            this.inspections_button_choose_dir.Name = "inspections_button_choose_dir";
            this.inspections_button_choose_dir.Size = new System.Drawing.Size(203, 50);
            this.inspections_button_choose_dir.TabIndex = 18;
            this.inspections_button_choose_dir.Text = "Выбрать директорию";
            this.inspections_button_choose_dir.UseVisualStyleBackColor = false;
            this.inspections_button_choose_dir.Click += new System.EventHandler(this.inspections_button_choose_dir_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.quarantine_button_update);
            this.tabPage4.Controls.Add(this.quarantine_button_handle);
            this.tabPage4.Controls.Add(this.quarantine_list);
            this.tabPage4.Font = new System.Drawing.Font("Candara Light", 12F);
            this.tabPage4.Location = new System.Drawing.Point(4, 47);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(982, 604);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Карантин";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // quarantine_button_update
            // 
            this.quarantine_button_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.quarantine_button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quarantine_button_update.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.quarantine_button_update.ForeColor = System.Drawing.Color.White;
            this.quarantine_button_update.Location = new System.Drawing.Point(225, 3);
            this.quarantine_button_update.Name = "quarantine_button_update";
            this.quarantine_button_update.Size = new System.Drawing.Size(200, 50);
            this.quarantine_button_update.TabIndex = 27;
            this.quarantine_button_update.Text = "Обновить список";
            this.quarantine_button_update.UseVisualStyleBackColor = false;
            this.quarantine_button_update.Click += new System.EventHandler(this.quarantine_button_update_Click);
            // 
            // quarantine_button_handle
            // 
            this.quarantine_button_handle.BackColor = System.Drawing.Color.OrangeRed;
            this.quarantine_button_handle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quarantine_button_handle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.quarantine_button_handle.ForeColor = System.Drawing.Color.White;
            this.quarantine_button_handle.Location = new System.Drawing.Point(8, 3);
            this.quarantine_button_handle.Name = "quarantine_button_handle";
            this.quarantine_button_handle.Size = new System.Drawing.Size(211, 50);
            this.quarantine_button_handle.TabIndex = 26;
            this.quarantine_button_handle.Text = "Обработать список";
            this.quarantine_button_handle.UseVisualStyleBackColor = false;
            this.quarantine_button_handle.Click += new System.EventHandler(this.quarantine_button_handle_Click);
            // 
            // quarantine_list
            // 
            this.quarantine_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quarantine_list.AutoScroll = true;
            this.quarantine_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quarantine_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.quarantine_list.Location = new System.Drawing.Point(8, 56);
            this.quarantine_list.Name = "quarantine_list";
            this.quarantine_list.Size = new System.Drawing.Size(966, 545);
            this.quarantine_list.TabIndex = 25;
            this.quarantine_list.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 655);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "Form1";
            this.Text = "Антивирус";
            this.MainMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button scanning_button_choose_dir;
        private System.Windows.Forms.Button scanning_button_choose_file;
        private System.Windows.Forms.TextBox scanning_textbox_log;
        private System.Windows.Forms.Label scanning_label_path;
        private System.Windows.Forms.Label scanning_label_about_choose_file;
        private System.Windows.Forms.Button scanning_button_power;
        private System.Windows.Forms.Button scanning_button_power_result;
        private System.Windows.Forms.Button monitoring_button_power_result;
        private System.Windows.Forms.Label monitoring_label_path;
        private System.Windows.Forms.Label monitoring_label_about_choose_path;
        private System.Windows.Forms.Button monitoring_button_power;
        private System.Windows.Forms.Button monitoring_button_choose_dir;
        private System.Windows.Forms.Button inspections_button_add;
        private System.Windows.Forms.DateTimePicker inspections_date_time_picker;
        private System.Windows.Forms.Label inspections_label_path;
        private System.Windows.Forms.Button inspections_button_choose_file;
        private System.Windows.Forms.Label inspections_label_about_choose_path;
        private System.Windows.Forms.Button inspections_button_choose_dir;
        private System.Windows.Forms.FlowLayoutPanel scanning_list_result;
        private System.Windows.Forms.FlowLayoutPanel monitoring_list_result;
        private System.Windows.Forms.Label inspection_label;
        private System.Windows.Forms.FlowLayoutPanel inspection_list;
        private System.Windows.Forms.FlowLayoutPanel inspections_list;
        private System.Windows.Forms.Button quarantine_button_update;
        private System.Windows.Forms.Button quarantine_button_handle;
        private System.Windows.Forms.FlowLayoutPanel quarantine_list;
        private System.Windows.Forms.Button inspections_button_update;
        private System.Windows.Forms.Button inspections_button_delete;
        private System.Windows.Forms.Button inspection_button_result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}

