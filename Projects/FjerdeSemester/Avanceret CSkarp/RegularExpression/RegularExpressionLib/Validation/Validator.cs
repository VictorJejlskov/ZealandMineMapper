using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionLib.Validation
{
    public class Validator
    {
        public static bool CheckName(String name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            String pattern = @"^[a-zA-ZæøåÆØÅ][a-zA-ZæøåÆØÅ\s\.-]*$"; //start and ends with letters minimum 1 letter
            Regex regex = new Regex(pattern);

            return regex.IsMatch(name);
        }

        public static bool CheckZip(String zip)
        {
            if (string.IsNullOrEmpty(zip))
                return false;


            String pattern = @"^\d{4}$"; //start and ends with exact 4 digits
            Regex regex = new Regex(pattern);

            return regex.IsMatch(zip);
        }

        public static bool CheckHouseNumber(String number)
        {
            if (string.IsNullOrEmpty(number))
                return false;


            String pattern = @"^\d+\s*\w?\s*\d*\s*\.?(tv|th|m)?$"; //start and ends with ex 167 B 1tv
            Regex regex = new Regex(pattern);

            return regex.IsMatch(number);
        }

        public static bool CheckPhone(String phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            String pattern = @"^(\+\d{2}\s*)?\d{8}$"; //start and ends with exact 8 digits possible prefixed with +xx
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phone);
        }

        public static bool CheckEmail(String mail)
        {
            if (string.IsNullOrEmpty(mail))
                return false;

            String pattern = @"^\w[\w\.\-_]*@(\w+\.)+\w{1,5}$"; //start and ends with email aka ksdjfkjf.sdfklk-3@gafkd.com
            Regex regex = new Regex(pattern);

            return regex.IsMatch(mail);
        }


    }
}
