using enova365.GitExtension.Extender.Git.Helpers;
using enova365.GitExtension.Extender.Git.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace enova365.GitExtension.Extender.Git
{
    public class FormProps
    {
        #region Property dla formularza

       private Repository repo;

       public FormProps()
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

        public IEnumerable<CommitsPerDay> ContributorCommitsPerDay
        {
            get
            {
                GetCommitsFromBranch getCommitsFromBranch = new GetCommitsFromBranch();
                Contributor contributor = repo.listOfContributors[0];
                string branch = "master";

                return getCommitsFromBranch.getCommitsListByContributorPerDay(contributor, branch);
            }
        }

        #endregion Property dla formularza
    }

}
