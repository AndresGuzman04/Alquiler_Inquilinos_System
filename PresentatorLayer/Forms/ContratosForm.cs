using BusinessLayer.Crud;
using CommonLayer.Entities;
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
    
    public partial class ContratosForm : Form
    {
        public ContratosForm()
        {
            InitializeComponent();
            LoadContratosData();
            LoadPropiedadComboBox();
            LoadInquilinoComboBox();
        }
        private void LoadContratosData()
        {
            ContratosBusiness contratosBusiness = new ContratosBusiness();
            contratosdataGridView.DataSource = contratosBusiness.GetContratos();

        }
        private void LoadInquilinoComboBox()
        {

            InquilinoBusiness inquilinoBusiness = new InquilinoBusiness();
            InquilinocomboBox.DataSource = inquilinoBusiness.GetInquilinos();


            propiedadComBo.DisplayMember = "Nombre";
            propiedadComBo.ValueMember = "ID";

        }
        private void LoadPropiedadComboBox()
        {

            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();
            propiedadComBo.DataSource = propiedadBusiness.GetPropiedad();

            propiedadComBo.DisplayMember = "Nombre";
            propiedadComBo.ValueMember = "ID";

        }
        private void ClearFormContratos()
        {
            montomensualtextBox.Clear();
        }

        private void guardarcontratosbutton_Click(object sender, EventArgs e)
        {
            ContratosBusiness contratosBusiness = new ContratosBusiness();
            Contratos contratos = new Contratos();

            DateTime fechaSelecionada = fechainiciodateTimePicker.Value;
            DateTime fechaSeleccionada2 = fechafindateTimePicker.Value;
            contratos.FechaInicio = fechaSelecionada;
            contratos.FechaFin = fechaSeleccionada2;
            contratos.MontoMensual = montomensualtextBox.Text;

            contratos.PropiedadId = (int)propiedadComBo.SelectedValue;

            contratosBusiness.AddContrato(contratos);
            LoadContratosData();
            ClearFormContratos();
        }
    }
}
