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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Result";
            // 
            // tbx_Result
            // 
            tbx_Result.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Result.Location = new Point(10, 92);
            tbx_Result.Multiline = true;
            tbx_Result.Name = "tbx_Result";
            tbx_Result.Size = new Size(766, 146);
            tbx_Result.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 7;
            label1.Text = "Test your password strength";
            // 
            // btn_Test
            // 
            btn_Test.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Test.Location = new Point(613, 20);
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
            tbx_Password.Location = new Point(255, 24);
            tbx_Password.Name = "tbx_Password";
            tbx_Password.Size = new Size(307, 27);
            tbx_Password.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 376);
            Controls.Add(label2);
            Controls.Add(tbx_Result);
            Controls.Add(label1);
            Controls.Add(btn_Test);
            Controls.Add(tbx_Password);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tbx_Result;
        private Label label1;
        private Button btn_Test;
        private TextBox tbx_Password;
    }
}