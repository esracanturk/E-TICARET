using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Models;

namespace DenemeShop_MVC.Interfaces
{
    public interface IAdminService
    {
        Task<List<GelenDataAPI>> AdminGetAll();
        Task<GelenDataAPI> AdminFindUser(string username, string password);
        Task RegisterUser(GelenDataAPI user);

        Task UpdateUser(/*int id, */GelenDataAPI data);

        Task<GelenDataAPI> GetByUser(int? userid);
        Task<GelenDataAPI> FindEmail(string email);
    }
}
