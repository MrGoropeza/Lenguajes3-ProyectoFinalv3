using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lenguajes3_ProyectoFinalv3.Servicios
{
    public class PhoneValidator
    {
        public static bool isValid(string numero)
        {
            var phoneValidator = PhoneNumberUtil.GetInstance();

            try
            {
                var num = phoneValidator.Parse(numero, "AR");
                return phoneValidator.IsValidNumberForRegion(num, "AR");
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}