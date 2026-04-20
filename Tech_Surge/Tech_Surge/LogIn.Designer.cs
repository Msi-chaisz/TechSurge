namespace Tech_Surge
{
    partial class LogIn
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLog = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Bahnschrift Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(29, 180);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = " Username";
            txtUser.Size = new Size(326, 33);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(29, 230);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.PlaceholderText = " Password";
            txtPass.Size = new Size(326, 36);
            txtPass.TabIndex = 1;
            // 
            // btnLog
            // 
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(29, 283);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(326, 35);
            btnLog.TabIndex = 2;
            btnLog.Text = "Log In";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 55);
            label1.Name = "label1";
            label1.Size = new Size(239, 76);
            label1.TabIndex = 3;
            label1.Text = "iAralYan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 334);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 6;
            label2.Text = "Don't have an account yet?";
            label2.Click += label2_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(387, 465);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLog);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "LogIn";
            Text = "0";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLog;
        private Label label1;
        private Button btnRegister;
        private Label label2;
    }
}