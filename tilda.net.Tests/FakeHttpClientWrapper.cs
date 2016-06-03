using System;
using System.IO;
using System.Threading.Tasks;
using TildaNET.Client;

namespace TildaNET.Tests
{
    public class FakeHttpClientWrapper : IHttpClient
    {
        public void Dispose() {  }

        public Task<string> DownloadStringAsync(string address)
        {
            if (address.Contains("/getpageslist/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getpageslist.json"));
            }
            if (address.Contains("/getpageexport/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getpageexport.json"));
            }
            if (address.Contains("/getpage/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getpage.json"));
            }
            if (address.Contains("/getprojectslist/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getprojectslist.json"));
            }
            if (address.Contains("/getproject/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getproject.json"));
            }
            if (address.Contains("/getpagefull/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getpagefull.json"));
            }
            if (address.Contains("/getpagefullexport/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getpagefullexport.json"));
            }
            if (address.Contains("/getprojectexport/"))
            {
                return Task.FromResult(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "mocks/getprojectexport.json"));
            }

            return null;
        }
    }

}
