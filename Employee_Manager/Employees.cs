using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }

        private void ShowEmp()
        {
            string Querry = "Select * from EmployeeTb1";
            BindingSource bs = new BindingSource();
            bs.DataSource = Con.GetData(Querry);
            EmployeeList.DataSource = bs.DataSource;
        }

        private void GetDepartment()
        {
            string Querry = "select * from DepartmentTb1";
            DepCb.DisplayMember = Con.GetData(Querry).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Querry).Columns["DepId"].ToString();
            DepCb.DataSource = Con.GetData(Querry);
            FilterDepCb.DisplayMember = Con.GetData(Querry).Columns["DepName"].ToString();
            FilterDepCb.ValueMember = Con.GetData(Querry).Columns["DepId"].ToString();
            FilterDepCb.DataSource = Con.GetData(Querry);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.Date.ToString();
                    string JDate = JDateTb.Value.Date.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "insert into EmployeeTb1 values('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Query = "delete from EmployeeTb1 where EmpId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.Date.ToString();
                    string JDate = JDateTb.Value.Date.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "update EmployeeTb1 set EmpName ='{0}',EmpGen = '{1}',EmpDep = {2},EmpDOB = '{3}',EmpJDate = '{4}',EmpSal = {5} where EmpId = {6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Updated!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = SearchTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    string query = "SELECT * FROM EmployeeTb1 WHERE EmpName LIKE '%{0}%'";
                    query = string.Format(query, searchTerm);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = Con.GetData(query);
                    EmployeeList.DataSource = bs.DataSource;
                }
                else
                {
                    ShowEmp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilterDepCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedDepartmentId = Convert.ToInt32(FilterDepCb.SelectedValue);

                if (selectedDepartmentId > 0) // Assuming department IDs start from 1
                {
                    string query = "SELECT * FROM EmployeeTb1 WHERE EmpDep = {0}";
                    query = string.Format(query, selectedDepartmentId);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = Con.GetData(query);
                    EmployeeList.DataSource = bs.DataSource;
                }
                else
                {
                    // If no department is selected (index 0), show all employees
                    ShowEmp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
