using BusinessLayer.Crud;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentatorLayer.Forms
{
    public partial class Login : Form
    {
        public object Aplication { get; private set; }

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = loginbutton;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            usernametextBox.Clear();
            passwordtextBox.Clear();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametextBox.Text) || usernametextBox.Text != "USUARIO" && 
                string.IsNullOrWhiteSpace(passwordtextBox.Text) || passwordtextBox.Text != "CONTRASEÑA")
            {
                AuthBussines authBusiness = new AuthBussines();

                string hashedPassword = authBusiness.GetPasswordByUserName(usernametextBox.Text);

                if (!string.IsNullOrEmpty(hashedPassword))
                {
                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(passwordtextBox.Text, hashedPassword);

                    if (isPasswordCorrect)
                    {
                        var credentials = authBusiness.LoginUser(usernametextBox.Text, hashedPassword);

                        if (credentials)
                        {
                            MenuForm menuForm = new MenuForm();
                            menuForm.Show();
                            menuForm.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernametextBox_Enter(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "USUARIO")
            {
                usernametextBox.Text = "";
                usernametextBox.ForeColor = Color.LightGray;
            }
        }

        private void usernametextBox_Leave(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "")
            {
                usernametextBox.Text = "USUARIO";
                usernametextBox.ForeColor = Color.DimGray;
            }
        }

        private void passwordtextBox_Enter(object sender, EventArgs e)
        {
            if (passwordtextBox.Text == "CONTRASEÑA")
            {
                passwordtextBox.Text = "";
                passwordtextBox.ForeColor = Color.LightGray;
                passwordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordtextBox_Leave(object sender, EventArgs e)
        {
            if (passwordtextBox.Text == "")
            {
                passwordtextBox.Text = "CONTRASEÑA";
                passwordtextBox.ForeColor = Color.DimGray;
            }
        }
        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            usernametextBox.Clear();
            passwordtextBox.Clear();
            this.Show();
        }
    }
}
