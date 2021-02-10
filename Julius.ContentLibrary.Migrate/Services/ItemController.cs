using DotNetNuke.Security;
using DotNetNuke.Web.Api;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace Julius.Modules.Julius.ContentLibrary.Migrate.Services
{
    //[SupportedModules("ContentLibrary")]
    //[DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]

    [AllowAnonymous]
    public class ItemController : DnnApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(string apiKey)
        {
            var data = GetContentType(apiKey, "https://dnnapi.com/content/api/ContentItems?query.maxItems=1000");
            return Request.CreateResponse(HttpStatusCode.OK, new { ContentType = data });
        }

        private dynamic GetContentType(string apiKey, string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", apiKey));

                var exist = client.GetAsync(url).Result;
                dynamic data = null;
                if (exist.IsSuccessStatusCode)
                {                   
                    data = JsonConvert.DeserializeObject<dynamic>(exist.Content.ReadAsStringAsync().Result);
                }
                return data;
            }
        }
    }
}
