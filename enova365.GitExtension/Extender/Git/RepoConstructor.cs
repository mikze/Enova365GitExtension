using enova365.GitExtension.Extender.Git.Helpers;
using enova365.GitExtension.Extender.Git.Models;
using Newtonsoft.Json.Linq;

namespace enova365.GitExtension.Extender.Git
{
    class RepoConstructor
    {
        private static string url;
        private static Response responseFromServer = new Response();
        private static HTTPRequester Getter = new HTTPRequester();

        public static Repository ConstructRepository(string Name, string Owner)
        {
            Repository repo = new Repository()
            {
                name = Name,
                owner = Owner
            };

            DownloadNamesOfBranches(repo);
            DownloadCommitsAndContributors(repo);

            repo.listOfCommits.Sort((x, y) => y.date.CompareTo(x.date));

            return repo;
        }

        private static void DownloadNamesOfBranches(Repository repo)
        {
            url = UrlHelper.GetBranchesUrl(repo.owner, repo.name);
            Getter.GetString(url, responseFromServer);
            JArray Json = JArray.Parse(responseFromServer.recived);
            foreach (var It in Json)
                repo.Branches.Add(It["name"].ToObject<string>());
        }

        private static void DownloadCommitsAndContributors(Repository repo)
        {
            foreach (var branch in repo.Branches)
            {
                url = UrlHelper.GetCommitsFromBranchUrl(repo.owner, repo.name, branch);
                Getter.GetString(url, responseFromServer);
                JArray Json = JArray.Parse(responseFromServer.recived);

                foreach (var commit in Json)
                {
                    Commit newCommit = Deserializer.CommitDeserialize(commit);
                    newCommit.branch = branch;
                    repo.listOfCommits.Add(newCommit);
                    ContributorListFiller.Fill(repo.listOfContributors, newCommit);
                }
            }
        }
    }
}
