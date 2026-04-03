using System;
using System.Web.Mvc;
using Mapster;
using MapsterSample.Models;

namespace MapsterSample.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var product = new Product
            {
                ProductId = 1,
                ProductName = "Laptop Dell XPS 13",
                ProductPrice = 999.99m,
                Description = "High-performance ultrabook",
                CreatedDate = DateTime.Now
            };
            
            // Mapping: ProductId => Id, ProductName => Name, ProductPrice => Price
            var productViewModel = product.Adapt<ProductViewModel>();

            return View(productViewModel);
        }

        public ActionResult Edit(int id)
        {
            var product = new Product
            {
                ProductId = id,
                ProductName = "Product " + id,
                ProductPrice = 100m,
                Description = "Sample product",
                CreatedDate = DateTime.Now
            };

            var viewModel = product.Adapt<ProductViewModel>();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(int id, ProductViewModel viewModel)
        {
            var product = viewModel.Adapt<Product>();
            product.ProductId = id;
            // _repository.Save(product);

            return RedirectToAction("Index");
        }
    }
}
