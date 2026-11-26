using Microsoft.AspNetCore.Mvc;

namespace MYA_Stayholm.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
