using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace enova365.GitExtension.Extender.Git
{
    class GetInfo
    {
        static public JArray Get()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            string url = "http://api.github.com/repos/h2oai/steam/branches";

            var ResObject = new WebClient();

            ResObject.Headers.Add("User-Agent", "request");

            var response = ResObject.DownloadString(url);

            JArray Json = JArray.Parse(response);

            return Json;
        }
    }
}