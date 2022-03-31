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
    public partial class Login : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string sqlquery = "select * from [employeedb]. [dbo].[registration] where emailid = @emailid and password = @password";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            sqlcomm.Parameters.AddWithValue("@emailid", email_id.Text);
            sqlcomm.Parameters.AddWithValue("@password", password.Text); 
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery(); 
            if (dt.Rows.Count > 0)
            {
                con.Close();
                MessageBox.Show("Login successful.");
                this.Hide(); 
                Search s = new Search();
                s.Show();
            }
            else
            {
                MessageBox.Show("Inavlid email or password");
                email_id.Text = ""; 
                password.Text = "";
                con.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }
    }
}
