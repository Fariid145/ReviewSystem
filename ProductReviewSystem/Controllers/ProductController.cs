using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductReviewSystem.Models.ViewModels;
using ProductReviewSystem.Repositories;
using ProductReviewSystem.Services;
using System.Collections.Generic;

namespace ProductReviewSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;
         private readonly IReviewService _reviewService;

        public ProductController(IProductService productService, IUserService userService)
        {
            _productService = productService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //List<ProductIndexVM> productIndexVM = new List<ProductIndexVM>();

            //var products = _productService.GetProducts();

            //foreach(var product in products)
            //{
            //    ProductIndexVM productIndex = new ProductIndexVM
            //    {
            //        Id = product.Id,
            //        Name = product.Name,
            //        Description = product.Description,
            //        UserName = _userService.FindById(product.UserId).Name
            //    };

            //    productIndexVM.Add(productIndex);
            //}
            //return View(productIndexVM);

            var products = _productService.GetProducts();
            return View(products);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            ViewBag.users = _userService.GetUserList();
            var model = new CreateProductViewModel();
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(CreateProductViewModel model)
        {
            _productService.AddProduct(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Detail(int id)
        {
            var product = _productService.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }


        [Authorize]
        public IActionResult Update(int id)
        {
            var product = _productService.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return View(product);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Update(UpdateProductViewModel model)
        {
            _productService.UpdateProduct(model);
            return RedirectToAction("Index");
        }

         [Authorize]
        public IActionResult Delete(int id)
        {
            var product = _productService.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
         public IActionResult Detail(ProductViewModel model)
        {

            var review = _reviewService.GetReviewPerProduct(model.Id);
            if(review == null)
            {
                return NotFound();
            }
            return View(review);
        }
    }
}
