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
    public partial class Company : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static string comp_id_old;
        public Company()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            sqlCon.Open();
            string q = "Select * from company1";
            SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            comp_grid.DataSource = dtbl;
        }

        private void proj_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project d = new Project();
            d.Show();
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search();
            s.Show();
        }

        private void comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company c = new Company();
            c.Show();
        }

        private void dept_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department dept = new Department();
            dept.Show();
        }

        private void Company_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comp_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Company_Load(object sender, EventArgs e)
        {
            
        }

        private void del_comp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from company1 where comp_id='" + comp_id_old + "';";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Deleted Successfully.");
                loadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't delete.");
            }
        }

        private void comp_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                comp_id_txt.Text = comp_grid.SelectedRows[0].Cells[0].Value.ToString();
                comp_name_txt.Text = comp_grid.SelectedRows[0].Cells[1].Value.ToString();
                cont_no_txt.Text = comp_grid.SelectedRows[0].Cells[2].Value.ToString();
                comp_addr_txt.Text = comp_grid.SelectedRows[0].Cells[3].Value.ToString();
                comp_id_old= comp_grid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void mod_comp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update company1 set comp_id='" + comp_id_txt.Text + "', comp_name='"+comp_name_txt.Text+"', contact_no="+Convert.ToInt32(cont_no_txt.Text)+", comp_address='"+comp_addr_txt.Text+"' where comp_id='"+comp_id_old+"';";
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

        private void add_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Company ac = new Add_Company();
            ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
