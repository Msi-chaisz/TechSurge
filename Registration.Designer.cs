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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
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
            txtFirstName.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(130, 231);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(352, 30);
            txtFirstName.TabIndex = 0;
            // 
            // txtlastName
            // 
            txtlastName.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlastName.Location = new Point(130, 280);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(352, 30);
            txtlastName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(130, 328);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(352, 30);
            txtStudentID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 238);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 4;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(130, 435);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(352, 40);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(130, 380);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(352, 31);
            cbSection.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 287);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 7;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 335);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 8;
            label3.Text = "Student ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 387);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 9;
            label4.Text = "Level:";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(130, 183);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(352, 30);
            txtPass.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(130, 131);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(352, 30);
            txtUser.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 138);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 12;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 190);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 13;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bahnschrift SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(154, 56);
            label7.Name = "label7";
            label7.Size = new Size(237, 39);
            label7.TabIndex = 14;
            label7.Text = "Create Account";
            label7.Click += label7_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(522, 566);
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
            ShowInTaskbar = false;
            Text = "iAralYan";
            Load += Registration_Load;
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