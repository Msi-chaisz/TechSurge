using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Tech_Surge
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.Load += RegisterStudent_Load;


        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            cbSection.Items.AddRange(new string[] { "College", "SHS" });
            cbSection.SelectedIndex = -1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtFirstName.Text.Trim();
            int studentID;
            string section = cbSection.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill up all the fiekds");
            }
            if (!int.TryParse(txtStudentID.Text.Trim(), out studentID))
            {
                MessageBox.Show("Please enter a valid student ID!");
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "INSERT INTO login (Username, Password, firstname, lastname, section, studentID)" + "VALUES (@username, @password, @firstname, @lastname, @section, @studentID)";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("studentID", studentID);
                cmd.Parameters.AddWithValue("@section", section);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Added Successfully!");

                txtFirstName.Clear();
                txtlastName.Clear();
                cbSection.SelectedIndex = -1;
                txtStudentID.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                db.Close();
            }

        }
    }
}
