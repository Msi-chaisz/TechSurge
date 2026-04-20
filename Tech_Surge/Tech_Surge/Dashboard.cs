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
        int seconds = 0;
        bool isRunning = false;
        public Dashboard()
        {
            InitializeComponent();



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (txtNote1.Text == "" || txtNote2.Text == "" || txtNote3.Text == "" || txtNote4.Text == "")
            {
                MessageBox.Show("Please enter a note!");
                return;
            }

            try
            {
                DBConnect db = new DBConnect();
                db.Open();

                string query = "INSERT INTO notez (note1, note2, note3, note4) VALUES (@n1, @n2, @n3, @n4)";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@n1", txtNote1.Text);
                cmd.Parameters.AddWithValue("@n2", txtNote2.Text);
                cmd.Parameters.AddWithValue("@n3", txtNote3.Text);
                cmd.Parameters.AddWithValue("@n4", txtNote4.Text);

                cmd.ExecuteNonQuery();

                db.Close();

                txtNote1.Clear();
                txtNote2.Clear();
                txtNote3.Clear();
                txtNote4.Clear();


                MessageBox.Show("Note saved to database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving note: " + ex.Message);
            }


        }


        private void btnAddCard_Click(object sender, EventArgs e)
        {

            FlashLoad();

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
        private void FlashLoad()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT ID, Questions, Answer FROM flashcard";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                dgvFlashCards.DataSource = table;

                dgvFlashCards.Columns["ID"].HeaderText = "ID";
                dgvFlashCards.Columns["Questions"].HeaderText = "Questions";
                dgvFlashCards.Columns["Answer"].HeaderText = "Answer";


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
            FlashcardTests flashcard = new FlashcardTests();
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

        private void btnRefFlash_Click(object sender, EventArgs e)
        {
            FlashLoad();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {


            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT note1, note2, note3, note4 FROM notez LIMIT 1";
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                // This line is Generated from Ai. To Load user notepad. Also due to time limit in developing

                if (reader.Read())
                {
                    txtNote1.Text = reader["note1"].ToString();
                    txtNote2.Text = reader["note2"].ToString();
                    txtNote3.Text = reader["note3"].ToString();
                    txtNote4.Text = reader["note4"].ToString();
                }

                reader.Close();
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isRunning = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            seconds++;

            int minutes = seconds / 60;
            int secs = seconds % 60;

            lblTimer.Text = $"{minutes:00} : {secs:00}";
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            seconds = 0;

            lblTimer.Text = "00:00";

        }
    }
}
