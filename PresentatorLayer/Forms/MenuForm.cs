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
        private void closepictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form ActiveForm = null;

        private void OpenForms(Form forms)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
            }
            forms.TopLevel = false;
            forms.Dock = DockStyle.Fill;
            contenidopanel.Controls.Add(forms);
            contenidopanel.Tag = forms;
            forms.BringToFront();
            forms.Show();
        }
        
        private void inquilinosmenubutton_Click_1(object sender, EventArgs e)
        {
            OpenForms(new inquilinosForm());
        }

        private void propiedadmenubutton_Click(object sender, EventArgs e)
        {
            OpenForms(new PropiedadesForm());
        }
        
        private void contratosmenubutton_Click(object sender, EventArgs e)
        {
            OpenForms(new ContratosForm());
        }
        
        private void mantenimientomenubutton_Click(object sender, EventArgs e)
        {
            OpenForms(new MantenimientoForm());
        }

        private void pagosmenubutton_Click(object sender, EventArgs e)
        {
            OpenForms(new PagosForm());
        }
    }
}