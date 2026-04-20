namespace Tech_Surge
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLoad = new Button();
            txtNote4 = new RichTextBox();
            txtNote3 = new RichTextBox();
            txtNote2 = new RichTextBox();
            btnSaveNote = new Button();
            txtNote1 = new TextBox();
            tabPage2 = new TabPage();
            label10 = new Label();
            btnRefFlash = new Button();
            btnTest = new Button();
            dgvFlashCards = new DataGridView();
            rtxtQuestions = new RichTextBox();
            btnAddCard = new Button();
            txtAnswer = new TextBox();
            tabPage3 = new TabPage();
            btnShow = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtTitle = new TextBox();
            rtxtInfoTask = new RichTextBox();
            dgvTaskAnnouce = new DataGridView();
            btnAddTask = new Button();
            dtTask = new DateTimePicker();
            tabPage4 = new TabPage();
            label9 = new Label();
            label1 = new Label();
            btnRefresh = new Button();
            dgvFolder = new DataGridView();
            btnUpload = new Button();
            tabPage5 = new TabPage();
            panel3 = new Panel();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            btnStart = new Button();
            lblTimer = new Label();
            btnReset = new Button();
            panel1 = new Panel();
            lblTime = new Label();
            tabPage6 = new TabPage();
            textBox3 = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            btnUpdateAcc = new Button();
            label8 = new Label();
            label5 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            btnHome = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlashCards).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskAnnouce).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFolder).BeginInit();
            tabPage5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tabPage6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1110, 598);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnLoad);
            tabPage1.Controls.Add(txtNote4);
            tabPage1.Controls.Add(txtNote3);
            tabPage1.Controls.Add(txtNote2);
            tabPage1.Controls.Add(btnSaveNote);
            tabPage1.Controls.Add(txtNote1);
            tabPage1.ForeColor = Color.White;
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1102, 569);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Note";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Brown;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(949, 38);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(129, 30);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtNote4
            // 
            txtNote4.Location = new Point(31, 430);
            txtNote4.Name = "txtNote4";
            txtNote4.Size = new Size(1047, 100);
            txtNote4.TabIndex = 5;
            txtNote4.Text = "";
            // 
            // txtNote3
            // 
            txtNote3.Location = new Point(345, 74);
            txtNote3.Name = "txtNote3";
            txtNote3.Size = new Size(733, 350);
            txtNote3.TabIndex = 4;
            txtNote3.Text = "";
            // 
            // txtNote2
            // 
            txtNote2.Location = new Point(31, 74);
            txtNote2.Name = "txtNote2";
            txtNote2.Size = new Size(308, 350);
            txtNote2.TabIndex = 3;
            txtNote2.Text = "";
            // 
            // btnSaveNote
            // 
            btnSaveNote.BackColor = Color.OliveDrab;
            btnSaveNote.FlatAppearance.BorderSize = 0;
            btnSaveNote.FlatStyle = FlatStyle.Flat;
            btnSaveNote.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveNote.ForeColor = Color.White;
            btnSaveNote.Location = new Point(833, 38);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(110, 31);
            btnSaveNote.TabIndex = 1;
            btnSaveNote.Text = "Save Note";
            btnSaveNote.UseVisualStyleBackColor = false;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // txtNote1
            // 
            txtNote1.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNote1.Location = new Point(31, 38);
            txtNote1.Name = "txtNote1";
            txtNote1.PlaceholderText = "Note Title";
            txtNote1.Size = new Size(796, 30);
            txtNote1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(btnRefFlash);
            tabPage2.Controls.Add(btnTest);
            tabPage2.Controls.Add(dgvFlashCards);
            tabPage2.Controls.Add(rtxtQuestions);
            tabPage2.Controls.Add(btnAddCard);
            tabPage2.Controls.Add(txtAnswer);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1102, 569);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Flash Cards";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(910, 29);
            label10.Name = "label10";
            label10.Size = new Size(145, 16);
            label10.TabIndex = 8;
            label10.Text = "SHOW CREATED CARDS";
            // 
            // btnRefFlash
            // 
            btnRefFlash.BackColor = Color.Transparent;
            btnRefFlash.FlatAppearance.BorderSize = 0;
            btnRefFlash.FlatStyle = FlatStyle.Flat;
            btnRefFlash.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefFlash.ForeColor = Color.Black;
            btnRefFlash.Location = new Point(1050, 21);
            btnRefFlash.Name = "btnRefFlash";
            btnRefFlash.Size = new Size(46, 32);
            btnRefFlash.TabIndex = 7;
            btnRefFlash.Text = " ⟳";
            btnRefFlash.UseVisualStyleBackColor = false;
            btnRefFlash.Click += btnRefFlash_Click;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.OliveDrab;
            btnTest.FlatAppearance.BorderSize = 0;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.ForeColor = Color.White;
            btnTest.Location = new Point(695, 520);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(51, 28);
            btnTest.TabIndex = 6;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // dgvFlashCards
            // 
            dgvFlashCards.BackgroundColor = Color.OliveDrab;
            dgvFlashCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlashCards.Location = new Point(796, 59);
            dgvFlashCards.Name = "dgvFlashCards";
            dgvFlashCards.Size = new Size(288, 489);
            dgvFlashCards.TabIndex = 5;
            // 
            // rtxtQuestions
            // 
            rtxtQuestions.Location = new Point(32, 59);
            rtxtQuestions.Name = "rtxtQuestions";
            rtxtQuestions.Size = new Size(758, 422);
            rtxtQuestions.TabIndex = 4;
            rtxtQuestions.Text = "";
            // 
            // btnAddCard
            // 
            btnAddCard.BackColor = Color.Brown;
            btnAddCard.FlatAppearance.BorderSize = 0;
            btnAddCard.FlatStyle = FlatStyle.Flat;
            btnAddCard.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCard.ForeColor = Color.White;
            btnAddCard.Location = new Point(752, 520);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(38, 28);
            btnAddCard.TabIndex = 2;
            btnAddCard.Text = "✚";
            btnAddCard.UseVisualStyleBackColor = false;
            btnAddCard.Click += btnAddCard_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(32, 487);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.PlaceholderText = "Answer";
            txtAnswer.Size = new Size(758, 27);
            txtAnswer.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Transparent;
            tabPage3.Controls.Add(btnShow);
            tabPage3.Controls.Add(btnDelete);
            tabPage3.Controls.Add(btnUpdate);
            tabPage3.Controls.Add(txtTitle);
            tabPage3.Controls.Add(rtxtInfoTask);
            tabPage3.Controls.Add(dgvTaskAnnouce);
            tabPage3.Controls.Add(btnAddTask);
            tabPage3.Controls.Add(dtTask);
            tabPage3.Location = new Point(4, 25);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1102, 569);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Personal Calendar";
            tabPage3.Click += tabPage3_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Transparent;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(1030, 16);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(71, 33);
            btnShow.TabIndex = 9;
            btnShow.Text = " ⟳ ";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(63, 449);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button1_Click;
            btnDelete.MouseClick += btnDelete_MouseClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Brown;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(63, 407);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Task";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(63, 106);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title Text";
            txtTitle.Size = new Size(209, 27);
            txtTitle.TabIndex = 6;
            // 
            // rtxtInfoTask
            // 
            rtxtInfoTask.Location = new Point(63, 139);
            rtxtInfoTask.Name = "rtxtInfoTask";
            rtxtInfoTask.Size = new Size(209, 217);
            rtxtInfoTask.TabIndex = 5;
            rtxtInfoTask.Text = "";
            // 
            // dgvTaskAnnouce
            // 
            dgvTaskAnnouce.BackgroundColor = Color.OliveDrab;
            dgvTaskAnnouce.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaskAnnouce.Location = new Point(320, 55);
            dgvTaskAnnouce.Name = "dgvTaskAnnouce";
            dgvTaskAnnouce.Size = new Size(761, 492);
            dgvTaskAnnouce.TabIndex = 4;
            dgvTaskAnnouce.CellContentClick += dgvTaskAnnouce_CellContentClick;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Brown;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(63, 362);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(209, 39);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtTask
            // 
            dtTask.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtTask.Location = new Point(63, 74);
            dtTask.Name = "dtTask";
            dtTask.Size = new Size(209, 26);
            dtTask.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Transparent;
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(btnRefresh);
            tabPage4.Controls.Add(dgvFolder);
            tabPage4.Controls.Add(btnUpload);
            tabPage4.ForeColor = Color.Black;
            tabPage4.Location = new Point(4, 25);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1102, 569);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Assignments";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(638, 44);
            label9.Name = "label9";
            label9.Size = new Size(317, 16);
            label9.TabIndex = 5;
            label9.Text = "and can be easily accessed or retrieved when needed.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(638, 28);
            label1.Name = "label1";
            label1.Size = new Size(444, 16);
            label1.TabIndex = 4;
            label1.Text = "Upload a file that can be downloaded later. Ensure the file is stored securely";
            label1.Click += label1_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Brown;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(151, 28);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "SHOW";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvFolder
            // 
            dgvFolder.BackgroundColor = Color.OliveDrab;
            dgvFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFolder.GridColor = Color.OliveDrab;
            dgvFolder.Location = new Point(40, 83);
            dgvFolder.Name = "dgvFolder";
            dgvFolder.Size = new Size(1042, 459);
            dgvFolder.TabIndex = 2;
            // 
            // btnUpload
            // 
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.Black;
            btnUpload.Location = new Point(40, 28);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(105, 35);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Controls.Add(panel3);
            tabPage5.Controls.Add(pictureBox2);
            tabPage5.Controls.Add(btnStart);
            tabPage5.Controls.Add(lblTimer);
            tabPage5.Controls.Add(btnReset);
            tabPage5.Controls.Add(panel1);
            tabPage5.Location = new Point(4, 25);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1102, 569);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Podoro";
            tabPage5.Click += tabPage5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(label11);
            panel3.Location = new Point(0, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(1102, 40);
            panel3.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(223, 9);
            label11.Name = "label11";
            label11.Size = new Size(704, 19);
            label11.TabIndex = 0;
            label11.Text = "Study like growing an apple: steady, patient, and nourished by every focused Pomodoro session.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._12344;
            pictureBox2.Location = new Point(448, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(266, 262);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(325, 418);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(190, 69);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(552, 384);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(49, 19);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00";
            lblTimer.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(645, 418);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(197, 69);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset Timer";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(lblTime);
            panel1.Location = new Point(0, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 73);
            panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(280, 18);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(581, 36);
            lblTime.TabIndex = 0;
            lblTime.Text = "KEEP YOUR FOCUS IN STUDYING";
            lblTime.Click += lblTime_Click;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Controls.Add(textBox3);
            tabPage6.Controls.Add(label4);
            tabPage6.Controls.Add(panel2);
            tabPage6.Controls.Add(pictureBox1);
            tabPage6.Controls.Add(textBox2);
            tabPage6.Controls.Add(textBox1);
            tabPage6.Controls.Add(label3);
            tabPage6.Controls.Add(label2);
            tabPage6.Location = new Point(4, 25);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1102, 569);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Account";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Bahnschrift", 14.25F);
            textBox3.Location = new Point(322, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 30);
            textBox3.TabIndex = 7;
            textBox3.Text = "1-00-00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 14.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(212, 170);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 6;
            label4.Text = "Account ID:";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Controls.Add(btnUpdateAcc);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(189, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 274);
            panel2.TabIndex = 5;
            // 
            // btnUpdateAcc
            // 
            btnUpdateAcc.BackColor = Color.Transparent;
            btnUpdateAcc.FlatStyle = FlatStyle.Flat;
            btnUpdateAcc.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateAcc.Location = new Point(528, 220);
            btnUpdateAcc.Name = "btnUpdateAcc";
            btnUpdateAcc.Size = new Size(173, 37);
            btnUpdateAcc.TabIndex = 11;
            btnUpdateAcc.Text = "Update Account";
            btnUpdateAcc.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(47, 177);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 8;
            label8.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 132);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 10;
            label5.Text = "Student ID:";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Font = new Font("Bahnschrift", 14.25F);
            textBox7.Location = new Point(154, 171);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(547, 30);
            textBox7.TabIndex = 3;
            textBox7.Text = "College";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 93);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 9;
            label6.Text = "Last Name:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Font = new Font("Bahnschrift", 14.25F);
            textBox6.Location = new Point(154, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(547, 30);
            textBox6.TabIndex = 2;
            textBox6.Text = "123-123-12";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 43);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 8;
            label7.Text = "First Name:";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Bahnschrift", 14.25F);
            textBox5.Location = new Point(154, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(547, 30);
            textBox5.TabIndex = 1;
            textBox5.Text = "None";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Bahnschrift", 14.25F);
            textBox4.Location = new Point(154, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(547, 30);
            textBox4.TabIndex = 0;
            textBox4.Text = "Admin ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageyay;
            pictureBox1.Location = new Point(733, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Bahnschrift", 14.25F);
            textBox2.Location = new Point(322, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 30);
            textBox2.TabIndex = 3;
            textBox2.Text = "••••••••••";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Bahnschrift", 14.25F);
            textBox1.Location = new Point(322, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 30);
            textBox1.TabIndex = 2;
            textBox1.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 14.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(212, 129);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 1;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(215, 83);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.SteelBlue;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1086, 636);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(32, 23);
            btnHome.TabIndex = 1;
            btnHome.Text = "🏠︎";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1140, 671);
            Controls.Add(btnHome);
            Controls.Add(tabControl1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlashCards).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskAnnouce).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFolder).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btnSaveNote;
        private TextBox txtNote1;
        private Button btnAddCard;
        private TextBox txtAnswer;
        private Button btnAddTask;
        private DateTimePicker dtTask;
        private Button btnUpload;
        private RichTextBox rtxtInfoTask;
        private DataGridView dgvTaskAnnouce;
        private TextBox txtTitle;
        private Button btnDelete;
        private Button btnUpdate;
        private TabPage tabPage6;
        private Button btnShow;
        private RichTextBox txtNote2;
        private DataGridView dgvFolder;
        private RichTextBox txtNote3;
        private DataGridView dgvFlashCards;
        private RichTextBox rtxtQuestions;
        private Button btnRefresh;
        private Button btnTest;
        private Button btnReset;
        private Panel panel1;
        private Label lblTime;
        private Label lblTimer;
        private Button btnStart;
        private Label label1;
        private Button btnRefFlash;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button btnUpdateAcc;
        private Label label8;
        private RichTextBox txtNote4;
        private Button btnLoad;
        private System.Windows.Forms.Timer timer1;
        private Label label9;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label10;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label11;
        private Button btnHome;
    }
}