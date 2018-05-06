using enova365.GitExtension.Extender.Git.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace enova365.GitExtension.Extender.Git
{

    public class Commits
    {
        #region Property dla formularza

        //private response Res = new response();
        //private GetInfo Requester = new GetInfo();
        private Repository repo;

       public Commits()
        {
            try
            {
                Trace.WriteLine("Connectiong to repo ...");
                repo = RepoConstructor.ConstructRepository("GospodarkaProjFront", "mikze");
            }
            catch(Exception e)
            {
                Trace.WriteLine("Could not connect because: " + e );
                Trace.WriteLine("Check your internet connection!");
            }
        }

        public IEnumerable<Commit> AllCommits
        {
            get
            {
                return repo.listOfCommits;
            }
        }

        public IEnumerable<Contributor> AllContributors
        {
            get
            {
                return repo.listOfContributors;
            }
        }

        #endregion Property dla formularza
    }

}
