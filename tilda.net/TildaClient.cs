using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using tilda.net.Exceptions;
using tilda.net.Models;
using tilda.net.Properties;

namespace tilda.net
{
    public class TildaClient
    {
        private readonly string _publicKey;
        private readonly string _privateKey;
        

        public TildaClient(string publicKey, string privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;
        }

        /// <summary>
        /// Get lists of projects from Tilda
        /// </summary>
        /// <returns>A list of projects</returns>
        /// <exception cref = "TildaException" > Thrown when Tilda returns ERROR status code</exception>
        public IList<TildaProject> GetProjectsList()
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectslist/?publickey={_publicKey}&secretkey={_privateKey}";
            
            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<List<TildaProject>>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<TildaProject>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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
        }

        /// <summary>
        /// Get information about project for export
        /// </summary>
        /// <param name="projectId">Id of requesting project</param>
        /// <returns>Reqested project for export</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaProjectExport GetProjectExport(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getproject/?publickey={_publicKey}&secretkey={_privateKey}&projectid={projectId}";

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<TildaProjectExport>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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
        }

        /// <summary>
        /// Get lists of pages
        /// </summary>
        /// <param name="projectId">Id of project</param>
        /// <returns>A list of pages</returns>
        /// <exception cref = "TildaException" > Thrown when Tilda returns ERROR status code</exception>
        public IList<TildaPage> GetPagesList(long projectId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpageslist/?publickey={_publicKey}&secretkey={_privateKey}&projectid={projectId}";

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<IList<TildaPage>>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<TildaPage>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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
        }

        /// <summary>
        /// Get information about page + full html-code
        /// </summary>
        /// <param name="pageId">Id of requesting page</param>
        /// <returns>Reqested page</returns>
        /// <exception cref = "TildaException">Thrown when Tilda returns ERROR status code</exception>
        public TildaPage GetPageFull(long pageId)
        {
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getpagefull/?publickey={_publicKey}&secretkey={_privateKey}&pageid={pageId}";

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<TildaPage>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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

            using (var webClient = new WebClient())
            {
                try
                {
                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<TildaPageExport>>(body);

                    if (responce.Status == ETildaResultStatus.FOUND)
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
        }
    }
}
