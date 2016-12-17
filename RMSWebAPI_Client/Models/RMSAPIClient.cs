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
    public class RMSAPIClient : HttpClient
    {
        private string BASE_URL = "http://localhost:65066/api";

        public RMSAPIClient()
        {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //if (!string.IsNullOrWhiteSpace((Utility.GetAppSettings("ACAAPI"))))
            //{
            //    this.BaseAddress = new Uri(Utility.GetAppSettings("ACAAPI"));
            //}
            //else
            //{
            //    this.BaseAddress = new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority));
            //}
            //this.DefaultRequestHeaders.Accept.Clear();

            //this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}