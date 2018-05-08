using System.Collections.Generic;

namespace enova365.GitExtension.Extender.Git
{
    public class Contributor
    {
        public string name { get; set; }
        public List<Commit> ListOfCommits { get; set; }
        public int NumberOfCommits => ListOfCommits.Count;
        public int AvgNumberOfCommitsPerDay { get
            {
                return NumberOfCommits;
            }
        }

        //private SetAvgNum;
    }
}
