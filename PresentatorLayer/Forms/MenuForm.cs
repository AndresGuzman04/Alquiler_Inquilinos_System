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
        private void OpenInquilinnosForm(Form inquilinoForm)
        {
            inquilinoForm.TopLevel = false;
            inquilinoForm.Dock = DockStyle.Fill;
            contenidopanel.Controls.Add(inquilinoForm);
            contenidopanel.Tag = inquilinoForm;
            inquilinoForm.BringToFront();
            inquilinoForm.Show();
        }

        private void inquilinosmenubutton_Click_1(object sender, EventArgs e)
        {
            //OpenInquilinnosForm(new inquilinosForm());
        }


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
            //OpenPropiedadesForm(new PropiedadesForm());
        }
        private void OpenContratosForm(Form ContratosForm)
        {
            ContratosForm.TopLevel = false;
            ContratosForm.Dock = DockStyle.Fill;
            contenidopanel.Controls.Add(ContratosForm);
            contenidopanel.Tag = ContratosForm;
            ContratosForm.BringToFront();
            ContratosForm.Show();

        }
        private void contratosmenubutton_Click(object sender, EventArgs e)
        {
            //OpenContratosForm(new ContratosForm());
        }
        private void OpenMantenimientoForm(Form MantenimientoForm)
        {
            MantenimientoForm.TopLevel = false;
            MantenimientoForm.Dock = DockStyle.Fill;
            contenidopanel.Controls.Add(MantenimientoForm);
            contenidopanel.Tag = MantenimientoForm;
            MantenimientoForm.BringToFront();
            MantenimientoForm.Show();

        }

        private void mantenimientomenubutton_Click(object sender, EventArgs e)
        {
            //OpenMantenimientoForm(new MantenimientoForm());
        }

        private void OpenPagosForm(Form PagosForm)
        {
            PagosForm.TopLevel = false;
            PagosForm.Dock= DockStyle.Fill;
            contenidopanel.Controls.Add(PagosForm);
            contenidopanel.Tag = PagosForm; 
            PagosForm.BringToFront();
            PagosForm.Show();
        }

        private void pagosmenubutton_Click(object sender, EventArgs e)
        {
            OpenPagosForm(new PagosForm());
        }
    }
}