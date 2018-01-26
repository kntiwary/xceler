using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace xceler.WebServ
{
    public interface IRestService
    {
        Task<string> RefreshDataLiveAsync(string serviceName, string parameter);
    }
}
