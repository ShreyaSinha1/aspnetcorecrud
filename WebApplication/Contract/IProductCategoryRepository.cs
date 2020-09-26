using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entitites;

namespace WebApplication.Contract
{
    public interface IProductCategoryRepository<T>
    {
        IEnumerable<T> GetAllProductCategory();

        //ProductCategory AddProductCategory();

        //ProductCategory DeleteProductCategory();


        //ProductCategory UpdateProductCategory();
       void AddProductCategory(T Productcategory);
       void DeleteProductCategory(T Productcategory);
       void UpdateProductCategory(T Productcategory);

        IEnumerable<T> GetAllProductCategoryName(string categoryName);
    }
}
