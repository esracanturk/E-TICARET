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
    public class SepetController : ControllerBase
    {
        private readonly SepetRepository _sepetRepository;

        public SepetController()
        {
            _sepetRepository = new SepetRepository();
        }

        [HttpGet("GetAll")]
        public IEnumerable<SepetModel> Get()
        {
            return _sepetRepository.GetAll();
        }

        [HttpGet("GetAllUser")]
        public IEnumerable<SepetModel> GetAllUser([FromBody] SepetModel prod)
        {
            int userId = prod.userId;
            return _sepetRepository.GetAllUser(userId);
        }

        [HttpGet("GetById")]
        public SepetModel GetById([FromBody] SepetModel prod)
        {
            int id = prod.Id;

            return _sepetRepository.GetById(id);
        }

        [HttpGet("GetByIdUser")]
        public SepetModel GetByIdUser([FromBody] SepetModel prod)
        {
            int id = prod.Id;
            int userId = prod.userId;

            return _sepetRepository.GetByIdUser(id, userId);
        }

        [HttpPost]
        public void Post([FromBody] SepetModel prod)
        {
            //prod.ProductId = id;
            if (ModelState.IsValid)
            {
                _sepetRepository.Add(prod);
            }
        }

        [HttpPut]
        public void Put([FromBody] SepetModel prod)
        {
            if (ModelState.IsValid)
                _sepetRepository.Update(prod);
        }

        [HttpDelete]
        public void Delete([FromBody] SepetModel prod)
        {
            var id = prod.Id;
            _sepetRepository.Delete(id);
        }

        [HttpDelete("User")]
        public void DeleteUser([FromBody] SepetModel prod)
        {
            var id = prod.Id;
            var userId = prod.userId;
            _sepetRepository.DeleteUser(id, userId);
        }
    }
}
