using AspTask_3.Data;
using AspTask_3.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask_3.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDBContext _productDBContext;

        public EFProductRepository(ProductDBContext productDBContext)
        {
            this._productDBContext = productDBContext;
        }

        public void AddProduct(Product product)
        {
            _productDBContext.Products.Add(product);
            _productDBContext.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _productDBContext.Remove(product);
            _productDBContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            var products = _productDBContext.Products.ToList();
            return products;
        }

        public void UpdateProduct(Product newProduc)
        {
            var oldPoduct = GetAllProducts().Where(s => s.Id == newProduc.Id).First();
            oldPoduct.Name = newProduc.Name;
            oldPoduct.Price = newProduc.Price;
            oldPoduct.Discount = newProduc.Discount;
            oldPoduct.Desciption = newProduc.Desciption;
            _productDBContext.SaveChanges();
        }
    }
}
