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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            IEnumerable<Product> product;
            try
            {
                    product = _productRepository.GetAllProduct();
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");
            }
<<<<<<< HEAD

=======
=======
            IEnumerable<Product> product = _productRepository.GetAllProduct();
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            return Ok(product);
        }
        [HttpPost]
        [Route("GetByProductNameCategory")]
        public IActionResult GetByProductNameCategory()
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
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

<<<<<<< HEAD
          



=======
=======
            IEnumerable<Product> product = _productRepository.GetAllProduct();
            return Ok(product);
        }



>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProductCategory(Product prod)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            try
            {
                _productRepository.AddProduct(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
<<<<<<< HEAD
=======
=======
          _productRepository.AddProduct(prod);
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            return Ok("added");
        }
        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProductCategory(Product prod)
        {
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            try
            {
                _productRepository.UpdateProduct(prod);
                return StatusCode(200, "Saved");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Somthing went Wrong!");

            }
<<<<<<< HEAD
=======
=======
           _productRepository.UpdateProduct(prod);
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
            return Ok("Updated");
        }
        [HttpPost]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(Product prod)
        {
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
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
<<<<<<< HEAD
            _productRepository.DeleteProduct(prod);
            return Ok("deleted");
=======
=======
            _productRepository.DeleteProduct(prod);
            return Ok("deleted");
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
        }
    }
}
