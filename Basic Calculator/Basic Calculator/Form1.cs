namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Result
        double resultValue = 0;

        // Operator
        string operationPerformed = "";

        // Operator used (bool)
        bool operationPerformedSpecified = false;

        /// <summary>
        /// Collects all numerical buttons in one click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum_Click(object sender, EventArgs e)
        {
            // Clears the default 0 of the result text box upon a button click
            if ((tbx_Result.Text == "0") || (operationPerformedSpecified))
            {
                tbx_Result.Clear();
            }

            // Casts the sender to the button
            Button button = (Button)sender;

            // Ensures decimal can only be entered once until an operator or equal is used
            if (button.Text == ".")
            {
                if (!tbx_Result.Text.Contains("."))
                {
                    tbx_Result.Text = tbx_Result.Text + button.Text;
                }
            }
            else
            {
                tbx_Result.Text = tbx_Result.Text + button.Text;
            }

            // Bool that checks is operator has not been used
            operationPerformedSpecified = false;
        }

        /// <summary>
        /// Collects all operation buttons in one click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            if (resultValue != 0)
            {
                // Updates the result textbox the same way as the equal button when using any of the operators
                btnEqual.PerformClick();

                // Stores the operator value in the variable
                operationPerformed = button.Text;

                // Displays the current operation in the top label
                lbl_CurrentOperation.Text = resultValue + " " + operationPerformed;

                // Displays the current operation in the top label
                operationPerformedSpecified = true;
            }

            else
            {
                // Stores the operator value in the operator variable
                operationPerformed = button.Text;

                // Parses the result and stores it in the result variable
                resultValue = double.Parse(tbx_Result.Text);

                // Displays the current operation in the top label
                lbl_CurrentOperation.Text = resultValue + " " + operationPerformed;

                // Operator used
                operationPerformedSpecified = true;
            }
        }

        /// <summary>
        /// Click event specifically for the equal operator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Performs the correct operation according to the operator(s) used
            switch (operationPerformed)
            {
                case "+":
                    tbx_Result.Text = (resultValue + double.Parse(tbx_Result.Text)).ToString();
                    break;
                case "-":
                    tbx_Result.Text = (resultValue - double.Parse(tbx_Result.Text)).ToString();
                    break;
                case "*":
                    tbx_Result.Text = (resultValue * double.Parse(tbx_Result.Text)).ToString();
                    break;
                case "/":
                    tbx_Result.Text = (resultValue / double.Parse(tbx_Result.Text)).ToString();
                    break;
                default:
                    break;
            }

            // Updates result value
            resultValue = Double.Parse(tbx_Result.Text);

            // Clears text box
            lbl_CurrentOperation.Text = "";
        }

        /// <summary>
        /// Click event specifically for the Clear Entry (CE) button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            tbx_Result.Text = "0";
        }

        /// <summary>
        /// Click event specifically for the Clear (C) button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx_Result.Text = "0";
            resultValue = 0;

            lbl_CurrentOperation.Text = "";
        }
    }
}