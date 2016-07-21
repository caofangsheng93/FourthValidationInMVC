using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Server_Side_Validation_IN_MVC.Models
{
    public class StudentServer
    {
        [Required(ErrorMessage="Name为必填项")]
        public string Name { get; set; }

        [Required(ErrorMessage="电子邮件必须")]
        [EmailAddress(ErrorMessage="电子邮件格式不对")]
        public string Email { get; set; }
    }
}