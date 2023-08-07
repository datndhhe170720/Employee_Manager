namespace Employee_Manager
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            DepList = new DataGridView();
            EditBtn = new Button();
            AddBtn = new Button();
            label8 = new Label();
            label2 = new Label();
            DepNameTb = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            SalaryLBl = new Label();
            pictureBox3 = new PictureBox();
            EmpLbl = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            DeleteBtn = new Button();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DepList
            // 
            DepList.BackgroundColor = SystemColors.ControlLight;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepList.GridColor = SystemColors.MenuHighlight;
            DepList.Location = new Point(758, 402);
            DepList.Margin = new Padding(3, 4, 3, 4);
            DepList.Name = "DepList";
            DepList.ReadOnly = true;
            DepList.RowHeadersWidth = 72;
            DepList.RowTemplate.Height = 25;
            DepList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DepList.Size = new Size(933, 628);
            DepList.TabIndex = 47;
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PaleTurquoise;
            EditBtn.Location = new Point(401, 564);
            EditBtn.Margin = new Padding(3, 4, 3, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(225, 62);
            EditBtn.TabIndex = 46;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(86, 564);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(225, 62);
            AddBtn.TabIndex = 45;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Book Antiqua", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(163, 324);
            label8.Name = "label8";
            label8.Size = new Size(428, 46);
            label8.TabIndex = 40;
            label8.Text = "Departments Infomation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 452);
            label2.Name = "label2";
            label2.Size = new Size(83, 36);
            label2.TabIndex = 39;
            label2.Text = "Name";
            // 
            // DepNameTb
            // 
            DepNameTb.Location = new Point(264, 446);
            DepNameTb.Margin = new Padding(3, 4, 3, 4);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(362, 35);
            DepNameTb.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(566, 72);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1774, 176);
            panel1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Book Antiqua", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(758, 324);
            label3.Name = "label3";
            label3.Size = new Size(307, 46);
            label3.TabIndex = 48;
            label3.Text = "Departments List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1426, 220);
            label5.Name = "label5";
            label5.Size = new Size(110, 36);
            label5.TabIndex = 52;
            label5.Text = "Log Out";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1322, 220);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // SalaryLBl
            // 
            SalaryLBl.AutoSize = true;
            SalaryLBl.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryLBl.Location = new Point(706, 220);
            SalaryLBl.Name = "SalaryLBl";
            SalaryLBl.Size = new Size(102, 36);
            SalaryLBl.TabIndex = 54;
            SalaryLBl.Text = "Salaries";
            SalaryLBl.Click += SalaryLBl_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(600, 220);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpLbl.Location = new Point(1049, 220);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(142, 36);
            EmpLbl.TabIndex = 56;
            EmpLbl.Text = "Employees";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(943, 220);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(99, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 220);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(298, 220);
            label4.Name = "label4";
            label4.Size = new Size(156, 36);
            label4.TabIndex = 50;
            label4.Text = "Department";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.LightCoral;
            DeleteBtn.Location = new Point(225, 664);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(225, 66);
            DeleteBtn.TabIndex = 57;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(1322, 337);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(230, 35);
            SearchTextBox.TabIndex = 59;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1560, 335);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(131, 40);
            SearchButton.TabIndex = 60;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1100);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(DeleteBtn);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox4);
            Controls.Add(SalaryLBl);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(DepList);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(DepNameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            Load += Departments_Load;
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DepList;
        private Button EditBtn;
        private Button AddBtn;
        private Label label8;
        private Label label2;
        private TextBox DepNameTb;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox2;
        private Label SalaryLBl;
        private PictureBox pictureBox3;
        private Label EmpLbl;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label4;
        private Button DeleteBtn;
        private TextBox SearchTextBox;
        private Button SearchButton;
    }
}