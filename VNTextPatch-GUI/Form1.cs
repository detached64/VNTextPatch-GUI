using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Vntextpatch_GUI
{

    public partial class Form1 : Form
    {
        private Thread _thread;
        private Process _process;
        private static List<string> _commandLine = [];
        private string path;
        private static string filepath;
        private string enginetype;
        private string xlsxname = "script.xlsx ";
        private string outPutDirectory;
        private string dirpath;

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.t1.DragEnter += new DragEventHandler(t1_DragEnter);
            this.t1.DragDrop += new DragEventHandler(t1_DragDrop);
            this.t2.DragEnter += new DragEventHandler(t2_DragEnter);
            this.t2.DragDrop += new DragEventHandler(t2_DragDrop);
            this.t3.DragEnter += new DragEventHandler(t3_DragEnter);
            this.t3.DragDrop += new DragEventHandler(t3_DragDrop);

        }
        private void t1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void t1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                t1.Lines = fileNames;
            }
        }
        private void t2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void t2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                t2.Lines = fileNames;
            }
        }
        private void t3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void t3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                t3.Lines = fileNames;
            }
        }
        //24-77行：t1,t1,t3实现drag and drop

        private void Form1_Load(object sender, EventArgs e)
        {
            outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var exepath = Path.Combine(outPutDirectory, "bin\\VNTextPatch.exe");
            
            filepath = new Uri(exepath).LocalPath;
            dirpath = new Uri(outPutDirectory).LocalPath;
            this.jsonbut.Checked = true;//默认json模式
            this.comboBox1.SelectedIndex = 0;//默认选择“自动选择”
            txtStatus.AppendText("注：script.xlsx在"+ dirpath+"中保存。");
            txtStatus.AppendText(Environment.NewLine);
            if (!File.Exists(dirpath + "\\bin\\VNTextPatch.exe"))
            {
                MessageBox.Show("未找到VNTextPatch.exe。请在该程序目录下新建bin文件夹，再从https://github.com/arcusmaximus/VNTranslationTools/releases/tag/v0.0.41下载最新release，最后将VNTextPatch文件夹的文件全部放到bin文件夹。", "Error");
                Environment.Exit(-1);
            }
            else
            {
                txtStatus.AppendText("已找到VNTextPatch.exe。");
                txtStatus.AppendText(Environment.NewLine);
            }

        }

        private void choose1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.t1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void choose2_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.t2.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void choose3_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.t3.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void extract_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    enginetype = "";
                    break;
                case 1:
                    enginetype = "--format=artemistxt ";
                    break;
                case 2:
                    enginetype = "--format=ethornell ";
                    break;
                case 3:
                    enginetype = "--format=kirikiriks ";
                    break;
                case 4:
                    enginetype = "--format=reallive ";
                    break;
                case 5:
                    enginetype = "--format=tmrhiroadvsystemtext ";
                    break;
                case 6:
                    enginetype = "--format=whale ";
                    break;
                default:
                    break;
            }
            if (this.jsonbut.Checked)
            {
                if (this.t1.Text == "" || this.t2.Text == "")
                {
                    txtStatus.AppendText("请确保原文件路径和提取路径完整。");
                    txtStatus.AppendText(Environment.NewLine);
                    return;
                }
                path = "extractlocal " + enginetype + this.t1.Text + " " + this.t2.Text + " ";
                _thread?.Interrupt();
                if (_process is { HasExited: false })
                    _process.Kill();
                _thread = new Thread(Start);
                _thread.Start();

            }
            else if (this.xlsxbut.Checked)
            {
                if (this.t1.Text == "" || this.t2.Text == "")
                {
                    txtStatus.AppendText("请确保原文件路径完整。");
                    txtStatus.AppendText(Environment.NewLine);
                    return;
                }
                path = "extractlocal " + enginetype + this.t1.Text + " " + xlsxname;
                _thread?.Interrupt();
                if (_process is { HasExited: false })
                    _process.Kill();
                _thread = new Thread(Start);
                _thread.Start();
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    enginetype = "";
                    break;
                case 1:
                    enginetype = "--format=artemistxt ";
                    break;
                case 2:
                    enginetype = "--format=ethornell ";
                    break;
                case 3:
                    enginetype = "--format=kirikiriks ";
                    break;
                case 4:
                    enginetype = "--format=reallive ";
                    break;
                case 5:
                    enginetype = "--format=tmrhiroadvsystemtext ";
                    break;
                case 6:
                    enginetype = "--format=whale ";
                    break;
            }
            if (this.jsonbut.Checked)
            {
                if (this.t1.Text == "" || this.t2.Text == "" || this.t3.Text == "")
                {
                    txtStatus.AppendText("请确保原文件路径、提取路径和封装路径完整。");
                    txtStatus.AppendText(Environment.NewLine);
                    return;
                }
                path = "insertlocal " + enginetype + this.t1.Text + " " + this.t2.Text + " " + this.t3.Text + " ";
                _thread?.Interrupt();
                if (_process is { HasExited: false })
                    _process.Kill();
                _thread = new Thread(Start);
                _thread.Start();
            }
            else if (this.xlsxbut.Checked)
            {
                if (this.t1.Text == "" || this.t3.Text == "")
                {
                    txtStatus.AppendText("请确保原文件路径和封装路径完整。");
                    txtStatus.AppendText(Environment.NewLine);
                    return;
                }
                path = "insertlocal " + enginetype + this.t1.Text + " " + xlsxname + this.t3.Text + " ";
                _thread?.Interrupt();
                if (_process is { HasExited: false })
                    _process.Kill();
                _thread = new Thread(Start);
                _thread.Start();
            }
        }

        private void Start()
        {
            _process = new Process();
            var startInfo = new ProcessStartInfo
            {
                Arguments = string.Join(" ", path),
                FileName = filepath,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };
            startInfo.EnvironmentVariables.Add("SHELL", "");

            _process.OutputDataReceived += DataReceived;
            _process.StartInfo = startInfo;

            if (_process.Start())
            {
                _process.BeginOutputReadLine();
                _process.WaitForExit();
            }
            else
            {
                txtLog.AppendText("无法启动cmd。" + Environment.NewLine);
            }
            path = "";
            enginetype = "";
        }
        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            txtLog.AppendText(e.Data + Environment.NewLine);
        }
        //start与datareceived参考smart-de4dot
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void q_Click(object sender, EventArgs e)
        {
            MessageBox.Show("某些引擎由于后缀名重复等问题，需手动指定引擎名。\n如果报错extension not supported，请尝试指定引擎名。\n请注意，如果指定了错误的引擎，会导致提取失败。");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear1_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
        }

        private void savepath_Click(object sender, EventArgs e)
        {
            Path_ pa = new Path_();
            pa.path1 = this.t1.Text;
            pa.path2 = this.t2.Text;
            pa.path3 = this.t3.Text;
            pa.jsonchk = this.jsonbut.Checked;
            pa.xlsxchk = this.xlsxbut.Checked;
            pa.engineindex = this.comboBox1.SelectedIndex;
            FileStream fs = new FileStream("path.ini", FileMode.Create, FileAccess.ReadWrite);
#pragma warning disable SYSLIB0011//binaryformatter过时报错；binary存储，ini文件暂不可读
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, pa);
            fs.Close();
            txtStatus.AppendText("保存配置成功！");
            txtStatus.AppendText(Environment.NewLine);
        }

        private void loadpath_Click(object sender, EventArgs e)
        {
            if(!File.Exists(dirpath + "\\path.ini"))
            {
                txtStatus.AppendText("无可读取的配置文件。");
                txtStatus.AppendText(Environment.NewLine);
                return;
            }
            FileStream fs = new FileStream("path.ini", FileMode.Open, FileAccess.ReadWrite);
#pragma warning disable SYSLIB0011
            BinaryFormatter bf = new BinaryFormatter();
            Path_ pa = new Path_();
            pa = (Path_)bf.Deserialize(fs);
            this.t1.Text = pa.path1;
            this.t2.Text = pa.path2;
            this.t3.Text = pa.path3;
            this.jsonbut.Checked = pa.jsonchk;
            this.xlsxbut.Checked = pa.xlsxchk;
            this.comboBox1.SelectedIndex = pa.engineindex;
            fs.Close();
            txtStatus.AppendText("读取配置成功！");
            txtStatus.AppendText(Environment.NewLine);


        }

        private void about_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
