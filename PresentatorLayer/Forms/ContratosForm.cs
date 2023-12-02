using BusinessLayer.Crud;
using CommonLayer.Entities;
using PresentatorLayer.PDF;
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
            
            contratos.PropiedadId = Convert.ToInt32(propiedadComBo.SelectedValue);


            contratosBusiness.AddContrato(contratos);
            LoadContratosData();
            ClearFormContratos();
        }

        private void pdfcontratosbutton_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Manuel\Documents\Nuevacarpeta\ContratosPDF";

            try
            {
                iTextPDF contratosPDF = new iTextPDF();

                var document = contratosPDF.InitializePDF(path);

                document.Add(contratosPDF.GenerateHeaderPDF("Reporte Contratos"));
                document.Add(contratosPDF.GenerateTablePDF(5,contratosdataGridView));

                document.Close();
                MessageBox.Show("PDF se genero correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    }

