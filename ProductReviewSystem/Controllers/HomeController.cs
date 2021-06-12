using System.Reflection.Emit;
using System.Reflection;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductReviewSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProductReviewSystem.Services;
using ProductReviewSystem.Models.ViewModels;

namespace ProductReviewSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IReviewService _reviewService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IReviewService reviewService)
        {
            _productService = productService;
            _logger = logger;
            _reviewService = reviewService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
        [HttpGet]
        public IActionResult Detail(ProductViewModel model)
        {

            var review = _reviewService.GetReviewPerProduct(model.Id);
            if(review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //   public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
