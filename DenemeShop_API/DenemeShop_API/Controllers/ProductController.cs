using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_API.Model;

namespace DenemeShop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;
        private readonly SepetRepository _sepetRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
            _sepetRepository = new SepetRepository();
        }

        [HttpGet("GetAll")]
        public IEnumerable<ProductWithStore> Get()
        {
            return _productRepository.GetAll();
        }

        [HttpGet("GetById")]
        public ProductWithStore GetById([FromBody] ProductWithStore prod)
        {
            int id = prod.Id;

            return _productRepository.GetById(id);
        }

        [HttpGet("KategoriGetAll")]
        public IEnumerable<Kategori> KategoriGetAll()
        {

            return _productRepository.KategoriGetAll();
        }

        [HttpGet("GetByKategori")]
        public IEnumerable<ProductWithKategori> GetByKategori([FromBody] ProductWithKategori prod)
        {
            int id = prod.KategoriID;

            return _productRepository.GetByKategori(id);
        }

        [HttpGet("Ara")]
        public IEnumerable<ProductWithStore> Ara(ProductWithStore prod)
        {
            string ara = prod.Name;
            return _productRepository.Search(ara);
        }

        [HttpPost]
        public void Post([FromBody] Product prod)
        {
            //prod.ProductId = id;

            if (ModelState.IsValid)
                _productRepository.Add(prod);
        }

        [HttpPut]
        public void Put(int Id,[FromBody] Product prod)
        {
            if (ModelState.IsValid)
                _productRepository.Update(Id,prod);
        }
        [HttpPut("ProductQuantity")]
        public void Put2([FromBody] Product prod)
        {
            if (ModelState.IsValid)
                _productRepository.ProductUpdate(prod);
        }

        [HttpPut("Buy")]
        public void PutBuy([FromBody] Product prod)
        {
            var id = prod.Id;
            var quantity = prod.Quantity;
            if (ModelState.IsValid)
                _productRepository.UpdateBuy(id, quantity);
        }

        [HttpDelete]
        public void Delete([FromBody] Product prod)
        {

            var id = prod.Id;
            _sepetRepository.Delete(id);
            _productRepository.Delete(id);
        }
    }
}
