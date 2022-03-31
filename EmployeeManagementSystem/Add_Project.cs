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
    public partial class Add_Project : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public Add_Project()
        {
            InitializeComponent();
        }

        private void cancel_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project p = new Project();
            p.Show();
        }

        private void save_comp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into project1 values('" + proj_id_txt.Text + "','" + proj_name_txt.Text + "'," + Convert.ToInt32(duration_txt.Text) + ");";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Data Added Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't insert data.");
                this.Hide();
                Project p = new Project();
                p.Show();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            proj_id_txt.Text = "";
            proj_name_txt.Text = "";
            duration_txt.Text = "";
        }

        private void Add_Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
