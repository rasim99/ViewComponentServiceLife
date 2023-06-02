using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ViewComponentServiceLifeTime.DAL;

namespace ViewComponentServiceLifeTime.ViewComponents
{
    public class FooterViewComponent :ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public FooterViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var bio = _appDbContext.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
