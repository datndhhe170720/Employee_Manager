namespace Employee_Manager
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LoginBtn = new Button();
            ResetLbl = new Label();
            UNameTb = new TextBox();
            PasswordTb = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 1176);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(816, 322);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(330, 96);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(663, 566);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(682, 702);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(787, 46);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(397, 39);
            label4.TabIndex = 4;
            label4.Text = "Employees Manager System";
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(850, 807);
            LoginBtn.Margin = new Padding(5, 6, 5, 6);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(273, 64);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetLbl
            // 
            ResetLbl.AutoSize = true;
            ResetLbl.Font = new Font("Book Antiqua", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ResetLbl.Location = new Point(881, 886);
            ResetLbl.Margin = new Padding(5, 0, 5, 0);
            ResetLbl.Name = "ResetLbl";
            ResetLbl.Size = new Size(212, 32);
            ResetLbl.TabIndex = 7;
            ResetLbl.Text = "Reset Password";
            ResetLbl.Click += ResetLbl_Click;
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(816, 566);
            UNameTb.Margin = new Padding(5, 6, 5, 6);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(373, 35);
            UNameTb.TabIndex = 8;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(816, 694);
            PasswordTb.Margin = new Padding(5, 6, 5, 6);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(373, 35);
            PasswordTb.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 1176);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(ResetLbl);
            Controls.Add(LoginBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button LoginBtn;
        private Label ResetLbl;
        private TextBox UNameTb;
        private TextBox PasswordTb;
    }
}