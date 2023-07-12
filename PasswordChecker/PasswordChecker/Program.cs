using System.Security.Cryptography.X509Certificates;

namespace PasswordChecker
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static bool TestPasswordFormat(string password)
        {
            bool validResult;

            if (password.Contains(" ") || password.Contains(""))
            {
                validResult = false;

            }
            else
            {
                validResult = true;
            }

            return validResult;
        }

        static bool TestPasswordLength(string password)
        {
            bool lengthResult;

            if (password.Length > 16)
            {
                lengthResult = true;
            }
            else
            {
                lengthResult = false;
            }
            return lengthResult;
        }

        static bool TestPasswordNumbers(string password)
        {
            bool numberResult;

            if (password.Any(char.IsDigit))
            {
                numberResult = true;
            }
            else
            {
                numberResult = false;
            }

            return numberResult;
        }

        static bool TestPasswordSpecialCharacters(string password)
        {
            bool specialChar;

            if (!password.Any(char.IsLetterOrDigit))
            {
                specialChar = true;
            }
            else
            {
                specialChar = false;
            }

            return specialChar;
        }

        public bool TestPassword(string password)
        {

            if (!TestPasswordFormat(password))
            {
               return false;
            }
            else if (!TestPasswordLength(password))
            {
                return false;
            }
            else if (!TestPasswordNumbers(password))
            {
                return false;
            }
            else if (!TestPasswordSpecialCharacters(password))
            {
                return false;
            }
            else 
            { 
                 return true; 
            }
        }
    }
}