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
    public partial class Add_Department : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public Add_Department()
        {
            InitializeComponent();
        }

        private void save_comp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into department values('" + dept_id_txt.Text + "','" + comp_id_txt.Text + "','" + dept_name_txt.Text + "');";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Data Added Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't insert data.");
                this.Hide();
                Department d = new Department();
                d.Show();
            }
        }

        private void cancel_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department d = new Department();
            d.Show();
        }

        private void Add_Department_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dept_id_txt.Text = "";
            comp_id_txt.Text = "";
            dept_name_txt.Text = "";
        }
    }
}
