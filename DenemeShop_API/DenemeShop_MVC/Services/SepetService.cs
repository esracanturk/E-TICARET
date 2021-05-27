using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using DenemeShop_MVC.Models;
using Newtonsoft.Json;

namespace DenemeShop_MVC.Services
{
    public class SepetService : ISepetService
    {
        public async Task<List<SepetModel>> SepetGetAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://192.168.1.102:28571/api/Sepet/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result = JsonConvert.DeserializeObject<List<SepetModel>>(responseBody);
            return result;
        }
        public async Task<List<SepetModel>> SepetGetAllUser(int? userId)
        {
            HttpClient client = new HttpClient();
            var result = new { userId = userId };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet/GetAllUser"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<List<SepetModel>>(responseBody);
            Console.WriteLine(response);
            return result2;
        }
        public async Task<SepetModel> SepetGetById(int id)
        {
            HttpClient client = new HttpClient();
            var result = new { Id = id };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet/GetById"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<SepetModel>(responseBody);
            Console.WriteLine(response);
            return result2;
        }
        public async Task<SepetModel> SepetGetByIdUser(int id, int? userId)
        {
            HttpClient client = new HttpClient();
            var result = new { Id = id, userId = userId };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet/GetByIdUser"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<SepetModel>(responseBody);

            Console.WriteLine(response);
            return result2;
        }
        public async Task SepetInsert(SepetModel data)
        {
            HttpClient client = new HttpClient();
            var result = new
            {
                Id = data.Id,
                SepetName = data.SepetName,
                SepetQuantity = data.SepetQuantity,
                SepetPrice = data.SepetPrice,
                SepetImgUrl = data.SepetImgUrl,
                SepetDescription = data.SepetDescription,
                userId = data.userId
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
        public async Task SepetUpdate(SepetModel data)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new
            {
                Id = data.Id,
                SepetName = data.SepetName,
                SepetQuantity = data.SepetQuantity,
                SepetPrice = data.SepetPrice,
                SepetImgUrl = data.SepetImgUrl,
                SepetDescription = data.SepetDescription,
                userId = data.userId
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            Console.WriteLine(response);
        }

        public async Task SepetDelete(int i)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Id = i };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
        public async Task SepetDeleteUser(int id, int? userId)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Id = id, userId = userId };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Sepet/User"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
    }
}
