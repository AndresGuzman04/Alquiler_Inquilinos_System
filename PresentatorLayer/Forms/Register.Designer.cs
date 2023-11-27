namespace PresentatorLayer.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            close = new PictureBox();
            loginLabel = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            registerbutton = new Button();
            passwordRegister = new TextBox();
            usernameRegister = new TextBox();
            label4 = new Label();
            emailRegister = new TextBox();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(977, 0);
            close.Margin = new Padding(4);
            close.Name = "close";
            close.Size = new Size(31, 31);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 20;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // loginLabel
            // 
            loginLabel.ActiveLinkColor = Color.SteelBlue;
            loginLabel.AutoSize = true;
            loginLabel.LinkColor = Color.DimGray;
            loginLabel.Location = new Point(595, 484);
            loginLabel.Margin = new Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(136, 25);
            loginLabel.TabIndex = 12;
            loginLabel.TabStop = true;
            loginLabel.Text = "Inicio de Sesion";
            loginLabel.LinkClicked += loginLabel_LinkClicked;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(370, 245);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(556, 1);
            label3.TabIndex = 19;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(370, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(556, 1);
            label2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(589, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 17;
            label1.Text = "REGISTRO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 630);
            panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 630);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // registerbutton
            // 
            registerbutton.BackColor = SystemColors.MenuText;
            registerbutton.FlatAppearance.BorderSize = 0;
            registerbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            registerbutton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            registerbutton.FlatStyle = FlatStyle.Flat;
            registerbutton.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            registerbutton.ForeColor = Color.Gray;
            registerbutton.Location = new Point(370, 356);
            registerbutton.Margin = new Padding(4);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(556, 59);
            registerbutton.TabIndex = 15;
            registerbutton.Text = "REGISTRARSE";
            registerbutton.UseVisualStyleBackColor = false;
            // 
            // passwordRegister
            // 
            passwordRegister.BackColor = SystemColors.InactiveCaptionText;
            passwordRegister.BorderStyle = BorderStyle.None;
            passwordRegister.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegister.ForeColor = Color.Gray;
            passwordRegister.Location = new Point(370, 206);
            passwordRegister.Margin = new Padding(4);
            passwordRegister.Name = "passwordRegister";
            passwordRegister.Size = new Size(556, 34);
            passwordRegister.TabIndex = 14;
            passwordRegister.Text = "CONTRASEÑA";
            // 
            // usernameRegister
            // 
            usernameRegister.BackColor = SystemColors.InactiveCaptionText;
            usernameRegister.BorderStyle = BorderStyle.None;
            usernameRegister.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            usernameRegister.ForeColor = Color.Gray;
            usernameRegister.Location = new Point(370, 122);
            usernameRegister.Margin = new Padding(4);
            usernameRegister.Name = "usernameRegister";
            usernameRegister.Size = new Size(556, 34);
            usernameRegister.TabIndex = 13;
            usernameRegister.Text = "USUARIO";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(370, 334);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(556, 1);
            label4.TabIndex = 22;
            // 
            // emailRegister
            // 
            emailRegister.BackColor = SystemColors.InactiveCaptionText;
            emailRegister.BorderStyle = BorderStyle.None;
            emailRegister.Font = new Font("MingLiU_HKSCS-ExtB", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailRegister.ForeColor = Color.Gray;
            emailRegister.Location = new Point(370, 295);
            emailRegister.Margin = new Padding(4);
            emailRegister.Name = "emailRegister";
            emailRegister.Size = new Size(556, 34);
            emailRegister.TabIndex = 21;
            emailRegister.Text = "EMAIL";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1008, 630);
            Controls.Add(label4);
            Controls.Add(emailRegister);
            Controls.Add(close);
            Controls.Add(loginLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(registerbutton);
            Controls.Add(passwordRegister);
            Controls.Add(usernameRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox close;
        private LinkLabel loginLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button registerbutton;
        private TextBox passwordRegister;
        private TextBox usernameRegister;
        private Label label4;
        private TextBox emailRegister;
    }
}