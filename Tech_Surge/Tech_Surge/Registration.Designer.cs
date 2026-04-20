namespace Tech_Surge
{
    partial class Registration
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
            txtFirstName = new TextBox();
            txtlastName = new TextBox();
            txtStudentID = new TextBox();
            label1 = new Label();
            btnRegister = new Button();
            cbSection = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(143, 169);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(328, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtlastName
            // 
            txtlastName.Location = new Point(143, 219);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(328, 23);
            txtlastName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(143, 277);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(328, 23);
            txtStudentID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 177);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(143, 379);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(328, 50);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(143, 322);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(328, 23);
            cbSection.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 227);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 285);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 330);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Section";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(143, 129);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(328, 23);
            txtPass.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(143, 90);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(328, 23);
            txtUser.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 98);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 137);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 13;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 38);
            label7.Name = "label7";
            label7.Size = new Size(147, 15);
            label7.TabIndex = 14;
            label7.Text = "ACCOUNT INFORMATION";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 555);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSection);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(txtStudentID);
            Controls.Add(txtlastName);
            Controls.Add(txtFirstName);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtlastName;
        private TextBox txtStudentID;
        private Label label1;
        private Button btnRegister;
        private ComboBox cbSection;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}