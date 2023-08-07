namespace Employee_Manager
{
    partial class Salaries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            Addbtn = new Button();
            PeriodTb = new DateTimePicker();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
            DaysTb = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            LogoutLbl = new Label();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            SalaryList = new DataGridView();
            EmpCb = new ComboBox();
            AmountTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Turquoise;
            Addbtn.Location = new Point(221, 745);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(225, 69);
            Addbtn.TabIndex = 45;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // PeriodTb
            // 
            PeriodTb.Location = new Point(287, 564);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.Size = new Size(363, 35);
            PeriodTb.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Book Antiqua", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(129, 300);
            label8.Name = "label8";
            label8.Size = new Size(340, 46);
            label8.TabIndex = 40;
            label8.Text = "Salaries Infomation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 394);
            label2.Name = "label2";
            label2.Size = new Size(207, 36);
            label2.TabIndex = 39;
            label2.Text = "Employee Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 483);
            label6.Name = "label6";
            label6.Size = new Size(189, 36);
            label6.TabIndex = 38;
            label6.Text = "Days Attended";
            // 
            // DaysTb
            // 
            DaysTb.Location = new Point(287, 483);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(363, 35);
            DaysTb.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 578);
            label4.Name = "label4";
            label4.Size = new Size(93, 36);
            label4.TabIndex = 35;
            label4.Text = "Period";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(565, 71);
            label1.Name = "label1";
            label1.Size = new Size(596, 58);
            label1.TabIndex = 1;
            label1.Text = "Employee Manager System";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1774, 175);
            panel1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 650);
            label3.Name = "label3";
            label3.Size = new Size(191, 36);
            label3.TabIndex = 48;
            label3.Text = "Salary Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1040, 222);
            label7.Name = "label7";
            label7.Size = new Size(142, 36);
            label7.TabIndex = 64;
            label7.Text = "Employees";
            label7.Click += label7_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(934, 222);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 63;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(697, 222);
            label5.Name = "label5";
            label5.Size = new Size(102, 36);
            label5.TabIndex = 62;
            label5.Text = "Salaries";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(591, 222);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLbl.Location = new Point(1418, 222);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(110, 36);
            LogoutLbl.TabIndex = 60;
            LogoutLbl.Text = "Log Out";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1312, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(290, 222);
            label10.Name = "label10";
            label10.Size = new Size(156, 36);
            label10.TabIndex = 58;
            label10.Text = "Department";
            label10.Click += label10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(184, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // SalaryList
            // 
            SalaryList.BackgroundColor = SystemColors.ControlLight;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryList.GridColor = SystemColors.MenuHighlight;
            SalaryList.Location = new Point(685, 374);
            SalaryList.Margin = new Padding(2);
            SalaryList.Name = "SalaryList";
            SalaryList.ReadOnly = true;
            SalaryList.RowHeadersWidth = 72;
            SalaryList.RowTemplate.Height = 25;
            SalaryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryList.Size = new Size(1062, 573);
            SalaryList.TabIndex = 67;
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // EmpCb
            // 
            EmpCb.FormattingEnabled = true;
            EmpCb.Location = new Point(290, 395);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new Size(360, 38);
            EmpCb.TabIndex = 68;
            EmpCb.SelectionChangeCommitted += EmpCb_SelectionChangeCommitted;
            // 
            // AmountTb
            // 
            AmountTb.ForeColor = SystemColors.MenuHighlight;
            AmountTb.Location = new Point(287, 651);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(363, 35);
            AmountTb.TabIndex = 69;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1063);
            Controls.Add(AmountTb);
            Controls.Add(EmpCb);
            Controls.Add(SalaryList);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(LogoutLbl);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Addbtn);
            Controls.Add(PeriodTb);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(DaysTb);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Addbtn;
        private DateTimePicker PeriodTb;
        private Label label8;
        private Label label2;
        private Label label6;
        private TextBox DaysTb;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label5;
        private PictureBox pictureBox3;
        private Label LogoutLbl;
        private PictureBox pictureBox2;
        private Label label10;
        private PictureBox pictureBox1;
        private DataGridView SalaryList;
        private ComboBox EmpCb;
        private TextBox AmountTb;
    }
}