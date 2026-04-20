namespace Tech_Surge
{
    partial class FlashcardTests
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
            panel1 = new Panel();
            lblQuestion = new Label();
            btnSubmit = new Button();
            btnLoad = new Button();
            txtAnswer = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(lblQuestion);
            panel1.Controls.Add(btnLoad);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 231);
            panel1.TabIndex = 0;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(35, 91);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(224, 58);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "- QUESTIONS";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(12, 332);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(686, 37);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Transparent;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Bahnschrift SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(584, -35);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(186, 138);
            btnLoad.TabIndex = 3;
            btnLoad.Text = " ⟳ ";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(12, 270);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(686, 56);
            txtAnswer.TabIndex = 4;
            txtAnswer.Text = "";
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // FlashcardTests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(txtAnswer);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Name = "FlashcardTests";
            Text = "FlashcardTests";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuestion;
        private Button btnSubmit;
        private Button btnLoad;
        private RichTextBox txtAnswer;
    }
}