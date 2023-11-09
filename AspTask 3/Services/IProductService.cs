using AspTask_3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspTask_3.Services
{
    public interface IProductService
    {
        List<Product> GetAllProductByKey(string key = "");
        void DeleteProduct(Product product);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
    }
}
