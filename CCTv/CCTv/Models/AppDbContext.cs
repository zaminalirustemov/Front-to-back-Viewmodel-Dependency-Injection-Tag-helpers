using Microsoft.EntityFrameworkCore;

namespace CCTv.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
