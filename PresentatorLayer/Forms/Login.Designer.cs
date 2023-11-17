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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernametextBox = new TextBox();
            passwordtextBox = new TextBox();
            loginbutton = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernametextBox
            // 
            usernametextBox.BackColor = SystemColors.InactiveCaptionText;
            usernametextBox.BorderStyle = BorderStyle.None;
            usernametextBox.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            usernametextBox.ForeColor = Color.Gray;
            usernametextBox.Location = new Point(369, 122);
            usernametextBox.Margin = new Padding(4, 4, 4, 4);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(556, 34);
            usernametextBox.TabIndex = 1;
            usernametextBox.Text = "USUARIO";
            usernametextBox.Enter += usernametextBox_Enter;
            usernametextBox.Leave += usernametextBox_Leave;
            // 
            // passwordtextBox
            // 
            passwordtextBox.BackColor = SystemColors.InactiveCaptionText;
            passwordtextBox.BorderStyle = BorderStyle.None;
            passwordtextBox.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtextBox.ForeColor = Color.Gray;
            passwordtextBox.Location = new Point(369, 235);
            passwordtextBox.Margin = new Padding(4, 4, 4, 4);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(556, 34);
            passwordtextBox.TabIndex = 2;
            passwordtextBox.Text = "CONTRASEÑA";
            passwordtextBox.Enter += passwordtextBox_Enter;
            passwordtextBox.Leave += passwordtextBox_Leave;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = SystemColors.MenuText;
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            loginbutton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            loginbutton.ForeColor = Color.Gray;
            loginbutton.Location = new Point(369, 356);
            loginbutton.Margin = new Padding(4, 4, 4, 4);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(556, 59);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "ACCEDER";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 630);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 630);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(588, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 35);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(369, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(556, 1);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(369, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(556, 1);
            label3.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.SteelBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(594, 484);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(976, 0);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1008, 630);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(loginbutton);
            Controls.Add(passwordtextBox);
            Controls.Add(usernametextBox);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernametextBox;
        private TextBox passwordtextBox;
        private Button loginbutton;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}