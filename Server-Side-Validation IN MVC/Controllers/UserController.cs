using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server_Side_Validation_IN_MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddUser()
        {

            return View();
        }

        public ActionResult AddRemoteUser()
        {
            return View();
        }
    }
}