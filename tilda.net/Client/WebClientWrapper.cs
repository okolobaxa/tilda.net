using System.Net;

namespace tilda.net.Client
{
    internal class WebClientWrapper : IWebClient
    {
        public string DownloadString(string address)
        {
            using (WebClient web = new WebClient())
            {
                return web.DownloadString(address);
            }
        }
    }

}
