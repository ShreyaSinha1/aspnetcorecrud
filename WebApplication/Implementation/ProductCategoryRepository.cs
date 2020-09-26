using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Contract;
using WebApplication.Entitites;

namespace WebApplication.Implementation
{
    public class ProductCategoryRepository : IProductCategoryRepository<ProductCategory>
    {

        readonly CrudContext _productContext;

        public ProductCategoryRepository(CrudContext context)
        {
            _productContext = context;
        }

        public void AddProductCategory(ProductCategory prod)
        {
           _productContext.ProductCategories.Add(prod);
            _productContext.SaveChanges();
        }

        public void DeleteProductCategory(ProductCategory prod)
        {
            _productContext.ProductCategories.Remove(prod);
            _productContext.SaveChanges();


        }

        public IEnumerable<ProductCategory> GetAllProductCategory()
        {
            return _productContext.ProductCategories.ToList();

        }

        public IEnumerable<ProductCategory> GetAllProductCategoryName(string categoryName)
        {
            // throw new NotImplementedException();
            return _productContext.ProductCategories.Where(x=>x.CategoryName== categoryName).ToList();

        }

        public void UpdateProductCategory(ProductCategory prod)
        {
            //  throw new NotImplementedException();
            _productContext.ProductCategories.Update(prod);
            _productContext.SaveChanges();
        }

     
    }
}
