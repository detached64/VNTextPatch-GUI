namespace Vntextpatch_GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            myopen = new LinkLabel();
            refopen = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 132);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 0;
            label1.Text = "VNTextPatch:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 91);
            label2.Name = "label2";
            label2.Size = new Size(140, 24);
            label2.TabIndex = 0;
            label2.Text = "本软件开源地址:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 203);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 2;
            label3.Text = "MIT License";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 238);
            label4.Name = "label4";
            label4.Size = new Size(280, 24);
            label4.TabIndex = 2;
            label4.Text = "Copyright (c) 2024 detached64";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 299);
            label5.Name = "label5";
            label5.Size = new Size(222, 24);
            label5.TabIndex = 3;
            label5.Text = "Complied on 2024.06.17";
            // 
            // myopen
            // 
            myopen.AutoSize = true;
            myopen.Cursor = Cursors.Hand;
            myopen.Location = new Point(214, 91);
            myopen.Name = "myopen";
            myopen.Size = new Size(443, 24);
            myopen.TabIndex = 4;
            myopen.TabStop = true;
            myopen.Text = "https://github.com/detached64/VNTextPatch-GUI";
            myopen.LinkClicked += myopen_LinkClicked;
            // 
            // refopen
            // 
            refopen.AutoSize = true;
            refopen.Cursor = Cursors.Hand;
            refopen.Location = new Point(214, 132);
            refopen.Name = "refopen";
            refopen.Size = new Size(479, 24);
            refopen.TabIndex = 5;
            refopen.TabStop = true;
            refopen.Text = "https://github.com/arcusmaximus/VNTranslationTools";
            refopen.LinkClicked += refopen_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refopen);
            Controls.Add(myopen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "关于";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel myopen;
        private LinkLabel refopen;
    }
}