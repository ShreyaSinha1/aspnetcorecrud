using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Interface;
using WebApplication.Models;

namespace WebApplication.Implementation
{
    public class ProductRepository:IProductRepository<Product>
    {

        readonly CrudContext _productContext;

        public ProductRepository(CrudContext context)
        {
            _productContext = context;
        }

        public void AddProduct(Product prod)
        {
            _productContext.Products.Add(prod);
            _productContext.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            _productContext.Products.Remove(product);
            _productContext.SaveChanges();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _productContext.Products.ToList();
        }

        public IEnumerable<Product> GetAllProductCategoryName(string productName, string category)
        {
            return _productContext.Products.Where(x=>x.ProductName==productName && x.Category==category).ToList();
        }

        public void UpdateProduct(Product product)
        {
            _productContext.Products.Update(product);
            _productContext.SaveChanges();
        }
    }
}
