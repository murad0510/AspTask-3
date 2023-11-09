using AspTask_3.Entities;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace AspTask_3.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
