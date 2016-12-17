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
    public class ProductClient
    {
        private string BASE_URL = "http://localhost:65066/api/";

        public IEnumerable<Product> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("products").Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
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

        public Product FindProduct(long id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("products/" + id ).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<Product>().Result;
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

        public bool Create(Product product)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("products", product).Result;
                return response.IsSuccessStatusCode;
                
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Product product)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("products/" + product.Oid, product).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("products/" + id).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }
    }
}