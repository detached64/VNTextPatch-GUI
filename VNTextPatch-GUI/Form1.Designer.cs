namespace Vntextpatch_GUI
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
            Input = new Label();
            t1 = new TextBox();
            label3 = new Label();
            t2 = new TextBox();
            label4 = new Label();
            t3 = new TextBox();
            choose2 = new Button();
            choose3 = new Button();
            choose1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            extract = new Button();
            insert = new Button();
            savepath = new Button();
            txtLog = new TextBox();
            comboBox1 = new ComboBox();
            engine = new Label();
            q = new Button();
            clear1 = new Button();
            jsonbut = new RadioButton();
            xlsxbut = new RadioButton();
            txtStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            clear2 = new Button();
            loadpath = new Button();
            about = new Button();
            SuspendLayout();
            // 
            // Input
            // 
            Input.AutoSize = true;
            Input.Location = new Point(43, 53);
            Input.Name = "Input";
            Input.Size = new Size(100, 24);
            Input.TabIndex = 0;
            Input.Text = "原文件路径";
            // 
            // t1
            // 
            t1.AllowDrop = true;
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Location = new Point(180, 50);
            t1.Name = "t1";
            t1.Size = new Size(550, 30);
            t1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 104);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 0;
            label3.Text = "提取路径";
            // 
            // t2
            // 
            t2.AllowDrop = true;
            t2.BorderStyle = BorderStyle.FixedSingle;
            t2.Location = new Point(180, 102);
            t2.Name = "t2";
            t2.Size = new Size(550, 30);
            t2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 157);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 0;
            label4.Text = "封装路径";
            // 
            // t3
            // 
            t3.AllowDrop = true;
            t3.BorderStyle = BorderStyle.FixedSingle;
            t3.Location = new Point(180, 154);
            t3.Name = "t3";
            t3.Size = new Size(550, 30);
            t3.TabIndex = 1;
            // 
            // choose2
            // 
            choose2.Location = new Point(736, 102);
            choose2.Name = "choose2";
            choose2.Size = new Size(35, 30);
            choose2.TabIndex = 2;
            choose2.Text = "…";
            choose2.UseVisualStyleBackColor = true;
            choose2.Click += choose2_Click;
            // 
            // choose3
            // 
            choose3.Location = new Point(736, 154);
            choose3.Name = "choose3";
            choose3.Size = new Size(35, 30);
            choose3.TabIndex = 2;
            choose3.Text = "…";
            choose3.UseVisualStyleBackColor = true;
            choose3.Click += choose3_Click;
            // 
            // choose1
            // 
            choose1.Location = new Point(736, 50);
            choose1.Name = "choose1";
            choose1.Size = new Size(35, 30);
            choose1.TabIndex = 2;
            choose1.Text = "…";
            choose1.UseVisualStyleBackColor = true;
            choose1.Click += choose1_Click;
            // 
            // extract
            // 
            extract.Location = new Point(203, 262);
            extract.Name = "extract";
            extract.Size = new Size(137, 37);
            extract.TabIndex = 3;
            extract.Text = "提取";
            extract.UseVisualStyleBackColor = true;
            extract.Click += extract_Click;
            // 
            // insert
            // 
            insert.Location = new Point(346, 262);
            insert.Name = "insert";
            insert.Size = new Size(137, 37);
            insert.TabIndex = 3;
            insert.Text = "封装";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // savepath
            // 
            savepath.Location = new Point(499, 262);
            savepath.Name = "savepath";
            savepath.Size = new Size(137, 37);
            savepath.TabIndex = 3;
            savepath.Text = "保存配置";
            savepath.UseVisualStyleBackColor = true;
            savepath.Click += savepath_Click;
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.InfoText;
            txtLog.BorderStyle = BorderStyle.FixedSingle;
            txtLog.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLog.ForeColor = SystemColors.Window;
            txtLog.Location = new Point(43, 338);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(728, 368);
            txtLog.TabIndex = 4;
            txtLog.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "自动判断", "Artemis-.txt", "BGI(Ethornell)", "Kirikiri-.txt", "Reallive-.txt", "TmrHiroAdvSystem", "Whale-.txt" });
            comboBox1.Location = new Point(180, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(550, 32);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // engine
            // 
            engine.AutoSize = true;
            engine.Location = new Point(61, 210);
            engine.Name = "engine";
            engine.Size = new Size(82, 24);
            engine.TabIndex = 6;
            engine.Text = "指定引擎";
            // 
            // q
            // 
            q.Location = new Point(736, 206);
            q.Name = "q";
            q.Size = new Size(35, 32);
            q.TabIndex = 7;
            q.Text = "?";
            q.UseVisualStyleBackColor = true;
            q.Click += q_Click;
            // 
            // clear1
            // 
            clear1.FlatStyle = FlatStyle.System;
            clear1.Location = new Point(639, 669);
            clear1.Name = "clear1";
            clear1.Size = new Size(108, 37);
            clear1.TabIndex = 8;
            clear1.Text = "清空";
            clear1.UseVisualStyleBackColor = true;
            clear1.Click += clear1_Click;
            // 
            // jsonbut
            // 
            jsonbut.AutoSize = true;
            jsonbut.Location = new Point(43, 266);
            jsonbut.Name = "jsonbut";
            jsonbut.Size = new Size(70, 28);
            jsonbut.TabIndex = 9;
            jsonbut.TabStop = true;
            jsonbut.Text = "json";
            jsonbut.UseVisualStyleBackColor = true;
            // 
            // xlsxbut
            // 
            xlsxbut.AutoSize = true;
            xlsxbut.Location = new Point(119, 266);
            xlsxbut.Name = "xlsxbut";
            xlsxbut.Size = new Size(66, 28);
            xlsxbut.TabIndex = 10;
            xlsxbut.TabStop = true;
            xlsxbut.Text = "xlsx";
            xlsxbut.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.InfoText;
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.ForeColor = SystemColors.Window;
            txtStatus.Location = new Point(43, 751);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(728, 119);
            txtStatus.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 311);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 12;
            label1.Text = "cmd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 724);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 13;
            label2.Text = "状态栏";
            // 
            // clear2
            // 
            clear2.FlatStyle = FlatStyle.System;
            clear2.Location = new Point(639, 833);
            clear2.Name = "clear2";
            clear2.Size = new Size(108, 37);
            clear2.TabIndex = 14;
            clear2.Text = "清空";
            clear2.UseVisualStyleBackColor = true;
            clear2.Click += clear2_Click;
            // 
            // loadpath
            // 
            loadpath.Location = new Point(642, 262);
            loadpath.Name = "loadpath";
            loadpath.Size = new Size(137, 37);
            loadpath.TabIndex = 15;
            loadpath.Text = "读取配置";
            loadpath.UseVisualStyleBackColor = true;
            loadpath.Click += loadpath_Click;
            // 
            // about
            // 
            about.Location = new Point(43, 887);
            about.Name = "about";
            about.Size = new Size(142, 35);
            about.TabIndex = 16;
            about.Text = "关于";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 947);
            Controls.Add(about);
            Controls.Add(loadpath);
            Controls.Add(clear2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStatus);
            Controls.Add(xlsxbut);
            Controls.Add(jsonbut);
            Controls.Add(clear1);
            Controls.Add(q);
            Controls.Add(engine);
            Controls.Add(comboBox1);
            Controls.Add(txtLog);
            Controls.Add(savepath);
            Controls.Add(insert);
            Controls.Add(extract);
            Controls.Add(choose3);
            Controls.Add(choose1);
            Controls.Add(choose2);
            Controls.Add(t3);
            Controls.Add(label4);
            Controls.Add(t2);
            Controls.Add(label3);
            Controls.Add(t1);
            Controls.Add(Input);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VNTextPatch-GUI 1.0.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exe;
        private TextBox txtLog;
        private Label Input;
        private TextBox t1;
        private Label label3;
        private TextBox t2;
        private Label label4;
        private TextBox t3;
        private Button choose2;
        private Button choose3;
        private Button choose1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button extract;
        private Button insert;
        private Button savepath;
        private ComboBox comboBox1;
        private Label engine;
        private Button q;
        private Button clear1;
        private RadioButton jsonbut;
        private RadioButton xlsxbut;
        private TextBox txtStatus;
        private Label label1;
        private Label label2;
        private Button clear2;
        private Button loadpath;
        private Button about;
    }
}
