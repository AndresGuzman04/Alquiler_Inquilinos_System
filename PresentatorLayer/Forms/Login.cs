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
        public Login()
        {
            InitializeComponent();
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
            if(usernametextBox.Text == "Bolo" &&  passwordtextBox.Text == "Guasalo")
            {
                LoginForm formAlquiler = new LoginForm();
                this.Hide();
                formAlquiler.Show();

            }
            else if(usernametextBox.Text != "Bolo")
            {
                MessageBox.Show("El nombre de usuario e incorrecto");
                usernametextBox.Clear();
                passwordtextBox.Clear();

            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                usernametextBox.Clear();
                passwordtextBox.Clear();

            }
        }
    }
}
