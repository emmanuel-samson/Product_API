using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_API.Entities;

namespace Product_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = Product.Products;
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        { 
            Product.Products.Add(product);
            return Ok(product);
        }

        [HttpGet("{Id}")]
        public IActionResult GetProduct(int Id) 
        { 
            var product = Product.Products.SingleOrDefault(x => x.Id == Id);
            if (product == null) 
            {
                return NotFound($"Product With {Id} Cannot Be Found");
            }
            return Ok(product);
        }

    }
}
