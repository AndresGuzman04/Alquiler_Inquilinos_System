using BusinessLayer.Crud;
using EmailDemo.MailServices;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            AuthBussines authBusiness = new AuthBussines();

            try
            {
                if (ValidateFields())
                {
                    var rowsAffected = authBusiness.RegisterUser(usernameRegister.Text, emailRegister.Text, passwordRegister.Text);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registrado con Éxito!!");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el registro: {ex.Message}");
            }

           
        }

        private void ShowValidationErrors(List<string> errors)
        {
            MessageBox.Show(string.Join("\n", errors), "Errores de Validación");
        }

        private bool ValidateFields()
        {
            List<string> validationErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(emailRegister.Text) || !IsValidEmail(emailRegister.Text))
            {
                validationErrors.Add("Por favor, ingrese una dirección de correo electrónico válida.");
            }

            if (string.IsNullOrWhiteSpace(usernameRegister.Text) || usernameRegister.Text == "USUARIO")
            {
                validationErrors.Add("Por favor, ingrese un nombre de usuario.");
            }

            if (string.IsNullOrWhiteSpace(passwordRegister.Text) || passwordRegister.Text == "CONTRASEÑA")
            {
                validationErrors.Add("Por favor, ingrese una contraseña.");
            }

            if (validationErrors.Count > 0)
            {
                ShowValidationErrors(validationErrors);
                return false;
            }

            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void usernameRegister_Enter(object sender, EventArgs e)
        {
            if (usernameRegister.Text == "USUARIO")
            {
                usernameRegister.Text = "";
                usernameRegister.ForeColor = Color.LightGray;
            }
        }

        private void usernameRegister_Leave(object sender, EventArgs e)
        {
            if (usernameRegister.Text == "")
            {
                usernameRegister.Text = "USUARIO";
                usernameRegister.ForeColor = Color.DimGray;
            }
        }

        private void passwordRegister_Enter(object sender, EventArgs e)
        {
            if (passwordRegister.Text == "CONTRASEÑA")
            {
                passwordRegister.Text = "";
                passwordRegister.ForeColor = Color.LightGray;
                passwordRegister.UseSystemPasswordChar = true;
            }
        }

        private void passwordRegister_Leave(object sender, EventArgs e)
        {
            if (passwordRegister.Text == "")
            {
                passwordRegister.Text = "CONTRASEÑA";
                passwordRegister.ForeColor = Color.DimGray;
            }
        }

        private void emailRegister_Enter(object sender, EventArgs e)
        {
            if (emailRegister.Text == "EMAIL")
            {
                emailRegister.Text = "";
                emailRegister.ForeColor = Color.LightGray;
            }
        }

        private void emailRegister_Leave(object sender, EventArgs e)
        {
            if (emailRegister.Text == "")
            {
                emailRegister.Text = "EMAIL";
                emailRegister.ForeColor = Color.DimGray;
            }
        }
    }
}
