namespace Prime_Number_Checker
{
    public partial class PrimeNumberChecker : Form
    {
        public PrimeNumberChecker()
        {
            InitializeComponent();
        }

        private void btn_PrimeCheck_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(tbx_Input.Text, out int number))
            {
                if (IsPrime(number))
                {
                    lbl_Result.Text = "Prime number";
                }
                else
                {
                    lbl_Result.Text = "Not a prime number";
                }
            }
            else
            {
                lbl_Result.Text = "Please enter a valid number";
            }
        }

        /// <summary>
        /// Checks if input value is a valid and positive integer
        /// </summary>
        /// <param name="input"></param>
        /// <param name="number"></param>
        /// <returns>true or false</returns>
        private bool IsValidNumber(string input, out int number)
        {
            if (int.TryParse(input, out number))
            {
                if (number > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Sets value for smallest prime to remove "magic number" from method
        private const int SmallestPrime = 2;

        /// <summary>
        /// Checks if input number is a prime number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true or false</returns>
        public static bool IsPrime(int number)
        {
            if (number < SmallestPrime)
            {
                return false;
            }

            int divisor = SmallestPrime;
            while (divisor <= number / SmallestPrime)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
                divisor++;
            }

            return true;
        }
    }
}