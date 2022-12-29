using CCTv.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCTv.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList(),
                Pricings = _context.Pricings.ToList(),
                Teams = _context.Teams.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Blogs = _context.Blogs.ToList()
            };
            return View(homeVM);
        }

       
    }
}