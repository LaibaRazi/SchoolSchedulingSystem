using Microsoft.AspNetCore.Mvc;
using SchoolSchedulingSystem.Models;
using Microsoft.AspNetCore.Http;


namespace SchoolSchedulingSystem.Controllers
{
    public class AdminController : Controller
    {
      

        public IActionResult Logout()
        {
            return View();
        }

    }
}
