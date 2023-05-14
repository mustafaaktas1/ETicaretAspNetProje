using Microsoft.AspNetCore.Mvc;

namespace ETicaretAspNetProje.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
