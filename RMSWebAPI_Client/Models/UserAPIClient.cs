using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
namespace RMSWebAPI_Client.Models
{
    public class UserAPIClient
    {
        private string BASE_URL = "http://localhost:65066/api";

        public IEnumerable<User> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("user").Result;
                if(response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}