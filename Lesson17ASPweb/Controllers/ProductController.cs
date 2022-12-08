using Lesson17ASPweb.Models.Domain;
using Lesson17ASPweb.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson17ASPweb.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        IActionWithProductService action;
        public ProductController(IActionWithProductService action)
        {
            this.action = action;
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            action.AddProduct(product);
            return Created($"Name {product._name}", product);
        }

        [HttpPut]
        public IActionResult ReplaceProduct(int idProduct, Product product)
        {
            action.ReplaceProduct(idProduct, product);
            return Created($"Replace {product._name}", product);
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var list = action.GetAllProducts();
            return View(list);
        }

        [HttpGet]
        public IActionResult SummAllProduct()
        {
            return Ok(action.SummAllProducts());
        }
    }
}
