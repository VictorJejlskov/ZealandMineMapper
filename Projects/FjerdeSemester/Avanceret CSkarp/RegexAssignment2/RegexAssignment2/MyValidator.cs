using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment2
{
    public class MyValidator
    {
        public static bool ValidateFirstName(string firstName)
        {
            string pattern = @"^[^ ][A-Za-zæøåÆØÅ ]{0,100}[^\s]?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(firstName);
        }
        public static bool ValidateSurname(string surname)
        {
            string pattern = @"^[^ ][A-Za-zæøåÆØÅ ]{0,100}[^\s]?$$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(surname);
        }
        public static bool ValidateStreet(string street)
        {
            string pattern = @"^[^ ][A-Za-zæøåÆØÅ ]{0,100}[^\s]?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(street);
        }
        public static bool ValidatePostalCity(string postalcity)
        {
            string pattern = @"^[^ ][A-Za-zæøåÆØÅ ]{0,100}[^\s]?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(postalcity);
        }
        public static bool ValidateZip(int zip)
        {
            string pattern = @"^\d{4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(zip.ToString());
        }
        public static bool ValidatePhone(string phone)
        {
            string pattern = @"^(\+\d{1,3})?\s?(\d{8}$)";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }
        public static bool ValidateNumber(string number)
        {
            string pattern = @"^[1-9]\d{0,2}( ([\w \,\.]*)|([\D \,\.]*))?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(number);
        }
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[\w\!\#\$\%\&\'\*\+\-\/\=\?\^\`\{\|\}\~]+(\.[\w\!\#\$\%\&\'\*\+\-\/\=\?\^\`\{\|\}\~]+)?@(\w+)(\-\w+)?(\.\w+)+";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
