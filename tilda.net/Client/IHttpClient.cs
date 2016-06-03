using System;
using System.Threading.Tasks;

namespace TildaNET.Client
{
    internal interface IHttpClient: IDisposable
    {
        Task<string> DownloadStringAsync(string address);
    }
}
