using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

           string questions = rtxtQuestions.Text.Trim();
           string answer = txtAnswer.Text.Trim();



            if (string.IsNullOrEmpty(questions) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "INSERT INTO flashcard (Questions, Answer) " + "VALUES (@questions, @answer)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@questions", questions);
                cmd.Parameters.AddWithValue("@answer", answer);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Flashcard Added Successfully!");

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



        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string notes = rtxtInfoTask.Text.Trim();
            DateTime date = dtTask.Value;


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
                string query = "SELECT ID, Date, Note FROM notepad";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                dgvTaskAnnouce.DataSource = table;

                dgvTaskAnnouce.Columns["ID"].HeaderText = "ID";
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
                string query = @"UPDATE notepad SET Date=@date, Note=@note  WHERE ID=@id";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@date", dtTask.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@note", information);
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Update Successfully!");

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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog file = new OpenFileDialog();

                file.Title = "Select Assignment Fields";

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
                    MessageBox.Show("Assignment Submitted!");


                }


            }

        }

        private void UploadLoad()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT ID, filename, filepath FROM assignments";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                dgvFolder.DataSource = table;

                dgvFolder.Columns["ID"].HeaderText = "ID";
                dgvFolder.Columns["filename"].HeaderText = "File Folder";
                dgvFolder.Columns["filepath"].HeaderText = "Saved At";


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
        private void btnShow_Click(object sender, EventArgs e)
        {
            NoteLoad();
        }

        private void dgvTaskAnnouce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaskAnnouce.Rows[e.RowIndex];

                txtTitle.Text = row.Cells["ID"].Value.ToString();
                dtTask.Text = row.Cells["Date"].Value.ToString();
                rtxtInfoTask.Text = row.Cells["Note"].Value.ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_MouseClick(object sender, MouseEventArgs e)
        {
            int ID;

            if (!int.TryParse(txtTitle.Text, out ID))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "DELETE FROM notepad WHERE ID=@id";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Deleted Notes Successfully!");
                rtxtInfoTask.Clear();
                txtTitle.Clear();

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

        private void stNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            FlashcardTest flashcard = new FlashcardTest();
            flashcard.Show();
            this.Hide();
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UploadLoad();
        }

        private void lblFile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
