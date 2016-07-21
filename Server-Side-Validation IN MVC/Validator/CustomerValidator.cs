using FluentValidation;
using Server_Side_Validation_IN_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server_Side_Validation_IN_MVC.Validator
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("名字不能为空");
            RuleFor(s => s.Email).NotEmpty().WithMessage("电子邮件不能为空");
            RuleFor(s => s.Email).EmailAddress().WithMessage("电子邮件格式不合法");
        }
    }
}