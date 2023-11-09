using AspTask_3.Entities;
using AspTask_3.Models;
using AspTask_3.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;

namespace AspTask_3.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProductByKey();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = products;
            return View(viewModel);
        }

        public Product getProductById(int id)
        {
            var products = _productService.GetAllProductByKey();
            for (int i = 0; i < products.Count; ++i)
            {
                if (products[i].Id == id)
                {
                    return products[i];
                }
            }
            return null;
        }

        public IActionResult Delete(int productId)
        {
            var data = getProductById(productId);
            if (data != null)
            {
                _productService.DeleteProduct(data);
            }
            return RedirectToAction("Index");
            //return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Update(int productId)
        {
            var product = getProductById(productId);
            UpdateProductViewModel viewModel = new UpdateProductViewModel();
            viewModel.Product = product;
            return View("UpdateProduct", viewModel);
        }

        //[HttpPut]
        public async Task<IActionResult> Update(UpdateProductViewModel productViewModel)
        {
            var product= productViewModel.Product;
            _productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            UpdateProductViewModel viewModel = new UpdateProductViewModel()
            {
                Product = new Product()
            };
            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(UpdateProductViewModel productViewModel)
        {
            var product = productViewModel.Product;
            _productService.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
