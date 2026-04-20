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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox4 = new ListBox();
            btnSaveNote = new Button();
            txtNotes = new TextBox();
            tabPage2 = new TabPage();
            btnTest = new Button();
            dataGridView2 = new DataGridView();
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
            lblMiddleTime = new Label();
            btnReset = new Button();
            btnPause = new Button();
            panel1 = new Panel();
            lblTime = new Label();
            tabPage6 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskAnnouce).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFolder).BeginInit();
            tabPage5.SuspendLayout();
            panel1.SuspendLayout();
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
            tabPage1.Controls.Add(richTextBox2);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(richTextBox4);
            tabPage1.Controls.Add(btnSaveNote);
            tabPage1.Controls.Add(txtNotes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1102, 570);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Note";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(403, 81);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(661, 357);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(49, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(348, 357);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.FormattingEnabled = true;
            richTextBox4.ItemHeight = 15;
            richTextBox4.Location = new Point(49, 444);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(1015, 94);
            richTextBox4.TabIndex = 2;
            richTextBox4.SelectedIndexChanged += stNotes_SelectedIndexChanged;
            // 
            // btnSaveNote
            // 
            btnSaveNote.Location = new Point(989, 23);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(75, 23);
            btnSaveNote.TabIndex = 1;
            btnSaveNote.Text = "Save Note";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(49, 52);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(1015, 23);
            txtNotes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnTest);
            tabPage2.Controls.Add(dataGridView2);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(796, 59);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(288, 480);
            dataGridView2.TabIndex = 5;
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
            tabPage5.Controls.Add(lblMiddleTime);
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
            // 
            // lblMiddleTime
            // 
            lblMiddleTime.AutoSize = true;
            lblMiddleTime.Location = new Point(540, 313);
            lblMiddleTime.Name = "lblMiddleTime";
            lblMiddleTime.Size = new Size(38, 15);
            lblMiddleTime.TabIndex = 3;
            lblMiddleTime.Text = "label1";
            lblMiddleTime.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(661, 378);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(252, 69);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset Timer";
            btnReset.UseVisualStyleBackColor = true;
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
            lblTime.Size = new Size(34, 15);
            lblTime.TabIndex = 0;
            lblTime.Text = "Time";
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1102, 570);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Account";
            tabPage6.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private ListBox richTextBox4;
        private Button btnSaveNote;
        private TextBox txtNotes;
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
        private RichTextBox richTextBox1;
        private DataGridView dgvFolder;
        private RichTextBox richTextBox2;
        private DataGridView dataGridView2;
        private RichTextBox rtxtQuestions;
        private Button btnRefresh;
        private Button btnTest;
        private Button btnReset;
        private Button btnPause;
        private Panel panel1;
        private Label lblTime;
        private Label lblMiddleTime;
        private Button btnStart;
        private Label label1;
    }
}