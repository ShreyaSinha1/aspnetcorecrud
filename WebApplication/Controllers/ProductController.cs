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
            IEnumerable<Product> product;
            try
            {
                    product = _productRepository.GetAllProduct();
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");
            }
            return Ok(product);
        }
        [HttpPost]
        [Route("GetByProductNameCategory")]
        public IActionResult GetByProductNameCategory()
        {
            IEnumerable<Product> product ;
            try
            {
                product = _productRepository.GetAllProduct();
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok(product);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProductCategory(Product prod)
        {
            try
            {
                _productRepository.AddProduct(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok("added");
        }
        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProductCategory(Product prod)
        {
            try
            {
                _productRepository.UpdateProduct(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok("Updated");
        }
        [HttpPost]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(Product prod)
        {
            try
            {
                _productRepository.DeleteProduct(prod);
                return StatusCode(200, "Deleted");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");
            }
           // return Ok("deleted");
        }
    }
}
