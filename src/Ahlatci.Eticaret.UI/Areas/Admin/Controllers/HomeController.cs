using Microsoft.AspNetCore.Mvc;

namespace Ahlatci.Eticaret.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Header = "Ahlatcı ";
            ViewBag.Title = "Yönetim Paneli";
            return View();
        }
    }
}
