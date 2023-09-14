using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SchoolSchedulingSystem.Models;

namespace SchoolSchedulingSystem.Controllers
{
    public class TScheduleController : Controller
    {
        readonly ScheduleDbContext db;
        public TScheduleController(ScheduleDbContext db) { this.db = db; }
        // GET: TScheduleController
        
        public ActionResult Index()
        {

            var getteacher = db.Teachers.ToList();
            return View(getteacher);
        }


        public ActionResult Login() 
        {
            return View();
            
        }
        [HttpPost]
        public ActionResult Login(Admin Model) 
        {
            var login = db.Admins.Where(x => x.username == Model.username && x.password == Model.password).FirstOrDefault();
            if(login != null) 
            {
            return RedirectToAction("Create");
            }
            else 
            {
                TempData["Error"] = "Invalid Login";
                return RedirectToAction("SignIn");
            }


        }

        // GET: TScheduleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TScheduleController/Create
        public ActionResult Create()
        {
         
            return View();
        }

        // POST: TScheduleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teacher Model)
        {
            ViewBag.grade = db.Grades.ToList();


            if (ModelState.IsValid) 
                {
                    var data = new Teacher()
                    {
                      
                        Tutor = Model.Tutor,
                        Subj_of_Teacher=Model.Subj_of_Teacher
                    };
                    db.Teachers.Add(data);
                    db.SaveChanges();
                    return RedirectToAction("Index");
               
            }
            return View("Index");

        }

        // GET: TScheduleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TScheduleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TScheduleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TScheduleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SignIn() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(Admin Model)
        {


            if (ModelState.IsValid)
            {
                var data = new Admin()
                {

                    username = Model.username,
                    password = Model.password
                };
                db.Admins.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("Index");
        }


        

    }
}
