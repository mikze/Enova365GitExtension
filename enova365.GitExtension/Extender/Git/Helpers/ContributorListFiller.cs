using System.Collections.Generic;
using System.Linq;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    class ContributorListFiller
    {
        public static void Fill(List<Contributor> listOfContributors, Commit newCommit)
        {
            if (listOfContributors.Any(x => x.name.Equals(newCommit.name)))
            {
                var Contributor = listOfContributors.Find(x => x.name.Equals(newCommit.name));
                Contributor.ListOfCommits.Add(newCommit);
            }
            else
            {
                listOfContributors.Add(new Contributor()
                {
                    name = newCommit.name,
                    ListOfCommits = new List<Commit>() { newCommit }
                });
            }
        }
    }
}
