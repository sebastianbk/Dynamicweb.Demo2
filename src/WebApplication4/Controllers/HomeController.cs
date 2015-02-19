using Microsoft.AspNet.Mvc;
using WebApplication4.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var person = new Person();
            person.Name = "Sebastian";
            person.AgeInYears = 55;

            return View(person);
        }
    }
}
