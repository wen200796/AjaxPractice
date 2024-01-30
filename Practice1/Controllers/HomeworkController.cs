using Microsoft.AspNetCore.Mvc;
using Practice1.Models;
using System.Text;

namespace Practice1.Controllers
{
    public class HomeworkController : Controller
    {
        private readonly MyDBContext _context;
        public HomeworkController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Homework1()
        {
            return View();
        }
        public IActionResult Homework2()
        {
            return View();
        }

    }
}
