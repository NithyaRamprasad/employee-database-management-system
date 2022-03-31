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
    public partial class Department : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static string dept_id_old;
        public Department()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            sqlCon.Open();
            string q = "Select * from department";
            SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            dept_grid.DataSource = dtbl;
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

        private void Department_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mod_dept_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update department set dept_id='" + dept_id_txt.Text + "', comp_id='" + comp_id_txt.Text + "', dept_name='" + dept_name_txt.Text + "' where dept_id='" + dept_id_old + "';";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Updated Successfully.");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't update.");
            }
        }

        private void del_dept_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from department where dept_id='" + dept_id_old + "';";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Deleted Successfully.");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't delete.");
            }
        }

        private void dept_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dept_id_txt.Text = dept_grid.SelectedRows[0].Cells[0].Value.ToString();
                comp_id_txt.Text = dept_grid.SelectedRows[0].Cells[1].Value.ToString();
                dept_name_txt.Text = dept_grid.SelectedRows[0].Cells[2].Value.ToString();
                dept_id_old = dept_grid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void add_dept_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Department ad = new Add_Department();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
