using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewComponentServiceLifeTime.DAL;
using ViewComponentServiceLifeTime.Models;
using ViewComponentServiceLifeTime.ViewModels;

namespace ViewComponentServiceLifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new();
            homeVM.Sliders = _appDbContext.Sliders.ToList();
            homeVM.Policies = _appDbContext.Policies.ToList();
            homeVM.Products = _appDbContext.Products.ToList();
            homeVM.Banners = _appDbContext.Banners.ToList();
            homeVM.TopSeller = _appDbContext.TopSellers.FirstOrDefault();
            homeVM.TopSellerBanner = _appDbContext.TopSellerBanners.FirstOrDefault();
            homeVM.TopSellerCarousels = _appDbContext.TopSellerCarousels.ToList();
            homeVM.Blogs = _appDbContext.Blogs.ToList();
            homeVM.BrandCarousels = _appDbContext.BrandCarousels.ToList();

            return View(homeVM);
        }

    }
}