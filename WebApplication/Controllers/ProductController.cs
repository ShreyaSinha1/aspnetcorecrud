using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Interface;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository<Product> _productRepository;

        public ProductController(IProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Libraries/GetAllAuthor  
        [HttpGet]
        [Route("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            IEnumerable<Product> product = _productRepository.GetAllProduct();
            return Ok(product);
        }
        [HttpPost]
        [Route("GetByProductNameCategory")]
        public IActionResult GetByProductNameCategory()
        {
            IEnumerable<Product> product = _productRepository.GetAllProduct();
            return Ok(product);
        }



        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProductCategory(Product prod)
        {
          _productRepository.AddProduct(prod);
            return Ok("added");
        }
        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProductCategory(Product prod)
        {
           _productRepository.UpdateProduct(prod);
            return Ok("Updated");
        }
        [HttpPost]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(Product prod)
        {
            _productRepository.DeleteProduct(prod);
            return Ok("deleted");
        }
    }
}
