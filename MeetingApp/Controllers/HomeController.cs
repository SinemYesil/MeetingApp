using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{public class HomeController: Controller
 {
     // localhost/ home
     public IActionResult Index()
     {
         return View();
     }
 }
}
