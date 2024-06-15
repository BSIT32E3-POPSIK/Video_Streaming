using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Video_Streaming.AppData;
using Video_Streaming.Models;

namespace Video_Streaming.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string[,] accounts =
        {
            {"1","1" },
            { "admin", "admin"}
        };

        public IActionResult Login(string username, string password)
        {
            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                if (accounts[i, 0] == username && accounts[i, 1] == password)
                {
                    return RedirectToAction(nameof(Main));
                }
            }

            return RedirectToAction(nameof(Login));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Login([Bind("Id,Username,Password,VideosWatched")] User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var u = _context.Users.ToList();

        //        foreach (User item in u)
        //        {
        //            if (item.Username == user.Username && item.Password == user.Password)
        //            {
        //                return RedirectToAction(nameof(Index));
        //            }
        //        }
        //    }
        //    return View(user);
        //}

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult ADMIN()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
