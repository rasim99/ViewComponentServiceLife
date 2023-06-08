using Microsoft.AspNetCore.Mvc;
using ViewComponentServiceLifeTime.DAL;
using ViewComponentServiceLifeTime.Models;
using ViewComponentServiceLifeTime.ViewModels;

namespace ViewComponentServiceLifeTime.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ShopVM shopVM=new ShopVM();
            shopVM.Categories=_context.Categories.ToList();
          shopVM.ShopItems=_context.ShopItems.ToList();
            return View(shopVM);
        }
        public IActionResult Search(string search)
        {
            var items=_context.ShopItems
                  .Where(p => p.Name.ToLower().Contains(search.ToLower()))
                .ToList();
            return PartialView("_SearchPartial",items);
        }
    }
}
