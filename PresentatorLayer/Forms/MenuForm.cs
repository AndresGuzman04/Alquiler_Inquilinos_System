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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Inquilinos 
        private void OpenInquilinnosForm(Form inquilinoForm)
        {
            inquilinoForm.TopLevel = false;
            inquilinoForm.Dock = DockStyle.Fill;
            contenidopanel.Controls.Add(inquilinoForm);
            contenidopanel.Tag = inquilinoForm;
            inquilinoForm.BringToFront();
            inquilinoForm.Show();
        }

        private void inquilinosmenubutton_Click(object sender, EventArgs e)
        {
            OpenInquilinnosForm(new inquilinosForm());
        }

        #region Propiedades
        private void OpenPropiedadesForm(Form PropiedadesForm)
        {
            PropiedadesForm.TopLevel = false;
            PropiedadesForm.Dock = DockStyle.Fill;
            contenidopanel.Controls.Add(PropiedadesForm);
            contenidopanel.Tag = PropiedadesForm;
            PropiedadesForm.BringToFront();
            PropiedadesForm.Show();
        }

        private void propiedadmenubutton_Click(object sender, EventArgs e)
        {
            OpenPropiedadesForm(new PropiedadesForm());
        }
        #endregion
    }
}