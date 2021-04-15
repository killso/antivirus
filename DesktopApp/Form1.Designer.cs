
namespace DesktopApp
{
    partial class Form
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
            this.scanning_progress_bar = new System.Windows.Forms.ProgressBar();
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
            this.monitoring_button_choose_file = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inspection_label = new System.Windows.Forms.Label();
            this.inspection_list = new System.Windows.Forms.FlowLayoutPanel();
            this.inspections_list = new System.Windows.Forms.FlowLayoutPanel();
            this.inspections_date_time_picker = new System.Windows.Forms.DateTimePicker();
            this.inspections_button_add = new System.Windows.Forms.Button();
            this.inspections_label_path = new System.Windows.Forms.Label();
            this.inspections_button_choose_file = new System.Windows.Forms.Button();
            this.inspections_label_about_choose_path = new System.Windows.Forms.Label();
            this.inspections_button_choose_dir = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.quarantine_button_update = new System.Windows.Forms.Button();
            this.quarantine_button_delete = new System.Windows.Forms.Button();
            this.quarantine_list = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.MainMenu.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.tabPage1.Controls.Add(this.scanning_progress_bar);
            this.tabPage1.Controls.Add(this.scanning_button_power);
            this.tabPage1.Controls.Add(this.scanning_button_choose_dir);
            this.tabPage1.Controls.Add(this.scanning_button_choose_file);
            this.tabPage1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 609);
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
            this.scanning_button_power_result.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.scanning_textbox_log.Size = new System.Drawing.Size(976, 97);
            this.scanning_textbox_log.TabIndex = 6;
            // 
            // scanning_label_path
            // 
            this.scanning_label_path.AutoSize = true;
            this.scanning_label_path.Location = new System.Drawing.Point(59, 26);
            this.scanning_label_path.Name = "scanning_label_path";
            this.scanning_label_path.Size = new System.Drawing.Size(21, 19);
            this.scanning_label_path.TabIndex = 5;
            this.scanning_label_path.Text = "...";
            // 
            // scanning_label_about_choose_file
            // 
            this.scanning_label_about_choose_file.AutoSize = true;
            this.scanning_label_about_choose_file.Location = new System.Drawing.Point(9, 26);
            this.scanning_label_about_choose_file.Name = "scanning_label_about_choose_file";
            this.scanning_label_about_choose_file.Size = new System.Drawing.Size(44, 19);
            this.scanning_label_about_choose_file.TabIndex = 4;
            this.scanning_label_about_choose_file.Text = "Путь:";
            // 
            // scanning_progress_bar
            // 
            this.scanning_progress_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanning_progress_bar.Location = new System.Drawing.Point(621, 60);
            this.scanning_progress_bar.Name = "scanning_progress_bar";
            this.scanning_progress_bar.Size = new System.Drawing.Size(358, 50);
            this.scanning_progress_bar.TabIndex = 3;
            // 
            // scanning_button_power
            // 
            this.scanning_button_power.BackColor = System.Drawing.SystemColors.Highlight;
            this.scanning_button_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanning_button_power.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scanning_button_power.ForeColor = System.Drawing.Color.White;
            this.scanning_button_power.Location = new System.Drawing.Point(415, 60);
            this.scanning_button_power.Name = "scanning_button_power";
            this.scanning_button_power.Size = new System.Drawing.Size(200, 50);
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
            this.scanning_button_choose_dir.Size = new System.Drawing.Size(200, 50);
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
            this.tabPage2.Controls.Add(this.monitoring_button_choose_file);
            this.tabPage2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 609);
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
            this.monitoring_button_power_result.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.monitoring_label_path.Size = new System.Drawing.Size(21, 19);
            this.monitoring_label_path.TabIndex = 13;
            this.monitoring_label_path.Text = "...";
            // 
            // monitoring_label_about_choose_path
            // 
            this.monitoring_label_about_choose_path.AutoSize = true;
            this.monitoring_label_about_choose_path.Location = new System.Drawing.Point(9, 17);
            this.monitoring_label_about_choose_path.Name = "monitoring_label_about_choose_path";
            this.monitoring_label_about_choose_path.Size = new System.Drawing.Size(44, 19);
            this.monitoring_label_about_choose_path.TabIndex = 12;
            this.monitoring_label_about_choose_path.Text = "Путь:";
            // 
            // monitoring_button_power
            // 
            this.monitoring_button_power.BackColor = System.Drawing.SystemColors.Highlight;
            this.monitoring_button_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoring_button_power.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monitoring_button_power.ForeColor = System.Drawing.Color.White;
            this.monitoring_button_power.Location = new System.Drawing.Point(415, 51);
            this.monitoring_button_power.Name = "monitoring_button_power";
            this.monitoring_button_power.Size = new System.Drawing.Size(200, 50);
            this.monitoring_button_power.TabIndex = 11;
            this.monitoring_button_power.Text = "Старт";
            this.monitoring_button_power.UseVisualStyleBackColor = false;
            this.monitoring_button_power.Click += new System.EventHandler(this.monitoring_button_power_Click);
            // 
            // monitoring_button_choose_dir
            // 
            this.monitoring_button_choose_dir.BackColor = System.Drawing.Color.White;
            this.monitoring_button_choose_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoring_button_choose_dir.Location = new System.Drawing.Point(209, 51);
            this.monitoring_button_choose_dir.Name = "monitoring_button_choose_dir";
            this.monitoring_button_choose_dir.Size = new System.Drawing.Size(200, 50);
            this.monitoring_button_choose_dir.TabIndex = 10;
            this.monitoring_button_choose_dir.Text = "Выбрать директорию";
            this.monitoring_button_choose_dir.UseVisualStyleBackColor = false;
            this.monitoring_button_choose_dir.Click += new System.EventHandler(this.monitoring_button_choose_dir_Click);
            // 
            // monitoring_button_choose_file
            // 
            this.monitoring_button_choose_file.BackColor = System.Drawing.Color.White;
            this.monitoring_button_choose_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoring_button_choose_file.Location = new System.Drawing.Point(3, 51);
            this.monitoring_button_choose_file.Name = "monitoring_button_choose_file";
            this.monitoring_button_choose_file.Size = new System.Drawing.Size(200, 50);
            this.monitoring_button_choose_file.TabIndex = 9;
            this.monitoring_button_choose_file.Text = "Выбрать файл";
            this.monitoring_button_choose_file.UseVisualStyleBackColor = false;
            this.monitoring_button_choose_file.Click += new System.EventHandler(this.monitoring_button_choose_file_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.inspection_label);
            this.tabPage3.Controls.Add(this.inspection_list);
            this.tabPage3.Controls.Add(this.inspections_list);
            this.tabPage3.Controls.Add(this.inspections_date_time_picker);
            this.tabPage3.Controls.Add(this.inspections_button_add);
            this.tabPage3.Controls.Add(this.inspections_label_path);
            this.tabPage3.Controls.Add(this.inspections_button_choose_file);
            this.tabPage3.Controls.Add(this.inspections_label_about_choose_path);
            this.tabPage3.Controls.Add(this.inspections_button_choose_dir);
            this.tabPage3.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(982, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Плановые проверки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // inspection_label
            // 
            this.inspection_label.AutoSize = true;
            this.inspection_label.Location = new System.Drawing.Point(8, 353);
            this.inspection_label.Name = "inspection_label";
            this.inspection_label.Size = new System.Drawing.Size(21, 19);
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
            this.inspection_list.Location = new System.Drawing.Point(8, 375);
            this.inspection_list.Name = "inspection_list";
            this.inspection_list.Size = new System.Drawing.Size(966, 165);
            this.inspection_list.TabIndex = 24;
            this.inspection_list.WrapContents = false;
            // 
            // inspections_list
            // 
            this.inspections_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspections_list.AutoScroll = true;
            this.inspections_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inspections_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inspections_list.Location = new System.Drawing.Point(8, 141);
            this.inspections_list.Name = "inspections_list";
            this.inspections_list.Size = new System.Drawing.Size(966, 93);
            this.inspections_list.TabIndex = 23;
            this.inspections_list.WrapContents = false;
            // 
            // inspections_date_time_picker
            // 
            this.inspections_date_time_picker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.inspections_date_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inspections_date_time_picker.Location = new System.Drawing.Point(328, 24);
            this.inspections_date_time_picker.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.inspections_date_time_picker.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.inspections_date_time_picker.Name = "inspections_date_time_picker";
            this.inspections_date_time_picker.Size = new System.Drawing.Size(157, 27);
            this.inspections_date_time_picker.TabIndex = 0;
            this.inspections_date_time_picker.Value = new System.DateTime(2021, 4, 23, 0, 0, 0, 0);
            // 
            // inspections_button_add
            // 
            this.inspections_button_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inspections_button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.inspections_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_add.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inspections_button_add.ForeColor = System.Drawing.Color.White;
            this.inspections_button_add.Location = new System.Drawing.Point(491, 24);
            this.inspections_button_add.Name = "inspections_button_add";
            this.inspections_button_add.Size = new System.Drawing.Size(483, 50);
            this.inspections_button_add.TabIndex = 22;
            this.inspections_button_add.Text = "Добавить в расписание";
            this.inspections_button_add.UseVisualStyleBackColor = false;
            this.inspections_button_add.Click += new System.EventHandler(this.inspections_button_add_Click);
            // 
            // inspections_label_path
            // 
            this.inspections_label_path.AutoSize = true;
            this.inspections_label_path.Location = new System.Drawing.Point(18, 96);
            this.inspections_label_path.Name = "inspections_label_path";
            this.inspections_label_path.Size = new System.Drawing.Size(21, 19);
            this.inspections_label_path.TabIndex = 20;
            this.inspections_label_path.Text = "...";
            // 
            // inspections_button_choose_file
            // 
            this.inspections_button_choose_file.BackColor = System.Drawing.Color.White;
            this.inspections_button_choose_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_choose_file.Location = new System.Drawing.Point(188, 24);
            this.inspections_button_choose_file.Name = "inspections_button_choose_file";
            this.inspections_button_choose_file.Size = new System.Drawing.Size(134, 50);
            this.inspections_button_choose_file.TabIndex = 17;
            this.inspections_button_choose_file.Text = "Выбрать файл";
            this.inspections_button_choose_file.UseVisualStyleBackColor = false;
            this.inspections_button_choose_file.Click += new System.EventHandler(this.inspections_button_choose_file_Click);
            // 
            // inspections_label_about_choose_path
            // 
            this.inspections_label_about_choose_path.AutoSize = true;
            this.inspections_label_about_choose_path.Location = new System.Drawing.Point(8, 77);
            this.inspections_label_about_choose_path.Name = "inspections_label_about_choose_path";
            this.inspections_label_about_choose_path.Size = new System.Drawing.Size(44, 19);
            this.inspections_label_about_choose_path.TabIndex = 19;
            this.inspections_label_about_choose_path.Text = "Путь:";
            // 
            // inspections_button_choose_dir
            // 
            this.inspections_button_choose_dir.BackColor = System.Drawing.Color.White;
            this.inspections_button_choose_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inspections_button_choose_dir.Location = new System.Drawing.Point(8, 24);
            this.inspections_button_choose_dir.Name = "inspections_button_choose_dir";
            this.inspections_button_choose_dir.Size = new System.Drawing.Size(174, 50);
            this.inspections_button_choose_dir.TabIndex = 18;
            this.inspections_button_choose_dir.Text = "Выбрать директорию";
            this.inspections_button_choose_dir.UseVisualStyleBackColor = false;
            this.inspections_button_choose_dir.Click += new System.EventHandler(this.inspections_button_choose_dir_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.quarantine_button_update);
            this.tabPage4.Controls.Add(this.quarantine_button_delete);
            this.tabPage4.Controls.Add(this.quarantine_list);
            this.tabPage4.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(982, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Карантин";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // quarantine_button_update
            // 
            this.quarantine_button_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.quarantine_button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quarantine_button_update.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quarantine_button_update.ForeColor = System.Drawing.Color.White;
            this.quarantine_button_update.Location = new System.Drawing.Point(290, 3);
            this.quarantine_button_update.Name = "quarantine_button_update";
            this.quarantine_button_update.Size = new System.Drawing.Size(200, 50);
            this.quarantine_button_update.TabIndex = 27;
            this.quarantine_button_update.Text = "Обновить список";
            this.quarantine_button_update.UseVisualStyleBackColor = false;
            // 
            // quarantine_button_delete
            // 
            this.quarantine_button_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.quarantine_button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quarantine_button_delete.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quarantine_button_delete.ForeColor = System.Drawing.Color.White;
            this.quarantine_button_delete.Location = new System.Drawing.Point(8, 3);
            this.quarantine_button_delete.Name = "quarantine_button_delete";
            this.quarantine_button_delete.Size = new System.Drawing.Size(276, 50);
            this.quarantine_button_delete.TabIndex = 26;
            this.quarantine_button_delete.Text = "Удалить  отмеченные из карантина";
            this.quarantine_button_delete.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(966, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "Обработать результаты";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(285, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 29;
            this.button2.Text = "Обновить список";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(8, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 50);
            this.button3.TabIndex = 28;
            this.button3.Text = "Удалить  отмеченные из проверок";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 655);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form";
            this.Text = "Антивирус";
            this.MainMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ProgressBar scanning_progress_bar;
        private System.Windows.Forms.Button scanning_button_power;
        private System.Windows.Forms.Button scanning_button_power_result;
        private System.Windows.Forms.Button monitoring_button_power_result;
        private System.Windows.Forms.Label monitoring_label_path;
        private System.Windows.Forms.Label monitoring_label_about_choose_path;
        private System.Windows.Forms.Button monitoring_button_power;
        private System.Windows.Forms.Button monitoring_button_choose_dir;
        private System.Windows.Forms.Button monitoring_button_choose_file;
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
        private System.Windows.Forms.Button quarantine_button_delete;
        private System.Windows.Forms.FlowLayoutPanel quarantine_list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

