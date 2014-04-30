using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TimetablingSystem1.DataAccess;
using TimetablingSystem1.Models;


///////////////

namespace TimetablingSystem.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /login/
	public loginController(){
       
	}
	 DataAccessLayer dal = new DataAccessLayer();
     private TimetablingEntities db = new TimetablingEntities();

     public ActionResult Index()
        
        {
            LoginModel lmodel = new LoginModel();

                   
            ViewBag.Password = new SelectList(db.Departments, "DepartmentCode", "PasswordHash");


         var displaydeps = db.Departments.Where(s => s.DepartmentCode != null).ToList();
         
         IEnumerable<SelectListItem> selectList = from s in displaydeps
                                                  select new SelectListItem
                                                  {
                                                      Value = s.DepartmentCode,
                                                      Text = s.DepartmentCode + " - " + s.Name
                                                  };
         ViewBag.DisplayDepartments = new SelectList(selectList, "Value", "Text").Distinct();
        



        
            
                     
            return View();
         
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)

        {
           



            var displaydeps = db.Departments.Where(s => s.DepartmentCode != null).ToList();

            IEnumerable<SelectListItem> selectList = from s in displaydeps
                                                     select new SelectListItem
                                                     {
                                                         Text = s.DepartmentCode + " - " + s.Name,
                                                         Value = s.DepartmentCode
                                                         
                                                     };
            ViewBag.DisplayDepartments = new SelectList(selectList, "Text" , "Value");
            

            if (ModelState.IsValid) 
            {
                
                    if (DataAccessLayer.UserIsValid(model.DisplayDepartments, model.Password))
                    {
                        string selectedDepartment = model.DisplayDepartments;
                        Session["department"] = selectedDepartment;
                        FormsAuthentication.SetAuthCookie(model.DisplayDepartments, false); //set to false: cookie is destroyed when browser is closed - user will have to login in again if browser is closed
                        return RedirectToAction("index", "AddRequest", selectedDepartment); //page is redirected to the page 'index' which has the controller 'home'
                        
                    }
                    {
                        ModelState.AddModelError("", "Invalid password");
                    }
                
              
            }  
            return View();
        }
	}
}