namespace PasswordChecker
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
            label2 = new Label();
            tbx_Result = new TextBox();
            label1 = new Label();
            btn_Test = new Button();
            tbx_Password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Result";
            // 
            // tbx_Result
            // 
            tbx_Result.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Result.Location = new Point(204, 193);
            tbx_Result.Name = "tbx_Result";
            tbx_Result.Size = new Size(273, 27);
            tbx_Result.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter your password";
            // 
            // btn_Test
            // 
            btn_Test.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Test.Location = new Point(494, 138);
            btn_Test.Name = "btn_Test";
            btn_Test.Size = new Size(84, 35);
            btn_Test.TabIndex = 6;
            btn_Test.Text = "TEST";
            btn_Test.UseVisualStyleBackColor = true;
            btn_Test.Click += btn_Test_Click;
            // 
            // tbx_Password
            // 
            tbx_Password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Password.Location = new Point(204, 142);
            tbx_Password.Name = "tbx_Password";
            tbx_Password.Size = new Size(273, 27);
            tbx_Password.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 27);
            label3.Name = "label3";
            label3.Size = new Size(282, 20);
            label3.TabIndex = 10;
            label3.Text = "A password should contain the following:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(351, 28);
            label4.Name = "label4";
            label4.Size = new Size(201, 20);
            label4.TabIndex = 11;
            label4.Text = "At least 16 characters in total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(351, 48);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 12;
            label5.Text = "At least 1 number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 68);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 13;
            label6.Text = "At least 1 special character";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(351, 88);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 14;
            label7.Text = "At least 1 capital letter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 248);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbx_Result);
            Controls.Add(label1);
            Controls.Add(btn_Test);
            Controls.Add(tbx_Password);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Password Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tbx_Result;
        private Label label1;
        private Button btn_Test;
        private TextBox tbx_Password;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}