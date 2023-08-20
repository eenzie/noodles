namespace Basic_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn7 = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btnAddition = new Button();
            btnSubtraction = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            btnEqual = new Button();
            btnDecimal = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            tbx_Result = new TextBox();
            lbl_CurrentOperation = new Label();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.BackColor = Color.Honeydew;
            btn7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(11, 95);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 60);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Honeydew;
            btn8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(70, 95);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 60);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Honeydew;
            btn4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(11, 160);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 60);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Honeydew;
            btn0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(14, 291);
            btn0.Name = "btn0";
            btn0.Size = new Size(110, 60);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Honeydew;
            btn3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(128, 225);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 60);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Honeydew;
            btn2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(72, 225);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 60);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Honeydew;
            btn1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(11, 225);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 60);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Honeydew;
            btn6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(128, 160);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 60);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Honeydew;
            btn5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(70, 160);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 60);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Honeydew;
            btn9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(128, 95);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 60);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = Color.SeaShell;
            btnAddition.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddition.Location = new Point(186, 291);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(51, 60);
            btnAddition.TabIndex = 10;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnOperator_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = Color.SeaShell;
            btnSubtraction.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtraction.Location = new Point(186, 225);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(51, 60);
            btnSubtraction.TabIndex = 11;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += btnOperator_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.SeaShell;
            btnMultiplication.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplication.Location = new Point(186, 160);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(51, 60);
            btnMultiplication.TabIndex = 12;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnOperator_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.SeaShell;
            btnDivision.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(186, 95);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(51, 60);
            btnDivision.TabIndex = 13;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnOperator_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.AliceBlue;
            btnEqual.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(245, 225);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(51, 125);
            btnEqual.TabIndex = 14;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Honeydew;
            btnDecimal.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.Location = new Point(128, 291);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(51, 60);
            btnDecimal.TabIndex = 15;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnNum_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.Snow;
            btnClearEntry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(245, 95);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(51, 60);
            btnClearEntry.TabIndex = 16;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Snow;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(245, 161);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(51, 60);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbx_Result
            // 
            tbx_Result.BackColor = Color.GhostWhite;
            tbx_Result.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbx_Result.Location = new Point(14, 47);
            tbx_Result.Margin = new Padding(3, 4, 3, 4);
            tbx_Result.Name = "tbx_Result";
            tbx_Result.Size = new Size(282, 34);
            tbx_Result.TabIndex = 18;
            tbx_Result.Text = "0";
            tbx_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_CurrentOperation
            // 
            lbl_CurrentOperation.AutoSize = true;
            lbl_CurrentOperation.BackColor = Color.MintCream;
            lbl_CurrentOperation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CurrentOperation.ForeColor = Color.Gray;
            lbl_CurrentOperation.Location = new Point(14, 16);
            lbl_CurrentOperation.Name = "lbl_CurrentOperation";
            lbl_CurrentOperation.Size = new Size(0, 25);
            lbl_CurrentOperation.TabIndex = 19;
            lbl_CurrentOperation.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(310, 367);
            Controls.Add(lbl_CurrentOperation);
            Controls.Add(tbx_Result);
            Controls.Add(btnClear);
            Controls.Add(btnClearEntry);
            Controls.Add(btnDecimal);
            Controls.Add(btnEqual);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(btnSubtraction);
            Controls.Add(btnAddition);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private Button btn8;
        private Button btn4;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn9;
        private Button btnAddition;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnDivision;
        private Button btnEqual;
        private Button btnDecimal;
        private Button btnClearEntry;
        private Button btnClear;
        private TextBox tbx_Result;
        private Label lbl_CurrentOperation;
    }
}