using enova365.GitExtension.Extender.Git.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    class GetCommitsFromBranch
    {
        private List<CommitsPerDay> commitsPerDayList;
        private List<AvgNumberCommitsOfContributor> avgCommits;

        public List<CommitsPerDay> getCommitsListByContributorPerDay(Contributor contributor, string branch)
        {
            commitsPerDayList = new List<CommitsPerDay>();
            foreach (var commitFromContributor in contributor.ListOfCommits)
            {
                if (commitFromContributor.branch == branch)
                    if (FindDayInCommitsPerDayList(commitFromContributor.dayOfUpload))
                    {
                        IncrementNumberOfCommitsInDay(commitFromContributor.dayOfUpload);
                    }
                    else
                    {
                        CreateNewCommitsPerDay(commitFromContributor.date);
                    }
            }
            return commitsPerDayList;
        }

        public List<AvgNumberCommitsOfContributor> GetAvgCommitsFromBranch(string branch, Repository repo) {
            avgCommits = new List<AvgNumberCommitsOfContributor>();
            List<Contributor> listOfContributors = repo.listOfContributors;

            foreach(var contributor in listOfContributors)
            {
                avgCommits.Add(new AvgNumberCommitsOfContributor()
                {
                    name = contributor.name,
                    Avg = AvgCommits(contributor, branch)
                });
            }

            return avgCommits;
        }

        private float AvgCommits(Contributor contributor, string branch)
        {
            var CommitsPerDayList = getCommitsListByContributorPerDay(contributor, branch);

            int numberOfDaysWhenCommitAppears = CommitsPerDayList.ToArray().Length;

            float numberOfAllCommits = 0;

            foreach(var co in CommitsPerDayList)
            {
                numberOfAllCommits += co.numberOfCommits;
            }

            float avg = numberOfAllCommits / numberOfDaysWhenCommitAppears;

            return avg;
        }

        private bool FindDayInCommitsPerDayList(int day)
        {
            return commitsPerDayList.Any(commit =>
                    commit.dayOfUpload.Equals(day));
        }

        private void IncrementNumberOfCommitsInDay(int day)
        {
            commitsPerDayList.Find(commitsPerDay =>
                       commitsPerDay.dayOfUpload.Equals(day))
                       .numberOfCommits++;
        }

        private void CreateNewCommitsPerDay(DateTime date)
        {
            commitsPerDayList.Add(new CommitsPerDay()
            {
                date = date,
                numberOfCommits = 1
            });
        }

    }
}
