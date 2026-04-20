using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_Surge
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please input your credentials!");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM login WHERE Username=@username AND Password=@password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                if (count == 1)
                {
                    MessageBox.Show("Welcome Student!");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errors In:" + ex);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Registration register = new Registration();
            register.Show();

            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
