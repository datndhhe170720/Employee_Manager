namespace Employee_Manager
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            panel1 = new Panel();
            label1 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DailySalTb = new TextBox();
            label2 = new Label();
            label8 = new Label();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            DOBTb = new DateTimePicker();
            JDateTb = new DateTimePicker();
            AddBtn = new Button();
            UpdateBtn = new Button();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            EmployeeList = new DataGridView();
            DeleteBtn = new Button();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            FilterDepCb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1774, 175);
            panel1.TabIndex = 0;
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
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(253, 415);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(363, 42);
            EmpNameTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(58, 700);
            label4.Name = "label4";
            label4.Size = new Size(174, 36);
            label4.TabIndex = 13;
            label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(76, 610);
            label5.Name = "label5";
            label5.Size = new Size(156, 36);
            label5.TabIndex = 12;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(76, 887);
            label6.Name = "label6";
            label6.Size = new Size(156, 36);
            label6.TabIndex = 21;
            label6.Text = "Daily Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(109, 787);
            label7.Name = "label7";
            label7.Size = new Size(123, 36);
            label7.TabIndex = 20;
            label7.Text = "Join Date";
            // 
            // DailySalTb
            // 
            DailySalTb.Location = new Point(253, 885);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new Size(363, 42);
            DailySalTb.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(149, 421);
            label2.Name = "label2";
            label2.Size = new Size(83, 36);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Book Antiqua", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(204, 310);
            label8.Name = "label8";
            label8.Size = new Size(394, 46);
            label8.TabIndex = 23;
            label8.Text = "Employees Infomation";
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(253, 499);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(363, 43);
            GenCb.TabIndex = 24;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Location = new Point(253, 603);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(363, 43);
            DepCb.TabIndex = 25;
            DepCb.SelectedIndexChanged += DepCb_SelectedIndexChanged;
            // 
            // DOBTb
            // 
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Location = new Point(253, 700);
            DOBTb.Name = "DOBTb";
            DOBTb.Size = new Size(363, 42);
            DOBTb.TabIndex = 26;
            // 
            // JDateTb
            // 
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.Location = new Point(253, 787);
            JDateTb.MinDate = new DateTime(2023, 7, 22, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            JDateTb.Size = new Size(363, 42);
            JDateTb.TabIndex = 27;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(96, 978);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(225, 62);
            AddBtn.TabIndex = 28;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.PaleTurquoise;
            UpdateBtn.Location = new Point(423, 977);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(225, 63);
            UpdateBtn.TabIndex = 29;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1042, 219);
            label9.Name = "label9";
            label9.Size = new Size(142, 36);
            label9.TabIndex = 64;
            label9.Text = "Employees";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(936, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 63;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(699, 219);
            label10.Name = "label10";
            label10.Size = new Size(102, 36);
            label10.TabIndex = 62;
            label10.Text = "Salaries";
            label10.Click += label10_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(593, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1420, 219);
            label11.Name = "label11";
            label11.Size = new Size(110, 36);
            label11.TabIndex = 60;
            label11.Text = "Log Out";
            label11.Click += label11_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1314, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(292, 219);
            label12.Name = "label12";
            label12.Size = new Size(156, 36);
            label12.TabIndex = 58;
            label12.Text = "Department";
            label12.Click += label12_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 506);
            label3.Name = "label3";
            label3.Size = new Size(103, 36);
            label3.TabIndex = 65;
            label3.Text = "Gender";
            // 
            // EmployeeList
            // 
            EmployeeList.BackgroundColor = SystemColors.ControlLight;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeList.GridColor = SystemColors.MenuHighlight;
            EmployeeList.Location = new Point(683, 398);
            EmployeeList.Margin = new Padding(2);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.ReadOnly = true;
            EmployeeList.RowHeadersWidth = 72;
            EmployeeList.RowTemplate.Height = 25;
            EmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeList.Size = new Size(1062, 573);
            EmployeeList.TabIndex = 66;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.LightCoral;
            DeleteBtn.Location = new Point(1117, 984);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(225, 66);
            DeleteBtn.TabIndex = 68;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(1278, 330);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(321, 42);
            SearchTextBox.TabIndex = 69;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1605, 330);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(140, 42);
            SearchButton.TabIndex = 70;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // FilterDepCb
            // 
            FilterDepCb.FormattingEnabled = true;
            FilterDepCb.Location = new Point(969, 329);
            FilterDepCb.Name = "FilterDepCb";
            FilterDepCb.Size = new Size(303, 43);
            FilterDepCb.TabIndex = 71;
            FilterDepCb.Text = "Filter by Department";
            FilterDepCb.SelectedIndexChanged += FilterDepCb_SelectedIndexChanged;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(17F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1063);
            Controls.Add(FilterDepCb);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(DeleteBtn);
            Controls.Add(EmployeeList);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(DailySalTb);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(EmpNameTb);
            Controls.Add(panel1);
            Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Employees";
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox DailySalTb;
        private Label label2;
        private Label label8;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private DateTimePicker DOBTb;
        private DateTimePicker JDateTb;
        private Button AddBtn;
        private Button UpdateBtn;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label10;
        private PictureBox pictureBox3;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label12;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridView EmployeeList;
        private Button DeleteBtn;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private ComboBox FilterDepCb;
    }
}