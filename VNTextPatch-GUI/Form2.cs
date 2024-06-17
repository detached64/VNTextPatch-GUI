using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vntextpatch_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //两个超链接
        private void refopen_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            refopen.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://github.com/arcusmaximus/VNTranslationTools") { UseShellExecute = true });
        }
        //net6后超链接“找不到指定的文件”：https://blog.csdn.net/mzl87/article/details/125782534

        private void myopen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refopen.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://github.com/detached64/VNTextPatch-GUI") { UseShellExecute = true });
        }
    }
}
