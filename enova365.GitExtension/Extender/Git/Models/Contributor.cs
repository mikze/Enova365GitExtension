using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enova365.GitExtension.Extender.Git
{
    public class Contributor
    {
        public string name { get; set; }
        public List<Commit> ListOfCommits { get; set; }
        public int NumberOfCommits => ListOfCommits.Count;
        public int AvgNumberOfCommitsPerDay { get; }

        //private SetAvgNum;
    }
}
