using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TimetablingSystem1.DataAccess;

namespace TimetablingSystem.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /login/
	public loginController(){
       
	}
	 DataAccessLayer dal = new DataAccessLayer();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid) //Check username and password fields have been filled
            {
                //if (model.Username == "team02" && model.Password == "password") //checks for correct login data
               // DataAccessLayer DAL = new DataAccessLayer();
                    if (DataAccessLayer.UserIsValid(model.Username, model.Password))
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, false); //set to false: cookie is destroyed when browser is closed - user will have to login in again if browser is closed
                        return RedirectToAction("index", "home"); //page is redirected to the page 'index' which has the controller 'home'
                    }
                    {
                        ModelState.AddModelError("", "Invalid password");
                    }
                
              
            }
            return View();
        }
	}
}