using Microsoft.AspNetCore.Mvc;
using Task1MVC.Data;

namespace Task1MVC.Controllers
{
    public class StudentsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
