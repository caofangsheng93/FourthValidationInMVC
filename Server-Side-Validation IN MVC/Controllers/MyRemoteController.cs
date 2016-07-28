using Server_Side_Validation_IN_MVC.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server_Side_Validation_IN_MVC.Controllers
{
    public class MyRemoteController : Controller
    {
        // GET: MyRemote
        public JsonResult RemoteValidate(string name) //这里的参数名字，必须要和视图中文本框控件的名字一样，但大小写无所谓
        {
            //如果存在用户名,即isExists=true
            bool isExists = MyRemoteStaticData.RemoteList.
                Where(s => s.Name.ToLowerInvariant().
                    Equals(name.ToLower())).FirstOrDefault() != null;
            //就向前台返回false，表明已经存在userName
            return Json(!isExists,JsonRequestBehavior.AllowGet);
        }


        public JsonResult RemoteValidationAddtional(string name, string email)
                {
            //如果存在用户名,即isExists=true
            bool isExists = MyRemoteStaticData.RemoteList.
                Where(s => s.Name.ToLowerInvariant().
                    Equals(name.ToLower()) && s.Email.ToLowerInvariant().Equals(email.ToLower())).FirstOrDefault() != null;
            //就向前台返回false，表明已经存在userName
            return Json(!isExists, JsonRequestBehavior.AllowGet);
        }
    }
}