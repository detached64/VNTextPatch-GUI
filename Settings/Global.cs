namespace VNTextPatchGUI.Settings
{
    public class Global
    {
        public string? Path1 { get; set; }
        public string? Path2 { get; set; }
        public string? Path3 { get; set; }
        public bool IsJsonChecked { get; set; }
        public bool IsXlsxChecked { get; set; }
        public int SelectedEngineIndex { get; set; }

        public readonly static string Version = "1.0.0";
    }
}
