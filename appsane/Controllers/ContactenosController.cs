using Microsoft.AspNetCore.Mvc;

namespace appsane.Controllers
{
    public class ContactenosController : Controller
    {
        public IActionResult Contacto(){
            return View();
        }
    }
}