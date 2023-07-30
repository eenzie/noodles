namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables for game choices
        string playerChoice = "";
        string computerChoice = "";

        // Variables for game stats
        int round = 1;
        int playerWins = 0;
        int computerWins = 0;

        // Variable for player win ratio
        double winRatio;

        private void btn_Rock_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            lbl_PlayerChoice.Text = playerChoice.ToString();

            getRandomNumber();
            lbl_CompChoice.Text = computerChoice.ToString();

            if (computerChoice == playerChoice)
            {
                Tie();
            }
            else if (computerChoice == "Scissors")
            {
                Wins();
            }
            else if (computerChoice == "Paper")
            {
                Loses();
            }
            round++;
        }

        private void btn_Paper_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            lbl_PlayerChoice.Text = playerChoice.ToString();

            getRandomNumber();
            lbl_CompChoice.Text = computerChoice.ToString();

            if (computerChoice == playerChoice)
            {
                Tie();
            }
            else if (computerChoice == "Rock")
            {
                Wins();
            }
            else if (computerChoice == "Scissors")
            {
                Loses();
            }
            round++;
        }

        private void btn_Scissors_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            lbl_PlayerChoice.Text = playerChoice.ToString();

            getRandomNumber();
            lbl_CompChoice.Text = computerChoice.ToString();

            if (computerChoice == playerChoice)
            {
                Tie();
            }
            else if (computerChoice == "Paper")
            {
                Wins();
            }
            else if (computerChoice == "Rock")
            {
                Loses();
            }
            round++;
        }

        /// <summary>
        /// Generates computer choice using random number generator
        /// </summary>
        private void getRandomNumber()
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
            {
                computerChoice = "Rock";
            }
            else if (randomNumber == 2)
            {
                computerChoice = "Paper";
            }
            else if (randomNumber == 3)
            {
                computerChoice = "Scissors";
            }
        }

        /// <summary>
        /// Displays results from a player win outcome and calls the ratio method
        /// </summary>
        private void Wins()
        {
            lbl_Winner.Text = "Player!";
            playerWins++;

            tbx_Rounds.Text = round.ToString();
            tbx_PlayerScore.Text = playerWins.ToString();
            tbx_CompScore.Text = computerWins.ToString();
            
            Ratio();
        }

        /// <summary>
        /// Displays results from a computer win outcome and calls the ratio method
        /// </summary>
        private void Loses()
        {
            lbl_Winner.Text = "Computer!";
            computerWins++;

            tbx_Rounds.Text = round.ToString();
            tbx_PlayerScore.Text = playerWins.ToString();
            tbx_CompScore.Text = computerWins.ToString();

            Ratio();
        }

        /// <summary>
        /// Displays results from a tie outcome and calls the ratio method
        /// </summary>
        private void Tie()
        {
            lbl_Winner.Text = "It's a tie...";

            tbx_Rounds.Text = round.ToString();
            tbx_PlayerScore.Text = playerWins.ToString();
            tbx_CompScore.Text = computerWins.ToString();

            Ratio();
        }

        /// <summary>
        /// Calculates and displays the player win ratio as a percentage
        /// </summary>
        private void Ratio()
        {
            winRatio = (double)playerWins / round;

            tbx_Ratio.Text = winRatio.ToString("P");
        }
    }
}