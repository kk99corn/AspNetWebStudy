using AspNetCoreWebStudy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreWebStudy.Controllers
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
            var honeUser = new User
            {
                UserNo = 1,
                UserName = "홍길동"
            };

            // 1번째 방식
            // return View(honeUser);

            // 2번째 방식
            // ViewBag.User = honeUser;

            // 3번째 방식(객체는 못넣음)
            ViewData["UserNo"] = honeUser.UserNo;
            ViewData["UserName"] = honeUser.UserName;
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