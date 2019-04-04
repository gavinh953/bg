using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Bigschool.ViewModel
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var Isvalid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (Isvalid && dateTime > DateTime.Now);

        }
    }
}