using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HotelApp1.Persistency
{
    class PersistencyService
    {
        const string serverUrl = "http://webservicehotel20170329012418.azurewebsites.net";
        static HttpClientHandler clientHandler = new HttpClientHandler();
        static HttpClient client = new HttpClient(clientHandler);

        public PersistencyService()
        {

        }

    }
}
