using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server_Side_Validation_IN_MVC.Models
{
    public class UserModel
    {

         [Remote("IsUserNameExists", "RemoteValidator", ErrorMessage = "User name already exist")]  
        public string UserName { get; set; }

        public string Email { get; set; }

    }
}