using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_8_partone.Model;
using Session_8_partone.Services;

namespace Session_8_partone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _service.GetAllItems();
            return Ok(items);
        }
        public ActionResult GetProductById(int id) {
            var item = _service.GetProductById(id);
            return Ok(item);
        }
    }
}
