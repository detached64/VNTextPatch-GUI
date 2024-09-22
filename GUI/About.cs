using System.Diagnostics;
using VNTextPatchGUI.Settings;

namespace VNTextPatchGUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.caption.Text = "VNTextPatch-GUI " + Global.version;
        }

        private void refopen_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            refopen.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://github.com/arcusmaximus/VNTranslationTools") { UseShellExecute = true });
        }

        private void myopen_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            myopen.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://github.com/detached64/VNTextPatch-GUI") { UseShellExecute = true });
        }

    }
}
