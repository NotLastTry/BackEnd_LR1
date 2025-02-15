using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BackEnd_��������_�.�._��1.Models;

namespace BackEnd_��������_�.�._��1.Controllers
{
    public class HomeController : Controller //����������� ��������� ������ ������������� � �������
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //��� �������� �������� �������� ������ ���������� ��������� �������� ����� RenderBody 
        {
            return View();
        }

        public IActionResult Page1() //��� �������� �������� �������� ������ ���������� ��������� �������� ����� RenderBody 
        {
            return View();
        }
        public IActionResult Page2() //��� �������� �������� �������� ������ ���������� ��������� �������� ����� RenderBody 
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
