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
    public partial class FlashcardTests : Form
    {
        string currentAnswer = "";
        public FlashcardTests()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (txtAnswer.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter answer!");
                    return;
                }

                if (txtAnswer.Text.Trim().ToLower() == currentAnswer.ToLower())
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Wrong! Correct answer is: " + currentAnswer);
                }

                txtAnswer.Clear();

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DBConnect db = new DBConnect();
                    db.Open();

                    string query = "SELECT * FROM questionz ORDER BY RAND() LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //This is AI Generated. Due to developers limit knowledge within this field

                    if (reader.Read())
                    {
                        lblQuestion.Text = reader["question"].ToString();
                        currentAnswer = reader["answer"].ToString();
                    }

                    db.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void question_Load(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
}
