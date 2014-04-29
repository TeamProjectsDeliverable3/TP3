using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimetablingSystem1.Models;


namespace TimetablingSystem1.Controllers
{
    public class RoundController : Controller
    {
        TimetablingEntities db = new TimetablingEntities();
        //
        // GET: /Round/

        public ActionResult Index()
        {
            RoundModel model = new RoundModel();
            IEnumerable<SelectListItem> selectList = from s in db.Semesters
                                                     select new SelectListItem
                                                     {
                                                         Value = (s.SemesterID).ToString(),
                                                         Text = (s.StartYear).ToString() + " - " +
                                                         (s.StartYear+1).ToString() + 
                                                         " Semester " + (s.SemesterNo).ToString()

                                                     };
            ViewBag.academicDates = new SelectList(selectList, "Value", "Text");
            //DateTime x = DateTime.Parse("2014-02-04 09:43:01.000");
            DateTime x;

            IEnumerable<SelectListItem> currentRoundList = from r in db.Rounds join s in db.Semesters on r.SemesterID 
                                                           equals s.SemesterID
                                                           where r.EndDate == null
                                                           select new SelectListItem
                                                     {
                                                        Value = (r.RoundID).ToString(),
                                                        Text = (s.StartYear).ToString() + " - " + (s.StartYear + 1)
                                                        + " Semester " + (s.SemesterNo).ToString()

                                                     };
            model.currentRounds = new SelectList(currentRoundList, "Value", "Text");





            return View(model);
        }
        [HttpPost]
        public ActionResult Index(int i)
        {

            return View();
        }
    }
}
