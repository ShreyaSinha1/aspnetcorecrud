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
            IEnumerable<ProductCategory> productCategory = _productRepository.GetAllProductCategory();
            return Ok(productCategory);
        }
        [HttpPost]
        [Route("GetAllProductCategoryName")]
        public IActionResult GetAllProductCategoryName(string categoryName)
        {
            IEnumerable<ProductCategory> productCategory = _productRepository.GetAllProductCategoryName(categoryName);
            return Ok(productCategory);
        }
        [HttpPost]
        [Route("AddProductCategory")]
        public IActionResult AddProductCategory(ProductCategory prod)
        {
            _productRepository.AddProductCategory(prod);
            return Ok("saved");
        }
        [HttpPost]
        [Route("UpdateProductCategory")]
        public IActionResult UpdateProductCategory(ProductCategory prod)
        {
            _productRepository.UpdateProductCategory(prod);
            return Ok("updated");
        }
        [HttpPost]
        [Route("DeleteProductCategory")]
        public IActionResult DeleteProductCategory(ProductCategory prod)
        {
        _productRepository.DeleteProductCategory(prod);
            return Ok("deleted");
        }
    }
}
