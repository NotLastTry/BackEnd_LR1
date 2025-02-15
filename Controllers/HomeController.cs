using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BackEnd_Нагорнов_А.В._ЛР1.Models;

namespace BackEnd_Нагорнов_А.В._ЛР1.Controllers
{
    public class HomeController : Controller //Контроллеры связывают работу представлений и моделей
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //При переходе страницы вызывает рендер одноимённой выбранной страницы через RenderBody 
        {
            return View();
        }

        public IActionResult Page1() //При переходе страницы вызывает рендер одноимённой выбранной страницы через RenderBody 
        {
            return View();
        }
        public IActionResult Page2() //При переходе страницы вызывает рендер одноимённой выбранной страницы через RenderBody 
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
