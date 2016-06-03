using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TildaNET.Client
{
    internal sealed class HttpClientWrapper : IHttpClient
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<string> DownloadStringAsync(string address)
        {
            return await _client.GetStringAsync(address);
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
