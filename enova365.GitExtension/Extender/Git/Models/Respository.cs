using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enova365.GitExtension.Extender.Git.Models
{
    class Repository
    {
        public List<string> Branches { get; set; } = new List<string>();
        public List<Contributor> listOfContributors { get; set; } = new List<Contributor>();
        public List<Commit> listOfCommits { get; set; } = new List<Commit>();
        public string name { get; set; }
        public string owner { get; set; }
        public string url { get; set; }
    }
}
