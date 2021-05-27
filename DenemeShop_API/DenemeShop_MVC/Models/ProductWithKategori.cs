using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeShop_MVC.Models
{
    public class ProductWithKategori
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int groupId { get; set; }
        public int KategoriID { get; set; }
        public string KategoriName { get; set; }

    }
}
