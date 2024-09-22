namespace VNTextPatchGUI.Settings
{
    [Serializable]
    public class Global
    {
        public string? path1 { get; set; }
        public string? path2 { get; set; }
        public string? path3 { get; set; }
        public bool jsonchk { get; set; }
        public bool xlsxchk { get; set; }
        public int engineindex { get; set; }

        public static string version = "1.0.0";
    }
}
