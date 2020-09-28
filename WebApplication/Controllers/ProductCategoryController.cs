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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
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
<<<<<<< HEAD
=======
=======
            IEnumerable<ProductCategory> productCategory = _productRepository.GetAllProductCategory();
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            return Ok(productCategory);
        }
        [HttpPost]
        [Route("GetAllProductCategoryName")]
        public IActionResult GetAllProductCategoryName(string categoryName)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
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
<<<<<<< HEAD
=======
=======
            IEnumerable<ProductCategory> productCategory = _productRepository.GetAllProductCategoryName(categoryName);
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            return Ok(productCategory);
        }
        [HttpPost]
        [Route("AddProductCategory")]
        public IActionResult AddProductCategory(ProductCategory prod)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            try
            {
                _productRepository.AddProductCategory(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
<<<<<<< HEAD
            return Ok("saved");
=======
           // return Ok("saved");
=======
            _productRepository.AddProductCategory(prod);
            return Ok("saved");
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
        }
        [HttpPost]
        [Route("UpdateProductCategory")]
        public IActionResult UpdateProductCategory(ProductCategory prod)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            try {
                _productRepository.UpdateProductCategory(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
<<<<<<< HEAD
=======
=======
            _productRepository.UpdateProductCategory(prod);
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            return Ok("updated");
        }
        [HttpPost]
        [Route("DeleteProductCategory")]
        public IActionResult DeleteProductCategory(ProductCategory prod)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            try
            {
                _productRepository.DeleteProductCategory(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
<<<<<<< HEAD
=======
            //return Ok("deleted");
=======
        _productRepository.DeleteProductCategory(prod);
            return Ok("deleted");
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
        }
    }
}
