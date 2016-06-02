using System;

namespace TildaNET.Client
{
    internal interface IWebClient: IDisposable
    {
        string DownloadString(string address);
    }
}
