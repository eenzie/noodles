namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            string password = tbx_Password.Text;

            bool isPasswordSecure = TestPassword(password);

            if (!isPasswordSecure)
            {
                tbx_Result.BackColor = Color.Red;
                tbx_Result.ForeColor = Color.Yellow;
                tbx_Result.Text = "Your password is not secure";
            }
            else
            {
                tbx_Result.BackColor = Color.Green;
                tbx_Result.ForeColor = Color.Yellow;
                tbx_Result.Text = "Your password is secure!";
            }
        }

        static bool TestPasswordFormat(string password)
        {
            return !password.Contains(" ") && !string.IsNullOrEmpty(password);
        }

        static bool TestPasswordLength(string password)
        {
            return password.Length > 16;
        }

        static bool TestPasswordNumbers(string password)
        {
            return password.Any(char.IsDigit);
        }

        static bool TestPasswordSpecialCharacters(string password)
        {
            return password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        static bool TestPasswordCapitalLetter(string password)
        {
            return password.Any(char.IsUpper);
        }

        public bool TestPassword(string password)
        {
            bool isPasswordValid = true;

            if (!TestPasswordFormat(password))
            {
                isPasswordValid = false;
            }

            if (!TestPasswordLength(password))
            {
                isPasswordValid = false;
            }

            if (!TestPasswordNumbers(password))
            {
                isPasswordValid = false;
            }

            if (!TestPasswordSpecialCharacters(password))
            {
                isPasswordValid = false;
            }

            if (!TestPasswordCapitalLetter(password))
            {
                isPasswordValid = false;
            }

            return isPasswordValid;
        }

    }
}