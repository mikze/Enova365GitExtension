using System;

namespace enova365.GitExtension.Extender.Git.Models
{
    public class CommitsPerDay
    {
        public DateTime date { get; set; }
        public int dayOfUpload => date.DayOfYear;
        public int numberOfCommits { get; set; }
    }
   
}
