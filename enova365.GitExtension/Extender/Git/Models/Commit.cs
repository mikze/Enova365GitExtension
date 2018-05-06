using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enova365.GitExtension.Extender.Git
{
    public class Commit
    {
        public string sha { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public string branch { get; set; }
        public DateTime date { get; set; }
    }
}
