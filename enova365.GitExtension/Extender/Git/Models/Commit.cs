using System;

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
