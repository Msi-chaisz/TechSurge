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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLoad = new Button();
            txtNote4 = new RichTextBox();
            txtNote3 = new RichTextBox();
            txtNote2 = new RichTextBox();
            btnSaveNote = new Button();
            txtNote1 = new TextBox();
            tabPage2 = new TabPage();
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
            label1 = new Label();
            btnRefresh = new Button();
            dgvFolder = new DataGridView();
            btnUpload = new Button();
            tabPage5 = new TabPage();
            btnStart = new Button();
            lblTimer = new Label();
            btnReset = new Button();
            btnPause = new Button();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlashCards).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskAnnouce).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFolder).BeginInit();
            tabPage5.SuspendLayout();
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1110, 598);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLoad);
            tabPage1.Controls.Add(txtNote4);
            tabPage1.Controls.Add(txtNote3);
            tabPage1.Controls.Add(txtNote2);
            tabPage1.Controls.Add(btnSaveNote);
            tabPage1.Controls.Add(txtNote1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1102, 570);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Note";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(996, 23);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 23);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtNote4
            // 
            txtNote4.Location = new Point(49, 444);
            txtNote4.Name = "txtNote4";
            txtNote4.Size = new Size(1047, 100);
            txtNote4.TabIndex = 5;
            txtNote4.Text = "";
            // 
            // txtNote3
            // 
            txtNote3.Location = new Point(363, 81);
            txtNote3.Name = "txtNote3";
            txtNote3.Size = new Size(733, 357);
            txtNote3.TabIndex = 4;
            txtNote3.Text = "";
            // 
            // txtNote2
            // 
            txtNote2.Location = new Point(49, 81);
            txtNote2.Name = "txtNote2";
            txtNote2.Size = new Size(308, 357);
            txtNote2.TabIndex = 3;
            txtNote2.Text = "";
            // 
            // btnSaveNote
            // 
            btnSaveNote.Location = new Point(915, 23);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(75, 23);
            btnSaveNote.TabIndex = 1;
            btnSaveNote.Text = "Save Note";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // txtNote1
            // 
            txtNote1.Location = new Point(49, 52);
            txtNote1.Name = "txtNote1";
            txtNote1.Size = new Size(1047, 23);
            txtNote1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRefFlash);
            tabPage2.Controls.Add(btnTest);
            tabPage2.Controls.Add(dgvFlashCards);
            tabPage2.Controls.Add(rtxtQuestions);
            tabPage2.Controls.Add(btnAddCard);
            tabPage2.Controls.Add(txtAnswer);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1102, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Flash Cards";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefFlash
            // 
            btnRefFlash.Location = new Point(1009, 30);
            btnRefFlash.Name = "btnRefFlash";
            btnRefFlash.Size = new Size(75, 23);
            btnRefFlash.TabIndex = 7;
            btnRefFlash.Text = "SHOW";
            btnRefFlash.UseVisualStyleBackColor = true;
            btnRefFlash.Click += btnRefFlash_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(634, 516);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 6;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // dgvFlashCards
            // 
            dgvFlashCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlashCards.Location = new Point(796, 59);
            dgvFlashCards.Name = "dgvFlashCards";
            dgvFlashCards.Size = new Size(288, 480);
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
            btnAddCard.Location = new Point(715, 516);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(75, 23);
            btnAddCard.TabIndex = 2;
            btnAddCard.Text = "Add Card";
            btnAddCard.UseVisualStyleBackColor = true;
            btnAddCard.Click += btnAddCard_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(32, 487);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.PlaceholderText = "Answer";
            txtAnswer.Size = new Size(758, 23);
            txtAnswer.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnShow);
            tabPage3.Controls.Add(btnDelete);
            tabPage3.Controls.Add(btnUpdate);
            tabPage3.Controls.Add(txtTitle);
            tabPage3.Controls.Add(rtxtInfoTask);
            tabPage3.Controls.Add(dgvTaskAnnouce);
            tabPage3.Controls.Add(btnAddTask);
            tabPage3.Controls.Add(dtTask);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1102, 570);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Personal Calendar";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(1006, 26);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(59, 450);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button1_Click;
            btnDelete.MouseClick += btnDelete_MouseClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(59, 408);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Task";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(59, 135);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title Text";
            txtTitle.Size = new Size(209, 23);
            txtTitle.TabIndex = 6;
            // 
            // rtxtInfoTask
            // 
            rtxtInfoTask.Location = new Point(59, 164);
            rtxtInfoTask.Name = "rtxtInfoTask";
            rtxtInfoTask.Size = new Size(209, 193);
            rtxtInfoTask.TabIndex = 5;
            rtxtInfoTask.Text = "";
            // 
            // dgvTaskAnnouce
            // 
            dgvTaskAnnouce.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaskAnnouce.Location = new Point(320, 55);
            dgvTaskAnnouce.Name = "dgvTaskAnnouce";
            dgvTaskAnnouce.Size = new Size(761, 492);
            dgvTaskAnnouce.TabIndex = 4;
            dgvTaskAnnouce.CellContentClick += dgvTaskAnnouce_CellContentClick;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(59, 363);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(209, 39);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtTask
            // 
            dtTask.Location = new Point(59, 105);
            dtTask.Name = "dtTask";
            dtTask.Size = new Size(209, 23);
            dtTask.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(btnRefresh);
            tabPage4.Controls.Add(dgvFolder);
            tabPage4.Controls.Add(btnUpload);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1102, 570);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Assignments";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(852, 68);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 4;
            label1.Text = "Upload a file that can be downloader later.";
            label1.Click += label1_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(200, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 47);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "SHOW";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvFolder
            // 
            dgvFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFolder.Location = new Point(40, 89);
            dgvFolder.Name = "dgvFolder";
            dgvFolder.Size = new Size(1042, 453);
            dgvFolder.TabIndex = 2;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(40, 36);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(154, 47);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnStart);
            tabPage5.Controls.Add(lblTimer);
            tabPage5.Controls.Add(btnReset);
            tabPage5.Controls.Add(btnPause);
            tabPage5.Controls.Add(panel1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1102, 570);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Podoro";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(212, 378);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(252, 69);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(540, 313);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(38, 15);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "label1";
            lblTimer.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(661, 378);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(252, 69);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset Timer";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(212, 378);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(252, 69);
            btnPause.TabIndex = 1;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(lblTime);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 73);
            panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(512, 32);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(121, 15);
            lblTime.TabIndex = 0;
            lblTime.Text = "FOCUS IN STUDYING!";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBox3);
            tabPage6.Controls.Add(label4);
            tabPage6.Controls.Add(panel2);
            tabPage6.Controls.Add(pictureBox1);
            tabPage6.Controls.Add(textBox2);
            tabPage6.Controls.Add(textBox1);
            tabPage6.Controls.Add(label3);
            tabPage6.Controls.Add(label2);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1102, 570);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Account";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(322, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 170);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Account ID:";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateAcc);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(189, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 274);
            panel2.TabIndex = 5;
            // 
            // btnUpdateAcc
            // 
            btnUpdateAcc.Location = new Point(561, 233);
            btnUpdateAcc.Name = "btnUpdateAcc";
            btnUpdateAcc.Size = new Size(140, 23);
            btnUpdateAcc.TabIndex = 11;
            btnUpdateAcc.Text = "Update Account";
            btnUpdateAcc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 179);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 8;
            label8.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 134);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "Student ID:";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(154, 171);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(547, 23);
            textBox7.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 90);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 9;
            label6.Text = "Last Name:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(154, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(547, 23);
            textBox6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 56);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 8;
            label7.Text = "First Name:";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(154, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(547, 23);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(154, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(547, 23);
            textBox4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageyay;
            pictureBox1.Location = new Point(733, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(322, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(322, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 137);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 103);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 612);
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
        private Button btnPause;
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
    }
}