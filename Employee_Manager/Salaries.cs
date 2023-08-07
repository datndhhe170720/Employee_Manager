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
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }

        private void GetEmployees()
        {
            string Querry = "select * from EmployeeTb1";
            EmpCb.DisplayMember = Con.GetData(Querry).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Querry).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Querry);
        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Querry = "select EmpSal from EmployeeTb1 where EmpId = {0}";
            Querry = string.Format(Querry, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Querry).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            //MessageBox.Show("" + DSal);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "$ " + (d * DSal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days cannot be greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "$ " + (d * DSal);
            }
        }

        private void ShowSalaries()
        {
            string Querry = "Select * from SalaryTb1";
            BindingSource bs = new BindingSource();
            bs.DataSource = Con.GetData(Querry);
            SalaryList.DataSource = bs.DataSource;
        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int d = 1;
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);

                    string Query = "insert into SalaryTb1 values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid!");
                    DaysTb.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }
    }
}
