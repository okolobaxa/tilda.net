using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using tilda.net.Models;
using tilda.net.Properties;

namespace tilda.net
{
    class TildaClient
    {
        private readonly string _publicKey;
        private readonly string _privateKey;
        

        public TildaClient(string publicKey, string privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;
        }

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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        
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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

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
                        return null;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

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
                        return null;
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
