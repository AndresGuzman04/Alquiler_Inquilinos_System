using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (usernametextBox.Text == "Univo" && passwordtextBox.Text == "2023")
            {
                LoginForm formAlquiler = new LoginForm();
                this.Hide();
                formAlquiler.Show();

            }


            else if (usernametextBox.Text != "Univo")
            {
                MessageBox.Show("El nombre de usuario incorrecto");
                usernametextBox.Clear();


            }

            else
            {
                MessageBox.Show("Contraseña incorrecta");

                passwordtextBox.Clear();

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
    }
}
