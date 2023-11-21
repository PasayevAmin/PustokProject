using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.PustokAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
