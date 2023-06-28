using Microsoft.AspNetCore.Mvc;

namespace StockPicker.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
