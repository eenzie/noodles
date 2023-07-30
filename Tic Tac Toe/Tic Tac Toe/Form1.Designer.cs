namespace Tic_Tac_Toe
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
            menuStrip1 = new MenuStrip();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnPanel = new TableLayoutPanel();
            C3 = new Button();
            C2 = new Button();
            C1 = new Button();
            B3 = new Button();
            B2 = new Button();
            B1 = new Button();
            A3 = new Button();
            A2 = new Button();
            A1 = new Button();
            menuStrip1.SuspendLayout();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newGameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem1, exitToolStripMenuItem });
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(37, 20);
            newGameToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(132, 22);
            newGameToolStripMenuItem1.Text = "New Game";
            newGameToolStripMenuItem1.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(132, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnPanel
            // 
            btnPanel.ColumnCount = 3;
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            btnPanel.Controls.Add(C3, 2, 2);
            btnPanel.Controls.Add(C2, 1, 2);
            btnPanel.Controls.Add(C1, 0, 2);
            btnPanel.Controls.Add(B3, 2, 1);
            btnPanel.Controls.Add(B2, 1, 1);
            btnPanel.Controls.Add(B1, 0, 1);
            btnPanel.Controls.Add(A3, 2, 0);
            btnPanel.Controls.Add(A2, 1, 0);
            btnPanel.Controls.Add(A1, 0, 0);
            btnPanel.Dock = DockStyle.Fill;
            btnPanel.Location = new Point(0, 24);
            btnPanel.Margin = new Padding(3, 2, 3, 2);
            btnPanel.Name = "btnPanel";
            btnPanel.RowCount = 3;
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            btnPanel.Size = new Size(484, 437);
            btnPanel.TabIndex = 1;
            // 
            // C3
            // 
            C3.Dock = DockStyle.Fill;
            C3.FlatAppearance.BorderColor = Color.DimGray;
            C3.FlatAppearance.BorderSize = 0;
            C3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            C3.Location = new Point(325, 292);
            C3.Margin = new Padding(3, 2, 3, 2);
            C3.Name = "C3";
            C3.Size = new Size(156, 143);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = true;
            C3.Click += btn_Click;
            // 
            // C2
            // 
            C2.Dock = DockStyle.Fill;
            C2.FlatAppearance.BorderColor = Color.DimGray;
            C2.FlatAppearance.BorderSize = 0;
            C2.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            C2.Location = new Point(164, 292);
            C2.Margin = new Padding(3, 2, 3, 2);
            C2.Name = "C2";
            C2.Size = new Size(155, 143);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = true;
            C2.Click += btn_Click;
            // 
            // C1
            // 
            C1.Dock = DockStyle.Fill;
            C1.FlatAppearance.BorderColor = Color.DimGray;
            C1.FlatAppearance.BorderSize = 0;
            C1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            C1.Location = new Point(3, 292);
            C1.Margin = new Padding(3, 2, 3, 2);
            C1.Name = "C1";
            C1.Size = new Size(155, 143);
            C1.TabIndex = 6;
            C1.UseVisualStyleBackColor = true;
            C1.Click += btn_Click;
            // 
            // B3
            // 
            B3.Dock = DockStyle.Fill;
            B3.FlatAppearance.BorderColor = Color.DimGray;
            B3.FlatAppearance.BorderSize = 0;
            B3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            B3.Location = new Point(325, 147);
            B3.Margin = new Padding(3, 2, 3, 2);
            B3.Name = "B3";
            B3.Size = new Size(156, 141);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = true;
            B3.Click += btn_Click;
            // 
            // B2
            // 
            B2.Dock = DockStyle.Fill;
            B2.FlatAppearance.BorderColor = Color.DimGray;
            B2.FlatAppearance.BorderSize = 0;
            B2.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            B2.Location = new Point(164, 147);
            B2.Margin = new Padding(3, 2, 3, 2);
            B2.Name = "B2";
            B2.Size = new Size(155, 141);
            B2.TabIndex = 4;
            B2.UseVisualStyleBackColor = true;
            B2.Click += btn_Click;
            // 
            // B1
            // 
            B1.Dock = DockStyle.Fill;
            B1.FlatAppearance.BorderColor = Color.DimGray;
            B1.FlatAppearance.BorderSize = 0;
            B1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            B1.Location = new Point(3, 147);
            B1.Margin = new Padding(3, 2, 3, 2);
            B1.Name = "B1";
            B1.Size = new Size(155, 141);
            B1.TabIndex = 3;
            B1.UseVisualStyleBackColor = true;
            B1.Click += btn_Click;
            // 
            // A3
            // 
            A3.Dock = DockStyle.Fill;
            A3.FlatAppearance.BorderColor = Color.DimGray;
            A3.FlatAppearance.BorderSize = 0;
            A3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            A3.Location = new Point(325, 2);
            A3.Margin = new Padding(3, 2, 3, 2);
            A3.Name = "A3";
            A3.Size = new Size(156, 141);
            A3.TabIndex = 2;
            A3.UseVisualStyleBackColor = true;
            A3.Click += btn_Click;
            // 
            // A2
            // 
            A2.Dock = DockStyle.Fill;
            A2.FlatAppearance.BorderColor = Color.DimGray;
            A2.FlatAppearance.BorderSize = 0;
            A2.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            A2.Location = new Point(164, 2);
            A2.Margin = new Padding(3, 2, 3, 2);
            A2.Name = "A2";
            A2.Size = new Size(155, 141);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.Click += btn_Click;
            // 
            // A1
            // 
            A1.Dock = DockStyle.Fill;
            A1.FlatAppearance.BorderColor = Color.DimGray;
            A1.FlatAppearance.BorderSize = 0;
            A1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            A1.Location = new Point(3, 2);
            A1.Margin = new Padding(3, 2, 3, 2);
            A1.Name = "A1";
            A1.Size = new Size(155, 141);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private TableLayoutPanel btnPanel;
        private Button C3;
        private Button C2;
        private Button C1;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button A3;
        private Button A2;
        private Button A1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}