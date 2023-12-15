using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.Controllers
{
    public class Team_MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
