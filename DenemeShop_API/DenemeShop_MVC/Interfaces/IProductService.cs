using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Models;

namespace DenemeShop_MVC.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductWithStore>> ProductGetAll();
        Task<ProductWithStore> ProductGetById(int id);
        Task<List<ProductWithStore>> ProductGetAllStore();
        Task<List<Kategori>> KategoriGetAll();
        Task<List<ProductWithKategori>> KategoriGetById(int id);
        Task ProductInsert(GelenData data);
        Task ProductUpdate(int Id,GelenData gelenData);
        Task ProductDelete(int i);
        Task<List<ProductWithStore>> ProductAra(string ara);
        Task ProductQuantity(GelenData gelenData);
        Task ProductBuy(int id, int quantity);
    }
}
