using Microsoft.AspNetCore.Mvc;
using Practice1.Models;
using System.Text;

namespace Practice1.Controllers
{
    public class ApiController : Controller
    {
        private readonly MyDBContext _context;
        public ApiController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //return View();
            Thread.Sleep(5000);
            return Content("Hello你好", "text/plain", Encoding.UTF8);
        }
        public IActionResult First()
        {
            return View();
        }
        public IActionResult Register(string name, int age = 28)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "guest";
            }
            return Content($"Hello {name}, {age}歲了", "text/plain", Encoding.UTF8);
        }
        public IActionResult Cities()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }
        public IActionResult Avatar(int id = 1)
        {
            var member = _context.Members.Find(id);
            if( member != null)
            {
                byte[] img = member.FileData;
                if( img != null )
                {
                    return File(img, "image/jpeg");
                }
            }
            return NotFound();
        }

    }
}
