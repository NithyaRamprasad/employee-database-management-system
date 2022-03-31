using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Employee : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static string emp_id_old;
        public Employee()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            sqlCon.Open();
            string q = "Select e.emp_id,e.dept_id,e.emp_name,e.emp_dob,e.emp_doj,e.emp_address,e.gender,e.emp_mobile,e.project_id,s.salary_id,s.bonus,s.annual,s.total_salary from employee e join salary s on e.emp_id=s.emp_id";
            SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            emp_grid.DataSource = dtbl;
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }

        private void dept_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department dept = new Department();
            dept.Show();
        }

        private void comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company c = new Company();
            c.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search();
            s.Show();
        }

        

        private void proj_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project d = new Project();
            d.Show();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mod_emp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update employee set emp_id='" + emp_id_txt.Text + "', dept_id='" + dept_id_txt.Text +"',emp_name='"+emp_name_txt.Text+"',emp_address='"+emp_addr_txt.Text+"',gender='"+gender_txt.Text+"', emp_mobile=" + Convert.ToInt32(emp_mobile_txt.Text) + " where emp_id='" + emp_id_old + "';";
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update salary set salary_id='" + salary_id_txt.Text + "', emp_id='" + emp_id_txt.Text +"', bonus=" + Convert.ToInt32(bonus_txt.Text) + ", annual=" + Convert.ToInt32(annual_txt.Text) + " where emp_id='" + emp_id_old + "';";
                cmd1.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Updated Successfully.");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't update.");
            }
        }

        private void emp_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                emp_id_txt.Text = emp_grid.SelectedRows[0].Cells[0].Value.ToString();
                dept_id_txt.Text = emp_grid.SelectedRows[0].Cells[1].Value.ToString();
                emp_name_txt.Text = emp_grid.SelectedRows[0].Cells[2].Value.ToString();
                emp_dob_txt.Text = emp_grid.SelectedRows[0].Cells[3].Value.ToString();
                emp_doj_txt.Text = emp_grid.SelectedRows[0].Cells[4].Value.ToString();
                emp_addr_txt.Text = emp_grid.SelectedRows[0].Cells[5].Value.ToString();
                gender_txt.Text = emp_grid.SelectedRows[0].Cells[6].Value.ToString();
                emp_mobile_txt.Text = emp_grid.SelectedRows[0].Cells[7].Value.ToString();
                proj_id_txt.Text = emp_grid.SelectedRows[0].Cells[8].Value.ToString();
                salary_id_txt.Text = emp_grid.SelectedRows[0].Cells[9].Value.ToString();
                bonus_txt.Text = emp_grid.SelectedRows[0].Cells[10].Value.ToString();
                annual_txt.Text = emp_grid.SelectedRows[0].Cells[11].Value.ToString();
                total_sal_txt.Text = emp_grid.SelectedRows[0].Cells[12].Value.ToString();
                emp_id_old = emp_grid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void add_emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee ae = new Add_Employee();
            ae.Show();
        }

        private void del_emp_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
                sqlCon.Open();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "delete from salary where emp_id='" + emp_id_old + "';";
                cmd1.ExecuteNonQuery();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from employee where emp_id='" + emp_id_old + "';";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Deleted Successfully.");
                loadData();
            //}
            /*catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't delete.");
            }*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
