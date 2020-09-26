using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Interface
{
    public interface IProductRepository<T>
    {
        IEnumerable<T> GetAllProduct();

        //Product AddProduct();

        //Product DeleteProduct();


        //Product UpdateProduct();
        void AddProduct(T product);
        void DeleteProduct(T product);
        void UpdateProduct(T product);
        IEnumerable<T> GetAllProductCategoryName(string productName,string category);


    }
}
