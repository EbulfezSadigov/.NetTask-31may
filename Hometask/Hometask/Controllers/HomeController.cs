using Hometask.DAL;
using Hometask.Models;
using Hometask.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hometask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                sliders = db.Sliders.ToList(),
                projects = db.Projects.ToList(),
                features = db.Features.ToList(),
                news = db.News.ToList(),
                ts = db.Test.ToList()
            };
            return View(viewModel);
            
        }
    }
}
