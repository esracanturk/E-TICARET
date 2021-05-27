using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeShop_API.Model
{
    public class SepetModel
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string SepetName { get; set; }
        public int SepetQuantity { get; set; }
        public int SepetPrice { get; set; }
        public string SepetImgUrl { get; set; }
        public string SepetDescription { get; set; }
    }
}
