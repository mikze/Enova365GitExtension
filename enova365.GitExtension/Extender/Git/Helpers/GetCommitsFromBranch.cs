using enova365.GitExtension.Extender.Git.Models;
using System.Collections.Generic;
using System.Linq;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    class GetCommitsFromBranch
    {
        public List<CommitsPerDay> getCommitsListByContributorPerDay(Contributor contributor,string branch)
            {
            List<CommitsPerDay> commits = new List<CommitsPerDay>();
            foreach (var commitFromContributor in contributor.ListOfCommits)
            {
                if (commitFromContributor.branch == branch)
                    if (commits.Any(commit => 
                    commit.date.DayOfYear.Equals(commitFromContributor.date.DayOfYear)))
                    {
                        commits.Find(commit => 
                        commit.date.DayOfYear.Equals(commitFromContributor.date.DayOfYear)).count++;
                    }
                    else
                    {
                        commits.Add(new CommitsPerDay()
                        {
                            date = commitFromContributor.date,
                            count = 1
                        });
                    }
            }
            return commits;
        }
    }
}
