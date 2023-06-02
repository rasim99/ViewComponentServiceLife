using Microsoft.EntityFrameworkCore;
using ViewComponentServiceLifeTime.Models;

namespace ViewComponentServiceLifeTime.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<TopSeller> TopSellers { get; set; }
        public DbSet<TopSellerBanner> TopSellerBanners { get; set; }
        public DbSet<TopSellerCarousel> TopSellerCarousels { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BrandCarousel> BrandCarousels { get; set; }

    }
}
