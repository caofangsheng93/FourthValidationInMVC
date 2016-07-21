using Server_Side_Validation_IN_MVC.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server_Side_Validation_IN_MVC.Controllers
{
    public class RemoteValidatorController : Controller
    {
        // GET: RemoteValidator
        public JsonResult IsUserNameExists(string userName)
        {
            //如果名字存在
            bool isExist = MyData.UserList.
                Where(s => s.UserName.ToLowerInvariant().
                    Equals(userName.ToLower())).FirstOrDefault() != null;

            //存在的话，就返回false给页面
            return Json(!isExist,JsonRequestBehavior.AllowGet);
        }
    }
}