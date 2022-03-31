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
    public partial class Add_Company : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public Add_Company()
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
                cmd.CommandText = "insert into company1 values('" + comp_id_txt.Text + "','" + comp_name_txt.Text + "'," + Convert.ToInt32(cont_no_txt.Text) + ",'" + comp_addr_txt.Text + "');";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Data Added Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!Couldn't insert data.");
                this.Hide();
                Company c = new Company();
                c.Show();
            }
        }

        private void cancel_comp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company c = new Company();
            c.Show();
        }

        private void Add_Company_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            comp_id_txt.Text = "";
            comp_name_txt.Text = "";
            cont_no_txt.Text = "";
            comp_addr_txt.Text = "";
        }
    }
}
