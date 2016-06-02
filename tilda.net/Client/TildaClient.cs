using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using TildaNET.Client;
using TildaNET.Exceptions;
using TildaNET.Models;
using TildaNET.Properties;

namespace TildaNET
{
    public class TildaClient : IDisposable
    {
        private readonly string _publicKey;
        private readonly string _privateKey;
        private readonly IWebClient _webClient;


        public TildaClient(string publicKey, string privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;

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
        public IReadOnlyCollection<TildaProject> GetProjectsList()
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectslist/?publickey={_publicKey}&secretkey={_privateKey}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<IReadOnlyCollection<TildaProject>>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get information about project
        /// </summary>
        /// <param name="projectId">Id of requesting project</param>
        /// <returns>Reqested project</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaProject GetProject(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getproject/?publickey={_publicKey}&secretkey={_privateKey}&projectid={projectId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<TildaProject>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get information about project for export
        /// </summary>
        /// <param name="projectId">Id of requesting project</param>
        /// <returns>Reqested project for export</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaProjectExport GetProjectExport(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectexport/?publickey={_publicKey}&secretkey={_privateKey}&projectid={projectId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<TildaProjectExport>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get lists of pages
        /// </summary>
        /// <param name="projectId">Id of project</param>
        /// <returns>A collection of pages</returns>
        /// <exception cref = "TildaException" > Thrown when Tilda returns ERROR status code</exception>
        public IReadOnlyCollection<TildaPage> GetPagesList(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageslist/?publickey={_publicKey}&secretkey={_privateKey}&projectid={projectId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<IReadOnlyCollection<TildaPage>>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get information about page + body html-code
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaPage GetPage(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpage/?publickey={_publicKey}&secretkey={_privateKey}&pageid={pageId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<TildaPage>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get information about page + full html-code
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaPageExport GetPageFull(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefull/?publickey={_publicKey}&secretkey={_privateKey}&pageid={pageId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get information about page + body html-code for export
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaPageExport GetPageExport(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageexport/?publickey={_publicKey}&secretkey={_privateKey}&pageid={pageId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get information about page + full html-code for export
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaPageExport GetPageFullExport(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefullexport/?publickey={_publicKey}&secretkey={_privateKey}&pageid={pageId}";

            try
            {
                var body = GetString(url);

                var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

                if (responce.Status == TildaResultStatus.FOUND)
                {
                    return responce.Result;
                }
                else
                {
                    throw new TildaException("Tilda error");
                }
            }
            catch
            {
                throw;
            }
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

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if (_webClient != null)
                    _webClient.Dispose();
            }
        }
    }
}
