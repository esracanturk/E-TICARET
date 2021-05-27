using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using DenemeShop_MVC.Models;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace DenemeShop_MVC.Services
{
    public class AdminService : IAdminService
    {
        public async Task<List<GelenDataAPI>> AdminGetAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44332/Users/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result = JsonConvert.DeserializeObject<List<GelenDataAPI>>(responseBody);
            return result;
        }
        public async Task<GelenDataAPI> AdminFindUser(string username, string password)
        {
            HttpClient client = new HttpClient();
            var result = new { username = username, password = password };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {

                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Users/FindUser"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<GelenDataAPI>(responseBody);
            return result2;
        }

        public async Task RegisterUser(GelenDataAPI user)
        {
            HttpClient client = new HttpClient();
            var result = new
            { /*userid = user.userid,*/
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm = user.emailconfirm
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44332/Users"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }

        public async Task<GelenDataAPI> GetByUser(int? userid)
        {
            HttpClient client = new HttpClient();
            var result = new { userid = userid };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Users/GetById"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<GelenDataAPI>(responseBody);

            return result2;
        }

        public async Task<GelenDataAPI> FindEmail(string email)
        {
            HttpClient client = new HttpClient();
            var result = new { email = email };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Users/FindEmail"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<GelenDataAPI>(responseBody);

            return result2;
        }

        public async Task UpdateUser(GelenDataAPI data)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new
            {
                userid=data.userid,
                username = data.username,
                password = data.password,
                role = data.role,
                email = data.email,
                emailconfirm = data.emailconfirm
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:44332/Users/UpdateUser"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            Console.WriteLine(response);
        }

    }
}
