namespace Rock_Paper_Scissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            groupBox1 = new GroupBox();
            lbl_Winner = new Label();
            lbl_CompChoice = new Label();
            lbl_PlayerChoice = new Label();
            label6 = new Label();
            label5 = new Label();
            btn_Scissors = new Button();
            btn_Paper = new Button();
            btn_Rock = new Button();
            groupBox2 = new GroupBox();
            tbx_Rounds = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbx_CompScore = new TextBox();
            tbx_PlayerScore = new TextBox();
            label7 = new Label();
            tbx_Ratio = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 195);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 13;
            label3.Text = "The winner is";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_Winner);
            groupBox1.Controls.Add(lbl_CompChoice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_PlayerChoice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btn_Scissors);
            groupBox1.Controls.Add(btn_Paper);
            groupBox1.Controls.Add(btn_Rock);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 245);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Click button to play";
            // 
            // lbl_Winner
            // 
            lbl_Winner.AutoSize = true;
            lbl_Winner.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Winner.ForeColor = Color.FromArgb(128, 255, 255);
            lbl_Winner.Location = new Point(178, 195);
            lbl_Winner.Name = "lbl_Winner";
            lbl_Winner.Size = new Size(30, 25);
            lbl_Winner.TabIndex = 24;
            lbl_Winner.Text = "...";
            // 
            // lbl_CompChoice
            // 
            lbl_CompChoice.AutoSize = true;
            lbl_CompChoice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CompChoice.ForeColor = Color.FromArgb(128, 255, 255);
            lbl_CompChoice.Location = new Point(178, 150);
            lbl_CompChoice.Name = "lbl_CompChoice";
            lbl_CompChoice.Size = new Size(21, 20);
            lbl_CompChoice.TabIndex = 23;
            lbl_CompChoice.Text = "...";
            // 
            // lbl_PlayerChoice
            // 
            lbl_PlayerChoice.AutoSize = true;
            lbl_PlayerChoice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PlayerChoice.ForeColor = Color.FromArgb(128, 255, 255);
            lbl_PlayerChoice.Location = new Point(178, 106);
            lbl_PlayerChoice.Name = "lbl_PlayerChoice";
            lbl_PlayerChoice.Size = new Size(21, 20);
            lbl_PlayerChoice.TabIndex = 22;
            lbl_PlayerChoice.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 150);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 21;
            label6.Text = "Computer chose";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 109);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 20;
            label5.Text = "You chose";
            // 
            // btn_Scissors
            // 
            btn_Scissors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Scissors.ForeColor = SystemColors.ActiveCaptionText;
            btn_Scissors.Location = new Point(226, 50);
            btn_Scissors.Name = "btn_Scissors";
            btn_Scissors.Size = new Size(106, 37);
            btn_Scissors.TabIndex = 18;
            btn_Scissors.Text = "SCISSORS";
            btn_Scissors.UseVisualStyleBackColor = true;
            btn_Scissors.Click += btn_Scissors_Click;
            // 
            // btn_Paper
            // 
            btn_Paper.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Paper.ForeColor = SystemColors.ActiveCaptionText;
            btn_Paper.Location = new Point(119, 50);
            btn_Paper.Name = "btn_Paper";
            btn_Paper.Size = new Size(101, 37);
            btn_Paper.TabIndex = 17;
            btn_Paper.Text = "PAPER";
            btn_Paper.UseVisualStyleBackColor = true;
            btn_Paper.Click += btn_Paper_Click;
            // 
            // btn_Rock
            // 
            btn_Rock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Rock.ForeColor = SystemColors.ActiveCaptionText;
            btn_Rock.Location = new Point(14, 50);
            btn_Rock.Name = "btn_Rock";
            btn_Rock.Size = new Size(99, 37);
            btn_Rock.TabIndex = 16;
            btn_Rock.Text = "ROCK";
            btn_Rock.UseVisualStyleBackColor = true;
            btn_Rock.Click += btn_Rock_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbx_Ratio);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbx_Rounds);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbx_CompScore);
            groupBox2.Controls.Add(tbx_PlayerScore);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(380, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 245);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "SCORE";
            // 
            // tbx_Rounds
            // 
            tbx_Rounds.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Rounds.Location = new Point(107, 55);
            tbx_Rounds.Name = "tbx_Rounds";
            tbx_Rounds.Size = new Size(61, 29);
            tbx_Rounds.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 58);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 12;
            label4.Text = "Round";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 156);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 11;
            label2.Text = "Computer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 112);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 10;
            label1.Text = "Player";
            // 
            // tbx_CompScore
            // 
            tbx_CompScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_CompScore.Location = new Point(107, 153);
            tbx_CompScore.Name = "tbx_CompScore";
            tbx_CompScore.Size = new Size(61, 29);
            tbx_CompScore.TabIndex = 9;
            // 
            // tbx_PlayerScore
            // 
            tbx_PlayerScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_PlayerScore.Location = new Point(107, 109);
            tbx_PlayerScore.Name = "tbx_PlayerScore";
            tbx_PlayerScore.Size = new Size(61, 29);
            tbx_PlayerScore.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 199);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 14;
            label7.Text = "Ratio";
            // 
            // tbx_Ratio
            // 
            tbx_Ratio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Ratio.Location = new Point(107, 196);
            tbx_Ratio.Name = "tbx_Ratio";
            tbx_Ratio.Size = new Size(61, 29);
            tbx_Ratio.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 65, 65);
            ClientSize = new Size(600, 266);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private GroupBox groupBox1;
        private Label lbl_CompChoice;
        private Label lbl_PlayerChoice;
        private Label label6;
        private Label label5;
        private Button btn_Scissors;
        private Button btn_Paper;
        private Button btn_Rock;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox tbx_CompScore;
        private TextBox tbx_PlayerScore;
        private Label lbl_Winner;
        private TextBox tbx_Rounds;
        private Label label4;
        private TextBox tbx_Ratio;
        private Label label7;
    }
}