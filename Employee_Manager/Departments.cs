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
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }
        private void ShowDepartments()
        {
            string Querry = "Select * from DepartmentTb1";
            BindingSource bs = new BindingSource();
            bs.DataSource = Con.GetData(Querry);
            DepList.DataSource = bs.DataSource;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int Key = 0;
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "update DepartmentTb1 set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (DepNameTb.Text == "")
            //    {
            //        MessageBox.Show("Missing Data!");
            //    }
            //    else
            //    {
            //        string Dep = DepNameTb.Text;
            //        string Query = "delete from DepartmentTb1 where DepId = {0}";
            //        Query = string.Format(Query, Key);
            //        Con.SetData(Query);
            //        ShowDepartments();
            //        MessageBox.Show("Department Delated!");
            //        DepNameTb.Text = "";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are You Sure Want To Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        string Query = "DELETE FROM SalaryTb1 WHERE Employee IN (SELECT EmpId FROM EmployeeTb1 WHERE EmpDep = {0})";
                        Query = string.Format(Query, Key);
                        Con.SetData(Query);

                        Query = "delete from EmployeeTb1 where EmpDep = {0}";
                        Query = string.Format(Query, Key);
                        Con.SetData(Query);

                        string Dep = DepNameTb.Text;
                        // Delete department
                        Query = "DELETE FROM DepartmentTb1 WHERE DepId = {0}";
                        Query = string.Format(Query, Key);
                        Con.SetData(Query);


                        ShowDepartments();
                        MessageBox.Show("Department Deleted!");
                        DepNameTb.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void SalaryLBl_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                
                ShowDepartments();
            }
            else
            {
                string query = "SELECT * FROM DepartmentTb1 WHERE DepName LIKE '%{0}%'";
                query = string.Format(query, searchText);
                BindingSource bs = new BindingSource();
                bs.DataSource = Con.GetData(query);
                DepList.DataSource = bs.DataSource;
            }
        }
    }
}
