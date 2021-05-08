using Microsoft.AspNetCore.Mvc;

namespace appsane.Controllers
{
    public class NosotrosController : Controller
    {
        public IActionResult Descripcion(){
            return View();
        }
    }
}