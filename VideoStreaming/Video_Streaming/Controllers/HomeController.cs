using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Video_Streaming.Models;
using System.Linq;
using System.Collections.Generic;

namespace Video_Streaming.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<UserModel> users =
        [
            new UserModel { Username = "1", Password = "2" }
        ];


        public IActionResult Login()
        {
			return View();
        }


        [HttpPost]
        public IActionResult Login(UserModel userModel)
        {
            if (userModel == null)
            {
                Console.WriteLine("isNull");
                return View();
            }


            //var user = users.Where(u => u.Username == userModel.Username && u.Password == userModel.Password);

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"Iteration {i} if {i}" + users[0].Username + " | " + users[0].Password + " === " + userModel.Username + " | " + userModel.Password);
                if (users[i].Username == userModel.Username && users[i].Password == userModel.Password)
                {
                    return RedirectToAction("Main", "Home");
                }
            }

            ModelState.AddModelError("", "Inavlid Username or Password");
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel userModel)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == userModel.Username)
                {
                    Console.WriteLine($"User {users[i].Username}");
                    ViewData["Invalid"] = "Account Already Exists";
                    return View();
                }
            }

            Console.WriteLine("no dupes");
            users.Add(userModel);
            Console.WriteLine(users.Count);

            return View("Login");
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
