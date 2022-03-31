using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Project : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static string proj_id_old;
        public Project()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            sqlCon.Open();
            string q = "Select * from project1";
            SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            proj_grid.DataSource = dtbl;
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project d = new Project();
            d.Show();
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

        private void Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proj_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project d = new Project();
            d.Show();
        }

        private void mod_proj_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update project1 set project_id='" + proj_id_txt.Text + "', project_name='" + proj_name_txt.Text + "', duration=" + Convert.ToInt32(duration_txt.Text) +" where project_id='" + proj_id_old + "';";
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

        private void proj_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                proj_id_txt.Text = proj_grid.SelectedRows[0].Cells[0].Value.ToString();
                proj_name_txt.Text = proj_grid.SelectedRows[0].Cells[1].Value.ToString();
                duration_txt.Text = proj_grid.SelectedRows[0].Cells[2].Value.ToString();
                proj_id_old = proj_grid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void del_proj_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from project1 where project_id='" + proj_id_old + "';";
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

        private void add_proj_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Project ap = new Add_Project();
            ap.Show();
        }

        private void proj_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
