using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server_Side_Validation_IN_MVC.Models
{
    public class RemoteUser
    {
        [Remote("RemoteValidate", "MyRemote", ErrorMessage = "抱歉用户名已经存在！请重新输入！！！")]
        public string Name { get; set; }

        //注意，这里的AdditionalFields="Name"，Name字段必须和Modle中的字段完全一样
        [Remote("RemoteValidationAddtional", "MyRemote", AdditionalFields = "Name", ErrorMessage = "抱歉Email已经存在！请重新输入！！！")]
        public string Email { get; set; }

       
    }
}