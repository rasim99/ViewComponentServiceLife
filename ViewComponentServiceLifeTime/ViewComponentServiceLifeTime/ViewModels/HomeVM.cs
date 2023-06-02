using ViewComponentServiceLifeTime.Models;

namespace ViewComponentServiceLifeTime.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Policy> Policies { get; set; }
        public List<Product> Products { get; set; }
        public List<Banner> Banners { get; set; }
        public TopSeller TopSeller { get; set; }
        public TopSellerBanner TopSellerBanner { get; set; }
        public List<TopSellerCarousel> TopSellerCarousels { get; set; }


    }
}
