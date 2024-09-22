namespace VNTextPatchGUI
{
    partial class About
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
            lb_refLink = new Label();
            lb_thisLink = new Label();
            label3 = new Label();
            label4 = new Label();
            myopen = new LinkLabel();
            refopen = new LinkLabel();
            caption = new Label();
            SuspendLayout();
            // 
            // lb_refLink
            // 
            lb_refLink.AutoSize = true;
            lb_refLink.Location = new Point(68, 157);
            lb_refLink.Name = "lb_refLink";
            lb_refLink.Size = new Size(125, 24);
            lb_refLink.TabIndex = 0;
            lb_refLink.Text = "VNTextPatch:";
            // 
            // lb_thisLink
            // 
            lb_thisLink.AutoSize = true;
            lb_thisLink.Location = new Point(68, 116);
            lb_thisLink.Name = "lb_thisLink";
            lb_thisLink.Size = new Size(86, 24);
            lb_thisLink.TabIndex = 0;
            lb_thisLink.Text = "开源地址:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 284);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 2;
            label3.Text = "MIT License";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 319);
            label4.Name = "label4";
            label4.Size = new Size(280, 24);
            label4.TabIndex = 2;
            label4.Text = "Copyright (c) 2024 detached64";
            // 
            // myopen
            // 
            myopen.AutoSize = true;
            myopen.Cursor = Cursors.Hand;
            myopen.Location = new Point(199, 116);
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
            refopen.Location = new Point(199, 157);
            refopen.Name = "refopen";
            refopen.Size = new Size(479, 24);
            refopen.TabIndex = 5;
            refopen.TabStop = true;
            refopen.Text = "https://github.com/arcusmaximus/VNTranslationTools";
            refopen.LinkClicked += refopen_LinkClicked;
            // 
            // caption
            // 
            caption.AutoSize = true;
            caption.Location = new Point(68, 76);
            caption.Name = "caption";
            caption.Size = new Size(160, 24);
            caption.TabIndex = 6;
            caption.Text = "VNTextPatch-GUI";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(caption);
            Controls.Add(refopen);
            Controls.Add(myopen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lb_thisLink);
            Controls.Add(lb_refLink);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "关于";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_refLink;
        private Label lb_thisLink;
        private Label label3;
        private Label label4;
        private LinkLabel myopen;
        private LinkLabel refopen;
        private Label caption;
    }
}