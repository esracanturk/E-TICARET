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
    public class ProductService : IProductService
    {
        public async Task<List<ProductWithStore>> ProductGetAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://192.168.1.102:28571/api/Product/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result = JsonConvert.DeserializeObject<List<ProductWithStore>>(responseBody);
            return result;
        }
        public async Task<ProductWithStore> ProductGetById(int id)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Id = id };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product/GetById"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<ProductWithStore>(responseBody);
            Console.WriteLine(response.Content + "coonnn");
            Console.WriteLine(response);
            return result2;
        }
        public async Task<List<ProductWithStore>> ProductGetAllStore()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://192.168.1.102:28571/api/Store/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result = JsonConvert.DeserializeObject<List<ProductWithStore>>(responseBody);
            Console.WriteLine(result + "xxxxxxxxxxxxx");
            return result;
        }
        public async Task<List<Kategori>> KategoriGetAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://192.168.1.102:28571/api/Product/KategoriGetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result2 = JsonConvert.DeserializeObject<List<Kategori>>(responseBody);
            Console.WriteLine(result2);
            return result2;
        }
        public async Task<List<ProductWithKategori>> KategoriGetById(int Id)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { KategoriID = Id };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product/GetByKategori"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<List<ProductWithKategori>>(responseBody);
            Console.WriteLine(result2);
            Console.WriteLine(response.Content + "coonnn");
            Console.WriteLine(response);
            return result2;
        }
        public async Task ProductInsert(GelenData data)
        {
            HttpClient client = new HttpClient();
            var result = new
            {
                Id = data.Id,
                Name = data.Name,
                Quantity = data.Quantity,
                Price = data.Price,
                ImageUrl = data.ImageUrl,
                Description = data.Description,
                groupId = data.groupId,
                KategoriID = data.KategoriID
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
        public async Task ProductUpdate(int Id,GelenData gelenData)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new
            {
                Id = Id,
                Name = gelenData.Name,
                Quantity = gelenData.Quantity,
                Price = gelenData.Price,
                ImageUrl = gelenData.ImageUrl,
                Description = gelenData.Description,
                groupId = gelenData.groupId,
                KategoriID = gelenData.KategoriID
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            Console.WriteLine(response);
        }
        public async Task ProductDelete(int i)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Id = i };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
        public async Task<List<ProductWithStore>> ProductAra(string ara)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Name = ara };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product/Ara"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<List<ProductWithStore>>(responseBody);
            return result2;
        }
        public async Task ProductQuantity(GelenData gelenData)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Id = gelenData.Id, Quantity = gelenData.Quantity };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product/ProductQuantity"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            Console.WriteLine(response);
        }
        public async Task ProductBuy(int id, int quantity)
        {
            HttpClient client = new HttpClient();
            //var result = new { /*ProductId = 8,*/ Name = "denemeeee2", Quantity = 77, Price=5888 };
            var result = new { Id = id, Quantity = quantity };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri("http://192.168.1.102:28571/api/Product/Buy"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            Console.WriteLine(response);
        }
    }
}
