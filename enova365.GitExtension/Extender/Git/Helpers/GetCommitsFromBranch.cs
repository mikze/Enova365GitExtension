using enova365.GitExtension.Extender.Git.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    class GetCommitsFromBranch
    {
        private List<CommitsPerDay> commitsPerDayList = new List<CommitsPerDay>();

        public List<CommitsPerDay> getCommitsListByContributorPerDay(Contributor contributor,string branch)
            {
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
