using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using TildaNET.Enums;
using TildaNET.Exceptions;
using TildaNET.Models;
using TildaNET.Properties;

namespace TildaNET.Client
{
    public sealed class TildaClient : IDisposable
    {
        private readonly string _publicKey;
        private readonly string _secretKey;
        private readonly IWebClient _webClient;


        public TildaClient(string publicKey, string secretKey)
        {
            _publicKey = publicKey;
            _secretKey = secretKey;

            _webClient = new WebClientWrapper();
        }

        internal TildaClient(IWebClient webClient)
        {
            _webClient = webClient;
        }

        /// <summary>
        /// Get lists of projects from Tilda
        /// </summary>
        /// <returns>A collection of projects</returns>
        /// <exception cref = "TildaException" > Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public IReadOnlyCollection<TildaProject> GetProjectsList()
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectslist/?publickey={_publicKey}&secretkey={_secretKey}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<IReadOnlyCollection<TildaProject>>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get information about project
        /// </summary>
        /// <param name="projectId">Id of requesting project</param>
        /// <returns>Reqested project</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public TildaProject GetProject(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getproject/?publickey={_publicKey}&secretkey={_secretKey}&projectid={projectId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaProject>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get information about project for export
        /// </summary>
        /// <param name="projectId">Id of requesting project</param>
        /// <returns>Reqested project for export</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public TildaProjectExport GetProjectExport(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectexport/?publickey={_publicKey}&secretkey={_secretKey}&projectid={projectId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaProjectExport>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get lists of pages
        /// </summary>
        /// <param name="projectId">Id of project</param>
        /// <returns>A collection of pages</returns>
        /// <exception cref = "TildaException" > Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public IReadOnlyCollection<TildaPage> GetPagesList(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageslist/?publickey={_publicKey}&secretkey={_secretKey}&projectid={projectId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<IReadOnlyCollection<TildaPage>>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get information about page + body html-code
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public TildaPage GetPage(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpage/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPage>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get information about page + full html-code
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public TildaPageExport GetPageFull(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefull/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get information about page + body html-code for export
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public TildaPageExport GetPageExport(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageexport/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        /// <summary>
        /// Get information about page + full html-code for export
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        /// <exception cref = "WebException" ></exception>
        public TildaPageExport GetPageFullExport(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefullexport/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = GetString(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

            if (responce.Status == TildaResultStatus.FOUND)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        private string GetString(string uri)
        {
            return _webClient.DownloadString(uri);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Close()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(disposing)
            {
                _webClient?.Dispose();
            }
        }
    }
}
