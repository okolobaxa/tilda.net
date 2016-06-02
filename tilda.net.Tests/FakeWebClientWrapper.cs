using System.IO;
using TildaNET.Client;

namespace TildaNET.Tests
{
    public class FakeWebClientWrapper : IWebClient
    {
        public void Dispose() {  }

        public string DownloadString(string address)
        {
            if (address.Contains("/getpageslist/"))
            {
                return File.ReadAllText("mocks/getpageslist.json");
            }
            if (address.Contains("/getpageexport/"))
            {
                return File.ReadAllText("mocks/getpageexport.json");
            }
            if (address.Contains("/getpage/"))
            {
                return File.ReadAllText("mocks/getpage.json");
            }
            if (address.Contains("/getprojectslist/"))
            {
                return File.ReadAllText("mocks/getprojectslist.json");
            }
            if (address.Contains("/getproject/"))
            {
                return File.ReadAllText("mocks/getproject.json");
            }
            if (address.Contains("/getpagefull/"))
            {
                return File.ReadAllText("mocks/getpagefull.json");
            }
            if (address.Contains("/getpagefullexport/"))
            {
                return File.ReadAllText("mocks/getpagefullexport.json");
            }
            if (address.Contains("/getprojectexport/"))
            {
                return File.ReadAllText("mocks/getprojectexport.json");
            }

            return null;
        }
    }

}
