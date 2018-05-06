using System.Net;
using System.Threading.Tasks;

namespace enova365.GitExtension.Extender.Git.Helpers
{
    public class Response
    {
        public string recived { get; set; } = "loading";
    }

    class HTTPRequester
    {
        private WebClient ResObject = new WebClient();

        public HTTPRequester()
        {
            //USTAWIENIA PROTOKOŁU
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        }

        private Task<string> TryToRequest(WebClient ResObject, string url) =>
            Task.Run(() => ResObject.DownloadString(url));

        public async void GetStringAsync(string url, Response re)
        {
            ResObject.Headers.Add("User-Agent", "request");
            re.recived = await TryToRequest(ResObject, url);
        }

        public void GetString(string url, Response re)
        {
            ResObject.Headers.Add("User-Agent", "request");
            re.recived = ResObject.DownloadString(url);
        }
    }
}
