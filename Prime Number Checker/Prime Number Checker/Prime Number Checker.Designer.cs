namespace Prime_Number_Checker
{
    partial class PrimeNumberChecker
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
            label1 = new Label();
            btn_PrimeCheck = new Button();
            tbx_Input = new TextBox();
            lbl_Result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter a number";
            // 
            // btn_PrimeCheck
            // 
            btn_PrimeCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_PrimeCheck.Location = new Point(248, 22);
            btn_PrimeCheck.Margin = new Padding(3, 2, 3, 2);
            btn_PrimeCheck.Name = "btn_PrimeCheck";
            btn_PrimeCheck.Size = new Size(88, 34);
            btn_PrimeCheck.TabIndex = 1;
            btn_PrimeCheck.Text = "Check";
            btn_PrimeCheck.UseVisualStyleBackColor = true;
            btn_PrimeCheck.Click += btn_PrimeCheck_Click;
            // 
            // tbx_Input
            // 
            tbx_Input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Input.Location = new Point(139, 24);
            tbx_Input.Margin = new Padding(3, 2, 3, 2);
            tbx_Input.Name = "tbx_Input";
            tbx_Input.Size = new Size(91, 29);
            tbx_Input.TabIndex = 2;
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Result.Location = new Point(10, 63);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(71, 30);
            lbl_Result.TabIndex = 3;
            lbl_Result.Text = "Result";
            // 
            // PrimeNumberChecker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 116);
            Controls.Add(lbl_Result);
            Controls.Add(tbx_Input);
            Controls.Add(btn_PrimeCheck);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PrimeNumberChecker";
            Text = "Prime Number Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_PrimeCheck;
        private TextBox tbx_Input;
        private Label lbl_Result;
    }
}