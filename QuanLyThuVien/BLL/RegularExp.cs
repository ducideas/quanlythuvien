using System.Text.RegularExpressions;

namespace BLL
{
    public class RegularExp
    {
        public bool Is_WhiteSpaceAndLetters_Only(string input)
        {
            Regex reg = new Regex(@"^[a-zA-Z\s]*$");

            return reg.IsMatch(input);
        }

        public bool Is_Letter_Only(string input)
        {
            Regex reg = new Regex(@"^[a-zA-Z]+$");

            return reg.IsMatch(input);
        }

        public bool Is_Numbers_Only(string input)
        {
            Regex reg = new Regex(@"^[0-9]+$");

            return reg.IsMatch(input);
        }

        public bool Is_NumberAndLetter_Only(string input)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]+$");

            return reg.IsMatch(input);
        }

        public bool Is_UsernameOrPassword_Valid(string input)
        {
            Regex reg = new Regex(@"^[a-z0-9_-]{2,18}$$");

            return reg.IsMatch(input);
        }

        public bool Is_Email_Valid(string input)
        {

            Regex reg = new Regex(@"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,18})$");

            return reg.IsMatch(input);
        }

        public bool Is_Address_Valid(string input)
        {
            Regex reg = new Regex(@"(.*?)\s * (\d + (?:[/ -]\d +)?)?$");

            return reg.IsMatch(input);
        }    
    }
}
