using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vntextpatch_GUI
{
    [Serializable]
    internal class Path_
    {
        public string path1 {  get; set; }
        public string path2 { get; set; }
        public string path3 { get; set; }
        public bool jsonchk { get; set; }
        public bool xlsxchk { get; set; }
        public int engineindex {  get; set; }

    }
}
