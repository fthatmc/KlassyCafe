using KlassyCafe.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.DAL.Context
{
    public class KlassyContext : DbContext
    {
        public KlassyContext(DbContextOptions<KlassyContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<AboutUsImage> AboutUsImages { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
