using MySql.Data.MySqlClient;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (txtNotes.Text == "")
            {
                MessageBox.Show("Please enter a note!");
                return;
            }
            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "INSERT INTO notes (content) VALUES (@content)";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@content", txtNotes.Text);

                cmd.ExecuteNonQuery();

                db.Close();
                txtNotes.Clear();



                MessageBox.Show("Note saved to database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving note: " + ex.Message);
            }
        }


        private void btnAddCard_Click(object sender, EventArgs e)
        {

            {

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            {


            }

        }

        private void stAnnoucements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stAnnoucements.Items.Add("Exam next week");
            stAnnoucements.Items.Add("No classes on Friday");


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string notes = rtxtInfoTask.Text.Trim();
            string date = dtTask.Value.ToString("yyyy-MM-dd");


            if (string.IsNullOrEmpty(notes))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "INSERT INTO notepad (Date, Note) " + "VALUES (@date, @note)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@note", notes);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Schedule Successfully!");
                txtNotes.Clear();
                rtxtInfoTask.Clear();
                NoteLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }

        }

        private void NoteLoad()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT Date, Note FROM notepad";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                dgvTaskAnnouce.DataSource = table;

     
                dgvTaskAnnouce.Columns["Date"].HeaderText = "Date";
                dgvTaskAnnouce.Columns["Note"].HeaderText = "Note to Remember";

                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID;
            string information = rtxtInfoTask.Text.Trim();

            if (!int.TryParse(txtTitle.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Click Note to Update!");
                return;
            }

            if (string.IsNullOrEmpty(information))
            {
                MessageBox.Show("Please Fill Note to Update!");
                return;

            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"UPDATE students SET Date=@date, Note=@note  WHERE id=@id";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("Date", dtTask);
                    cmd.Parameters.AddWithValue("Note", rtxtInfoTask);
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Update Successfully!");

                rtxtInfoTask.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog file = new OpenFileDialog();

                file.Title = "Select Assignment File";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    string fileName = System.IO.Path.GetFileName(file.FileName);
                    string filePath = file.FileName;
                    DBConnect db = new DBConnect();
                    db.Open();

                    string query = "INSERT INTO assignments (filename, filepath) VALUES (@name, @path)";
                    MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                    cmd.Parameters.AddWithValue("@name", fileName);
                    cmd.Parameters.AddWithValue("@path", filePath);

                    cmd.ExecuteNonQuery();

                    db.Close();

                    lblFile.Text = fileName;

                    MessageBox.Show("Assignment Submitted!");
                }
            }

        }
    }
}
