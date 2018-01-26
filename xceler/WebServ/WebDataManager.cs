using System;
using System.Threading.Tasks;

namespace xceler.WebServ
{
    public class WebDataManager
    {
        IRestService restService;

        public WebDataManager(IRestService sevice)
        {
            this.restService = sevice;
        }

        public Task<string> GetTasksLive(string ServiceName, string Parameter)
        {
            return restService.RefreshDataLiveAsync(ServiceName, Parameter);

        }
    }
}
