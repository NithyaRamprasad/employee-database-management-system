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
    public partial class ForgotPassword : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-8133IL6;Initial Catalog=employeedb;Integrated Security=True";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (email_id.Text == "" || password.Text == "")
                {
                    throw new Exception("Invalid input");
                }
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update registration set password='" + password.Text + "' where emailid='" + email_id.Text + "';";
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = sqlCon.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from [employeedb].[dbo].[registration] where password='" + password.Text + "' and emailid='" + email_id.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd1.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Reset successful!");
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("Inavlid email or password");
                }
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
