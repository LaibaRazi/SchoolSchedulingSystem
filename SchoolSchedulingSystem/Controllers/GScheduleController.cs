using Microsoft.AspNetCore.Mvc;
using SchoolSchedulingSystem.Models;

namespace SchoolSchedulingSystem.Controllers
{
    public class GScheduleController : Controller
    {
        readonly ScheduleDbContext db;
        public GScheduleController(ScheduleDbContext db) 
        { this.db = db; }
        public IActionResult GIndex()
        {
            var grade=db.Grades.ToList();
            return View(grade);
        }
        
        public IActionResult GCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GCreate(Grade Model) 
        {
            if (ModelState.IsValid ) 
            {
                var Gdata = new Grade()
                {
                    Class = Model.Class,
                    Section = Model.Section,
                }; 
                db.Grades.Add(Gdata);
                db.SaveChanges();
                return View(Gdata);
            }
            return View();
        }
        public IActionResult Edit(Grade grade,int id) 
        {
            var edata_temp = db.Grades.Where(u =>u.Id==id).FirstOrDefault();
        return View(edata_temp);
        }

        [HttpPost]
        public IActionResult Edit(Grade grade)
        {
            var edata=db.Grades.Where(x=>x.Id==grade.Id).FirstOrDefault();
            if (edata != null) 
            { 
                edata.Id = grade.Id;
                edata.Section = grade.Section;
                db.SaveChanges();
                return RedirectToAction("GIndex");
            }
            
            return View("GIndex");
        }
    }
}
