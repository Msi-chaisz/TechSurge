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
            stNotes = new ListBox();
            btnSaveNote = new Button();
            txtNotes = new TextBox();
            tabPage2 = new TabPage();
            stFlashCards = new ListBox();
            btnAddCard = new Button();
            txtAnswer = new TextBox();
            txtQuestion = new TextBox();
            tabPage3 = new TabPage();
            button1 = new Button();
            btnUpdate = new Button();
            txtTitle = new TextBox();
            rtxtInfoTask = new RichTextBox();
            dgvTaskAnnouce = new DataGridView();
            btnAddTask = new Button();
            dtTask = new DateTimePicker();
            tabPage4 = new TabPage();
            lblFile = new Label();
            btnUpload = new Button();
            tabPage5 = new TabPage();
            stAnnoucements = new ListBox();
            tabPage6 = new TabPage();
            btnShow = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskAnnouce).BeginInit();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
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
            tabPage1.Controls.Add(stNotes);
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
            // stNotes
            // 
            stNotes.FormattingEnabled = true;
            stNotes.ItemHeight = 15;
            stNotes.Location = new Point(185, 54);
            stNotes.Name = "stNotes";
            stNotes.Size = new Size(651, 304);
            stNotes.TabIndex = 2;
            // 
            // btnSaveNote
            // 
            btnSaveNote.Location = new Point(49, 102);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(75, 23);
            btnSaveNote.TabIndex = 1;
            btnSaveNote.Text = "Save Note";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(37, 53);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(100, 23);
            txtNotes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(stFlashCards);
            tabPage2.Controls.Add(btnAddCard);
            tabPage2.Controls.Add(txtAnswer);
            tabPage2.Controls.Add(txtQuestion);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1102, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Flash Cards";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // stFlashCards
            // 
            stFlashCards.FormattingEnabled = true;
            stFlashCards.ItemHeight = 15;
            stFlashCards.Location = new Point(192, 53);
            stFlashCards.Name = "stFlashCards";
            stFlashCards.Size = new Size(622, 289);
            stFlashCards.TabIndex = 3;
            // 
            // btnAddCard
            // 
            btnAddCard.Location = new Point(57, 161);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(75, 23);
            btnAddCard.TabIndex = 2;
            btnAddCard.Text = "Add Card";
            btnAddCard.UseVisualStyleBackColor = true;
            btnAddCard.Click += btnAddCard_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(46, 111);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.PlaceholderText = "Answer";
            txtAnswer.Size = new Size(100, 23);
            txtAnswer.TabIndex = 1;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(46, 55);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.PlaceholderText = "Question?";
            txtQuestion.Size = new Size(100, 23);
            txtQuestion.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnShow);
            tabPage3.Controls.Add(button1);
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
            // button1
            // 
            button1.Location = new Point(53, 473);
            button1.Name = "button1";
            button1.Size = new Size(209, 36);
            button1.TabIndex = 8;
            button1.Text = "Delete Task";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(53, 431);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Task";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(53, 158);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title Text";
            txtTitle.Size = new Size(209, 23);
            txtTitle.TabIndex = 6;
            // 
            // rtxtInfoTask
            // 
            rtxtInfoTask.Location = new Point(53, 187);
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
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(53, 386);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(209, 39);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtTask
            // 
            dtTask.Location = new Point(53, 128);
            dtTask.Name = "dtTask";
            dtTask.Size = new Size(209, 23);
            dtTask.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblFile);
            tabPage4.Controls.Add(btnUpload);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1102, 570);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Assignments";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(242, 73);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(28, 15);
            lblFile.TabIndex = 1;
            lblFile.Text = "File:";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(242, 199);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(418, 122);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(stAnnoucements);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1102, 570);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Teacher Annoucements";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // stAnnoucements
            // 
            stAnnoucements.FormattingEnabled = true;
            stAnnoucements.ItemHeight = 15;
            stAnnoucements.Location = new Point(102, 52);
            stAnnoucements.Name = "stAnnoucements";
            stAnnoucements.Size = new Size(706, 304);
            stAnnoucements.TabIndex = 0;
            stAnnoucements.SelectedIndexChanged += stAnnoucements_SelectedIndexChanged;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1102, 570);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Podoro";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(1006, 26);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskAnnouce).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private ListBox stNotes;
        private Button btnSaveNote;
        private TextBox txtNotes;
        private ListBox stFlashCards;
        private Button btnAddCard;
        private TextBox txtAnswer;
        private TextBox txtQuestion;
        private Button btnAddTask;
        private DateTimePicker dtTask;
        private Label lblFile;
        private Button btnUpload;
        private ListBox stAnnoucements;
        private RichTextBox rtxtInfoTask;
        private DataGridView dgvTaskAnnouce;
        private TextBox txtTitle;
        private Button button1;
        private Button btnUpdate;
        private TabPage tabPage6;
        private Button btnShow;
    }
}