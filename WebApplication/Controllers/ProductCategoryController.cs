using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Contract;
using WebApplication.Entitites;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {

        private readonly IProductCategoryRepository<ProductCategory> _productRepository;

        public ProductCategoryController(IProductCategoryRepository<ProductCategory> productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Libraries/GetAllAuthor  
        [HttpGet]
        [Route("GetAllProductCategory")]
        public IActionResult GetAllProductCategory()
        {
            IEnumerable<ProductCategory> productCategory;
            try
            {
                productCategory = _productRepository.GetAllProductCategory();
               // return StatusCode(200, "Saved");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok(productCategory);
        }
        [HttpPost]
        [Route("GetAllProductCategoryName")]
        public IActionResult GetAllProductCategoryName(string categoryName)
        {
            IEnumerable<ProductCategory> productCategory;
            try
            {
                productCategory = _productRepository.GetAllProductCategoryName(categoryName);
               // return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok(productCategory);
        }
        [HttpPost]
        [Route("AddProductCategory")]
        public IActionResult AddProductCategory(ProductCategory prod)
        {
            try
            {
                _productRepository.AddProductCategory(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok("saved");
        }
        [HttpPost]
        [Route("UpdateProductCategory")]
        public IActionResult UpdateProductCategory(ProductCategory prod)
        {
            try {
                _productRepository.UpdateProductCategory(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
            return Ok("updated");
        }
        [HttpPost]
        [Route("DeleteProductCategory")]
        public IActionResult DeleteProductCategory(ProductCategory prod)
        {
            try
            {
                _productRepository.DeleteProductCategory(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
        }
    }
}
