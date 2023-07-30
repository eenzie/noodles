using System.ComponentModel;
using System.Reflection;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool xTurn = true;   // true = x turn, false = y turn
        int turnCount = 0;

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xTurn = true;
            turnCount = 0;

            foreach (var button in btnPanel.Controls.OfType<Button>())
            {
                button.Enabled = true;
                button.Text = "";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Creates button and cast generic sender object to it
            Button button = (Button)sender;

            if (xTurn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            // Disables button
            button.Enabled = false;

            // Changes turn to the opposite of the current status (true to false or false to true)
            xTurn = !xTurn;

            // Turn counter
            turnCount++;

            // Checks for winner
            checkForWinner();
        }

        /// <summary>
        /// Checks for a winner
        /// </summary>
        private void checkForWinner()
        {
            bool winnerFound = false;

            //Check to see if text in three button in row is the same,
            //AND if the first button on the row is disabled
            //(so that a row of "empty strings" are not evaluated as the same (true))

            //Horizontal
            if (((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) ||
                ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) ||
                ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)))
            {
                winnerFound = true;
            }

            //Vertical
            else if (((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) ||
                    ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) ||
                    ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)))
            {
                winnerFound = true;
            }

            //Diagonal
            else if (((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) ||
                ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled)))
            {
                winnerFound = true;
            }

            if (winnerFound)
            {
                disableButtons();

                string winner = "";
                if (xTurn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show($"{winner} wins!", "Congratulations!");
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("It's a draw!", "Play again?");
                }
            }
        }

        /// <summary>
        /// Disables all buttons in panel
        /// </summary>
        private void disableButtons()
        {
            foreach (var button in btnPanel.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}