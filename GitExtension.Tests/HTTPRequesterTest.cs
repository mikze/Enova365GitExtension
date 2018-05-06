using enova365.GitExtension.Extender.Git;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GitExtension.Tests
{
    public class HTTPRequesterTest
    {
        [Fact]
        public void checkRequestRespond()
        {
            HTTPRequester Getter = new HTTPRequester();
            string url = "http://api.github.com/repos/mikze/GospodarkaProjFront/branches";

            response recievedResponse = new response();

            Assert.Equal("loading", recievedResponse.resp);

            Getter.GetString(url, recievedResponse);

            string expectedResponse = "[{\"name\":\"demo\",\"commit\":{\"sha\":\"b1837bd8966c4a507b7b30d3422db7857432d29b\",\"url\":\"https://api.github.com/repos/mikze/GospodarkaProjFront/commits/b1837bd8966c4a507b7b30d3422db7857432d29b\"}},{\"name\":\"master\",\"commit\":{\"sha\":\"ce5eb9d01ceab1f9aa2c8cc5725a545c99afb51d\",\"url\":\"https://api.github.com/repos/mikze/GospodarkaProjFront/commits/ce5eb9d01ceab1f9aa2c8cc5725a545c99afb51d\"}}]";
 

            Assert.Equal(expectedResponse, recievedResponse.resp);

            
        }
    }
}
