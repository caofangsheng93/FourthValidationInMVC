using Server_Side_Validation_IN_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server_Side_Validation_IN_MVC.StaticData
{
    public static class MyData
    {
        public static List<UserModel> UserList
        {
            get
            {
                return new List<UserModel>()
            {
                new UserModel()
                    {
                    UserName="cfs",
                    Email="fangsheng93@163.com"
                    },
                    new UserModel()
                    {
                    UserName="Daniel",
                    Email="Daniel@163.com"
                    }

            };
            }
        }

    }
}