using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace xceler.WebServ
{
    public class RestService: IRestService
    {
        HttpClient client;
        public RestService()
        {

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<string> RefreshDataLiveAsync(string serviceName, string parameter)
        {

            string dummyServiceName = serviceName;
            string dummyParameter = parameter;
            string x = "";
            x = string.Concat(dummyServiceName, dummyParameter);

            string RestUrl = Constants.RestUrl + x;
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (serviceName.ToLower() == "countries")
                    {
                        //SyncGP(content);
                        return content;

                    }
                    return content;
                   
                }
                return "error";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"    ERROR {0}", ex.Message);
                return "error";
            }
        }
    }
}
