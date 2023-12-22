using Microsoft.AspNetCore.Mvc;

namespace FM_MyStat_API.Api.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
