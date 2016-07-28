using Server_Side_Validation_IN_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server_Side_Validation_IN_MVC.StaticData
{
    public static class MyRemoteStaticData
    {
        public static List<RemoteUser> RemoteList
        {
            get
            {
                return new List<RemoteUser>()
            {
            new RemoteUser(){Name="Daniel",Email="Daniel@163.com"},
            new RemoteUser(){Name="CFS",Email="CFS@163.com"}
            };
            }

        }
    }
}