using System;
using System.Net;

namespace TildaNET.Client
{
    internal sealed class WebClientWrapper : IWebClient
    {
        private readonly WebClient _client = new WebClient();

        public string DownloadString(string address)
        {
            return _client.DownloadString(address);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _client?.Dispose();
            }
        }

    }

}
