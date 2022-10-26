using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductBussiness.Services;
using ProductData;
using ProductData.Repository;
using ProductEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
      
        private ProductServices _productService;
        public ProductsController(ProductServices productService)
        {
           
            _productService = productService;
        }
        [HttpGet("GetProducts")]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpGet("GetProductById")]
        public Product GetProductById(int productId)
        {
            return _productService.GetProductByid(productId);
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);


            return Ok("Product created successfully!!");

        }

    }
}
