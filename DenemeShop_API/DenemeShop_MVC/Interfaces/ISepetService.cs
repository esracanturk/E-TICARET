using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Models;

namespace DenemeShop_MVC.Interfaces
{
    public interface ISepetService
    {
        Task<List<SepetModel>> SepetGetAll();
        Task<List<SepetModel>> SepetGetAllUser(int? userId);
        Task<SepetModel> SepetGetById(int id);
        Task<SepetModel> SepetGetByIdUser(int id, int? userId);
        Task SepetInsert(SepetModel data);
        Task SepetUpdate(SepetModel data);
        Task SepetDelete(int i);
        Task SepetDeleteUser(int id, int? userId);
    }
}
