namespace VNTextPatchGUI
{
    partial class Main
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
            lbInput1 = new Label();
            t1 = new TextBox();
            lbInput2 = new Label();
            t2 = new TextBox();
            lbInput3 = new Label();
            t3 = new TextBox();
            choose2 = new Button();
            choose3 = new Button();
            choose1 = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            extract = new Button();
            insert = new Button();
            savepath = new Button();
            txtOutput = new TextBox();
            comboBox1 = new ComboBox();
            engine = new Label();
            btQuestion = new Button();
            clear1 = new Button();
            jsonbut = new RadioButton();
            xlsxbut = new RadioButton();
            txtLog = new TextBox();
            label1 = new Label();
            label2 = new Label();
            clear2 = new Button();
            loadpath = new Button();
            about = new Button();
            SuspendLayout();
            // 
            // lbInput1
            // 
            lbInput1.AutoSize = true;
            lbInput1.Location = new Point(53, 36);
            lbInput1.Name = "lbInput1";
            lbInput1.Size = new Size(100, 24);
            lbInput1.TabIndex = 0;
            lbInput1.Text = "原文件路径";
            // 
            // t1
            // 
            t1.AllowDrop = true;
            t1.BorderStyle = BorderStyle.FixedSingle;
            t1.Location = new Point(170, 33);
            t1.Name = "t1";
            t1.Size = new Size(550, 30);
            t1.TabIndex = 1;
            // 
            // lbInput2
            // 
            lbInput2.AutoSize = true;
            lbInput2.Location = new Point(71, 87);
            lbInput2.Name = "lbInput2";
            lbInput2.Size = new Size(82, 24);
            lbInput2.TabIndex = 0;
            lbInput2.Text = "提取路径";
            // 
            // t2
            // 
            t2.AllowDrop = true;
            t2.BorderStyle = BorderStyle.FixedSingle;
            t2.Location = new Point(170, 85);
            t2.Name = "t2";
            t2.Size = new Size(550, 30);
            t2.TabIndex = 1;
            // 
            // lbInput3
            // 
            lbInput3.AutoSize = true;
            lbInput3.Location = new Point(71, 140);
            lbInput3.Name = "lbInput3";
            lbInput3.Size = new Size(82, 24);
            lbInput3.TabIndex = 0;
            lbInput3.Text = "封装路径";
            // 
            // t3
            // 
            t3.AllowDrop = true;
            t3.BorderStyle = BorderStyle.FixedSingle;
            t3.Location = new Point(170, 137);
            t3.Name = "t3";
            t3.Size = new Size(550, 30);
            t3.TabIndex = 1;
            // 
            // choose2
            // 
            choose2.Location = new Point(726, 85);
            choose2.Name = "choose2";
            choose2.Size = new Size(35, 30);
            choose2.TabIndex = 2;
            choose2.Text = "…";
            choose2.UseVisualStyleBackColor = true;
            choose2.Click += choose2_Click;
            // 
            // choose3
            // 
            choose3.Location = new Point(726, 137);
            choose3.Name = "choose3";
            choose3.Size = new Size(35, 30);
            choose3.TabIndex = 2;
            choose3.Text = "…";
            choose3.UseVisualStyleBackColor = true;
            choose3.Click += choose3_Click;
            // 
            // choose1
            // 
            choose1.Location = new Point(726, 33);
            choose1.Name = "choose1";
            choose1.Size = new Size(35, 30);
            choose1.TabIndex = 2;
            choose1.Text = "…";
            choose1.UseVisualStyleBackColor = true;
            choose1.Click += choose1_Click;
            // 
            // extract
            // 
            extract.Location = new Point(218, 245);
            extract.Name = "extract";
            extract.Size = new Size(118, 37);
            extract.TabIndex = 3;
            extract.Text = "提取";
            extract.UseVisualStyleBackColor = true;
            extract.Click += extract_Click;
            // 
            // insert
            // 
            insert.Location = new Point(342, 245);
            insert.Name = "insert";
            insert.Size = new Size(118, 37);
            insert.TabIndex = 3;
            insert.Text = "封装";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // savepath
            // 
            savepath.Location = new Point(491, 245);
            savepath.Name = "savepath";
            savepath.Size = new Size(137, 37);
            savepath.TabIndex = 3;
            savepath.Text = "保存配置";
            savepath.UseVisualStyleBackColor = true;
            savepath.Click += savepath_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.InfoText;
            txtOutput.BorderStyle = BorderStyle.FixedSingle;
            txtOutput.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutput.ForeColor = SystemColors.Window;
            txtOutput.Location = new Point(43, 332);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(728, 408);
            txtOutput.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "自动判断", "Artemis-.txt", "BGI(Ethornell)", "Kirikiri-.txt", "Reallive-.txt", "TmrHiroAdvSystem", "Whale-.txt" });
            comboBox1.Location = new Point(170, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(550, 32);
            comboBox1.TabIndex = 5;
            // 
            // engine
            // 
            engine.AutoSize = true;
            engine.Location = new Point(71, 193);
            engine.Name = "engine";
            engine.Size = new Size(82, 24);
            engine.TabIndex = 6;
            engine.Text = "指定引擎";
            // 
            // btQuestion
            // 
            btQuestion.Location = new Point(726, 189);
            btQuestion.Name = "btQuestion";
            btQuestion.Size = new Size(35, 32);
            btQuestion.TabIndex = 7;
            btQuestion.Text = "?";
            btQuestion.UseVisualStyleBackColor = true;
            btQuestion.Click += q_Click;
            // 
            // clear1
            // 
            clear1.FlatStyle = FlatStyle.System;
            clear1.Location = new Point(639, 703);
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
            jsonbut.Location = new Point(43, 249);
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
            xlsxbut.Location = new Point(119, 249);
            xlsxbut.Name = "xlsxbut";
            xlsxbut.Size = new Size(66, 28);
            xlsxbut.TabIndex = 10;
            xlsxbut.TabStop = true;
            xlsxbut.Text = "xlsx";
            xlsxbut.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.InfoText;
            txtLog.BorderStyle = BorderStyle.FixedSingle;
            txtLog.ForeColor = SystemColors.Window;
            txtLog.Location = new Point(43, 784);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(728, 140);
            txtLog.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 305);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 12;
            label1.Text = "输出";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 757);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 13;
            label2.Text = "状态栏";
            // 
            // clear2
            // 
            clear2.FlatStyle = FlatStyle.System;
            clear2.Location = new Point(639, 887);
            clear2.Name = "clear2";
            clear2.Size = new Size(108, 37);
            clear2.TabIndex = 14;
            clear2.Text = "清空";
            clear2.UseVisualStyleBackColor = true;
            clear2.Click += clear2_Click;
            // 
            // loadpath
            // 
            loadpath.Location = new Point(634, 245);
            loadpath.Name = "loadpath";
            loadpath.Size = new Size(137, 37);
            loadpath.TabIndex = 15;
            loadpath.Text = "读取配置";
            loadpath.UseVisualStyleBackColor = true;
            loadpath.Click += loadpath_Click;
            // 
            // about
            // 
            about.Location = new Point(43, 940);
            about.Name = "about";
            about.Size = new Size(142, 35);
            about.TabIndex = 16;
            about.Text = "关于";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 1008);
            Controls.Add(about);
            Controls.Add(loadpath);
            Controls.Add(clear2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLog);
            Controls.Add(xlsxbut);
            Controls.Add(jsonbut);
            Controls.Add(clear1);
            Controls.Add(btQuestion);
            Controls.Add(engine);
            Controls.Add(comboBox1);
            Controls.Add(txtOutput);
            Controls.Add(savepath);
            Controls.Add(insert);
            Controls.Add(extract);
            Controls.Add(choose3);
            Controls.Add(choose1);
            Controls.Add(choose2);
            Controls.Add(t3);
            Controls.Add(lbInput3);
            Controls.Add(t2);
            Controls.Add(lbInput2);
            Controls.Add(t1);
            Controls.Add(lbInput1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VNTextPatch-GUI";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label exe;
        private TextBox txtOutput;
        private Label lbInput1;
        private TextBox t1;
        private Label lbInput2;
        private TextBox t2;
        private Label lbInput3;
        private TextBox t3;
        private Button choose2;
        private Button choose3;
        private Button choose1;
        private FolderBrowserDialog folderBrowserDialog;
        private Button extract;
        private Button insert;
        private Button savepath;
        private ComboBox comboBox1;
        private Label engine;
        private Button btQuestion;
        private Button clear1;
        private RadioButton jsonbut;
        private RadioButton xlsxbut;
        private TextBox txtLog;
        private Label label1;
        private Label label2;
        private Button clear2;
        private Button loadpath;
        private Button about;
    }
}
