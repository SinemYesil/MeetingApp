using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{public class HomeController: Controller
 {
     // localhost/ home
     public IActionResult Index()
     {
         
            int saat = DateTime.Now.Hour;
       //  int saat = 13;
        // var selamlama = saat > 12 ?
        // // ViewData["Selamlama"]saat>12? "İyi Günler" : "Günaydın";
                                               
         ViewBag.Selamlama=saat>12? "İyi Günler" : "Günaydın";
         int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

         //ViewBag.UserName = "Sinem";

         var meetingInfo = new MeetingInfo()
         {
             Id =1, 
             Location = "İzmir-Balçova", 
             Date = new DateTime(2024,08,19,20,0,0),
             NumberOfPeople = UserCount
         };
        
         return View(meetingInfo);
     }
 }
}
