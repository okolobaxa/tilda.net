using Newtonsoft.Json;
using System;
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
            var url = $"{Settings.Default.BaseUrl}/{Settings.Default.ApiVersion}/getprojectslist";
            
            using (var webClient = new WebClient())
            {
                try
                {

                    var body = webClient.DownloadString(url);

                    var responce = JsonConvert.DeserializeObject<TildaResult<List<TildaProject>>>(body);
                    
                    return responce.Result;
                }
                catch
                {
                    throw;
                }
            }

        }

        public TildaProject GetProject(long projectId)
        {
            throw new NotImplementedException();
        }

        public TildaProjectExport GetProjectExport()
        {
            throw new NotImplementedException();
        }

        public IList<TildaPage> GetPagesList(long projectId)
        {
            throw new NotImplementedException();
        }
        
        public TildaPage GetPage(long pageId)
        {
            throw new NotImplementedException();
        }

        public TildaPage GetPageFull(long pageId)
        {
            throw new NotImplementedException();
        }

        public TildaPageExport GetPageExport(long pageId)
        {
            throw new NotImplementedException();
        }

        public TildaPageExport GetPageFullExport(long pageId)
        {
            throw new NotImplementedException();
        }
    }
}
