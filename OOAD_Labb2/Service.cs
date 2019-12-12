using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace OOAD_Labb2
{
    public interface INetwork
    {
        List<Astronauts> getPeopleInSpace();
    }

    public class NetworkService : INetwork
    {
        public List<Astronauts> getPeopleInSpace()
        {
            var url = "http://api.open-notify.org/astros.json";
            var client = new WebClient();
            var json = client.DownloadString(url);
            client.Dispose();
            return JsonConvert.DeserializeObject<ApiResponse>(json).people;
        }
    }
}