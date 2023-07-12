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

            bool passwordTestResult = TestPassword(password);

            if (passwordTestResult == true)
                {
                tbx_Result.Text = "Your password is secure";
            }
            else
            {
                tbx_Result.Text = "Your password is not very secure";
            }
        }
        

    }
}