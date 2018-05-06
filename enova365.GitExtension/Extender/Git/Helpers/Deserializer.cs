using Newtonsoft.Json.Linq;
using System;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    public class Deserializer
    {
        public static Commit CommitDeserialize(JToken commit)
        {
            return new Commit()
            {
                sha = commit["sha"].ToObject<string>(),
                name = commit["commit"]["author"]["name"].ToObject<string>(),
                message = commit["commit"]["message"].ToObject<string>(),
                date = commit["commit"]["committer"]["date"].ToObject<DateTime>()
            };
        }
    }
}
