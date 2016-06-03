using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        private readonly IHttpClient _httpClient;


        public TildaClient(string publicKey, string secretKey)
        {
            _publicKey = publicKey;
            _secretKey = secretKey;

            _httpClient = new HttpClientWrapper();
        }

        internal TildaClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Get lists of projects from Tilda
        /// </summary>
        /// <returns>A collection of projects</returns>
        /// <exception cref = "TildaException" > Thrown when Tilda returns ERROR status code</exception>
        public async Task<IReadOnlyCollection<TildaProject>> GetProjectsList()
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectslist/?publickey={_publicKey}&secretkey={_secretKey}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<IReadOnlyCollection<TildaProject>>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<TildaProject> GetProject(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getproject/?publickey={_publicKey}&secretkey={_secretKey}&projectid={projectId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaProject>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<TildaProjectExport> GetProjectExport(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectexport/?publickey={_publicKey}&secretkey={_secretKey}&projectid={projectId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaProjectExport>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<IReadOnlyCollection<TildaPage>> GetPagesList(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageslist/?publickey={_publicKey}&secretkey={_secretKey}&projectid={projectId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<IReadOnlyCollection<TildaPage>>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<TildaPage> GetPage(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpage/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPage>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<TildaPageExport> GetPageFull(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefull/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<TildaPageExport> GetPageExport(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageexport/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

            if (responce.Status == TildaResultStatus.Found)
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
        public async Task<TildaPageExport> GetPageFullExport(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefullexport/?publickey={_publicKey}&secretkey={_secretKey}&pageid={pageId}";

            var body = await GetStringAsync(url);

            var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

            if (responce.Status == TildaResultStatus.Found)
            {
                return responce.Result;
            }
            throw new TildaException("Tilda error");
        }

        private async Task<string> GetStringAsync(string uri)
        {
            return await _httpClient.DownloadStringAsync(uri);
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
                _httpClient?.Dispose();
            }
        }
    }
}
