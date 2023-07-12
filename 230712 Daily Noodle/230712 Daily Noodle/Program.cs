namespace _230712_Daily_Noodle
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static void TestPasswordLength(string password, out string lengthResult, out string numberResult, out string specialChar)
        {
            lengthResult = "";
            numberResult = "";
            specialChar = "";

            if (password != null)
            {
                if (password.Length > 16)
                {
                    lengthResult = "Your password is longer than 16 characters";
                }
                else
                {
                    lengthResult = "Your password is not long enough to be secure";
                }

                if (password.Any(char.IsDigit))
                {
                    numberResult = "Your password contains a number";
                }
                else
                {
                    numberResult = "Your password doesn't contains a number and is therefore not secure";
                }

                if (!password.Any(char.IsLetterOrDigit))
                {
                    specialChar = "Your password contains a special character";
                }
                else
                {
                    specialChar = "Your password doesn't contains a special character and is therefore not secure";
                }
            }
            else
            {
                lengthResult = "Please enter a password";
            }
        }
    }
}