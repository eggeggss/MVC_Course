using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Mod02_01.Models
{
    public class CheckYearValid:ValidationAttribute
    {
        public CheckYearValid()
        {
            ErrorMessage = "客製的error";

        }

        public override bool IsValid(object value)
        {
            int year = (int)value;

            return year < 1598 ? false : true;
        }

    }
    
}
