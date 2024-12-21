using System.Diagnostics;
using System.Text.Json;
using VNTextPatchGUI.Settings;

namespace VNTextPatchGUI
{
    public partial class Main : Form
    {
        private Thread? _thread;
        private Process? _process;

        private string? parameters;
        private string? enginetype;

        private readonly string XlsxName = "script.xlsx";

        private readonly string dirpath = AppContext.BaseDirectory;
        private readonly string filepath = "bin\\VNTextPatch\\VNTextPatch.exe";
        private readonly string configpath = "config.json";

        public Main()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.t1.DragEnter += t1_DragEnter;
            this.t1.DragDrop += t1_DragDrop;
            this.t2.DragEnter += t2_DragEnter;
            this.t2.DragDrop += t2_DragDrop;
            this.t3.DragEnter += t3_DragEnter;
            this.t3.DragDrop += t3_DragDrop;
        }

        private void t1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void t1_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data is string[] fileNames)
                {
                    t1.Lines = fileNames;
                }
            }
        }
        private void t2_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None; // Optional: Handle other cases
            }
        }
        private void t2_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data is string[] fileNames)
                {
                    t2.Lines = fileNames;
                }
            }
        }
        private void t3_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None; // Optional: Handle other cases
            }
        }
        private void t3_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data is string[] fileNames)
                {
                    t3.Lines = fileNames;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filepath))
            {
                MessageBox.Show("δ�ҵ�VNTextPatch.exe�����ڸó���Ŀ¼���½�bin�ļ��У��ٴ�https://github.com/arcusmaximus/VNTranslationTools/releases/latest��������release�����VNTextPatch�ļ��и��Ƶ�bin�ļ��С�", "Error");
                Environment.Exit(-1);
            }
            this.jsonbut.Checked = true;        //Ĭ��jsonģʽ
            this.comboBox1.SelectedIndex = 0;   //Ĭ��ѡ���Զ�ѡ��
            WriteLog($"ע��script.xlsx��{dirpath}�б��档");
        }

        private void choose1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.t1.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void choose2_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.t2.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void choose3_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.t3.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void extract_Click(object sender, EventArgs e)
        {
            enginetype = comboBox1.SelectedIndex switch
            {
                1 => "--format=artemistxt",
                2 => "--format=ethornell",
                3 => "--format=kirikiriks",
                4 => "--format=reallive",
                5 => "--format=tmrhiroadvsystemtext",
                6 => "--format=whale",
                _ => string.Empty,
            };
            if (this.jsonbut.Checked)
            {
                if (this.t1.Text?.Length == 0 || this.t2.Text?.Length == 0)
                {
                    WriteLog("��ȷ��ԭ�ļ�·������ȡ·��������");
                    return;
                }
                parameters = $"extractlocal {enginetype} {this.t1.Text} {this.t2.Text}";
            }
            else if (this.xlsxbut.Checked)
            {
                if (this.t1.Text?.Length == 0 || this.t2.Text?.Length == 0)
                {
                    WriteLog("��ȷ��ԭ�ļ�·��������");
                    return;
                }
                parameters = $"extractlocal {enginetype} {this.t1.Text} {XlsxName}";
            }

            _thread?.Interrupt();
            if (_process is { HasExited: false })
            {
                _process.Kill();
            }

            _thread = new Thread(Start);
            _thread.Start();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            enginetype = comboBox1.SelectedIndex switch
            {
                1 => "--format=artemistxt",
                2 => "--format=ethornell",
                3 => "--format=kirikiriks",
                4 => "--format=reallive",
                5 => "--format=tmrhiroadvsystemtext",
                6 => "--format=whale",
                _ => string.Empty,
            };
            if (this.jsonbut.Checked)
            {
                if (this.t1.Text?.Length == 0 || this.t2.Text?.Length == 0 || this.t3.Text?.Length == 0)
                {
                    WriteLog("��ȷ��ԭ�ļ�·������ȡ·���ͷ�װ·��������");
                    return;
                }
                parameters = $"insertlocal {enginetype} {this.t1.Text} {this.t2.Text} {this.t3.Text}";
                _thread?.Interrupt();
            }
            else if (this.xlsxbut.Checked)
            {
                if (this.t1.Text?.Length == 0 || this.t3.Text?.Length == 0)
                {
                    txtLog.AppendText("��ȷ��ԭ�ļ�·���ͷ�װ·��������");
                    txtLog.AppendText(Environment.NewLine);
                    return;
                }
                parameters = "insertlocal " + enginetype + this.t1.Text + " " + XlsxName + this.t3.Text + " ";
            }

            _thread?.Interrupt();
            if (_process is { HasExited: false })
            {
                _process.Kill();
            }

            _thread = new Thread(Start);
            _thread.Start();
        }

        private void Start()
        {
            _process = new Process();
            var startInfo = new ProcessStartInfo
            {
                Arguments = string.Join(" ", parameters),
                FileName = filepath,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };
            startInfo.EnvironmentVariables.Add("SHELL", string.Empty);

            _process.OutputDataReceived += DataReceived;
            _process.StartInfo = startInfo;

            if (_process.Start())
            {
                _process.BeginOutputReadLine();
                _process.WaitForExit();
            }
            else
            {
                WriteLog("�޷�����cmd��");
            }
            parameters = string.Empty;
            enginetype = string.Empty;
        }
        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            txtCmd.AppendText(e.Data + Environment.NewLine);
        }

        private void q_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĳЩ�������ں�׺���ظ������⣬���ֶ�ָ����������\n�������extension not supported���볢��ָ����������\n��ע�⣬���ָ���˴�������棬�ᵼ����ȡʧ�ܡ�");
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            txtCmd.Clear();
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void savepath_Click(object sender, EventArgs e)
        {
            Global pa = new()
            {
                path1 = this.t1.Text,
                path2 = this.t2.Text,
                path3 = this.t3.Text,
                jsonchk = this.jsonbut.Checked,
                xlsxchk = this.xlsxbut.Checked,
                engineindex = this.comboBox1.SelectedIndex
            };
            string jsonOutput = JsonSerializer.Serialize(pa);
            File.WriteAllText(configpath, jsonOutput);
            txtLog.AppendText("�������óɹ���");
            txtLog.AppendText(Environment.NewLine);
        }

        private void loadpath_Click(object sender, EventArgs e)
        {
            if (!File.Exists(configpath))
            {
                WriteLog("δ�ҵ������ļ���");
                return;
            }
            string jsonString = File.ReadAllText(configpath);
            Global? pa = JsonSerializer.Deserialize<Global>(jsonString);
            if (pa == null)
            {
                WriteLog("��ȡ����ʧ�ܣ�");
                return;
            }
            this.t1.Text = pa.path1;
            this.t2.Text = pa.path2;
            this.t3.Text = pa.path3;
            this.jsonbut.Checked = pa.jsonchk;
            this.xlsxbut.Checked = pa.xlsxchk;
            this.comboBox1.SelectedIndex = pa.engineindex;
            WriteLog("��ȡ���óɹ���");
        }

        private void about_Click(object sender, EventArgs e)
        {
            About f = new();
            f.ShowDialog();
        }

        private void WriteLog(string log)
        {
            this.txtLog.AppendText(log + Environment.NewLine);
        }
    }
}
