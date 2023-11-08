namespace PresentatorLayer.Forms
{
    partial class Login
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
            titulolabel = new Label();
            usernametextBox = new TextBox();
            passwordlabel = new Label();
            usernamelabel = new Label();
            passwordtextBox = new TextBox();
            loginbutton = new Button();
            SuspendLayout();
            // 
            // titulolabel
            // 
            titulolabel.AutoSize = true;
            titulolabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            titulolabel.ForeColor = SystemColors.InfoText;
            titulolabel.Location = new Point(178, 20);
            titulolabel.Name = "titulolabel";
            titulolabel.Size = new Size(83, 31);
            titulolabel.TabIndex = 0;
            titulolabel.Text = "LOGIN";
            // 
            // usernametextBox
            // 
            usernametextBox.Location = new Point(136, 88);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(227, 27);
            usernametextBox.TabIndex = 1;
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordlabel.ForeColor = SystemColors.InfoText;
            passwordlabel.Location = new Point(12, 156);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(101, 28);
            passwordlabel.TabIndex = 2;
            passwordlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernamelabel.ForeColor = SystemColors.InfoText;
            usernamelabel.Location = new Point(12, 84);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(106, 28);
            usernamelabel.TabIndex = 3;
            usernamelabel.Text = "Username";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(136, 156);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(227, 27);
            passwordtextBox.TabIndex = 4;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginbutton.ForeColor = SystemColors.InfoText;
            loginbutton.Location = new Point(178, 268);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(100, 43);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Enter";
            loginbutton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(419, 360);
            Controls.Add(loginbutton);
            Controls.Add(passwordtextBox);
            Controls.Add(usernamelabel);
            Controls.Add(passwordlabel);
            Controls.Add(usernametextBox);
            Controls.Add(titulolabel);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulolabel;
        private TextBox usernametextBox;
        private Label passwordlabel;
        private Label usernamelabel;
        private TextBox passwordtextBox;
        private Button loginbutton;
    }
}