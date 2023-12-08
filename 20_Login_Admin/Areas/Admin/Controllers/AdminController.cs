using Microsoft.AspNetCore.Mvc;
using App.Filters;

namespace App.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
    //Arquivo pertence a área Admin
        [Area("Admin")]
        [AdminAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}