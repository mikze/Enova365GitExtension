using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    public class UrlHelper
    {
        public static string GetCommitsFromBranchUrl(string Owner, string Name, string Branch) =>
            "https://api.github.com/repos/" + Owner + "/" + Name + "/commits?sha=" + Branch;

        public static string GetBranchesUrl(string Owner, string Name) =>
            "https://api.github.com/repos/" + Owner + "/" + Name + "/branches";
    }
}
