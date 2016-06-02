using System;
using System.Net;

namespace TildaNET.Client
{
    internal class WebClientWrapper : IWebClient
    {
        private readonly WebClient client = new WebClient();

        public string DownloadString(string address)
        {
            return client.DownloadString(address);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (client != null)
                    client.Dispose();
            }
        }

    }

}
