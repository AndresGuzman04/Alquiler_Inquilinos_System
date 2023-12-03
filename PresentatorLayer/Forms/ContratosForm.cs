using BusinessLayer.Crud;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentatorLayer.PDF;
using PresentatorLayer.Validaciones;
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
        private bool isEditMode = false;
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

            DateTime fechaSeleccionada = fechainiciodateTimePicker.Value;
            contratos.FechaInicio = fechaSeleccionada;
            contratos.FechaFin = fechaSeleccionada;
            contratos.MontoMensual = montomensualtextBox.Text;
            

            contratos.PropiedadId = (int)propiedadComBo.SelectedValue;
            contratos.InquilinoId = (int)InquilinocomboBox.SelectedIndex;

            contratosValidator mantenimientoValidator = new contratosValidator();
            ValidationResult result = mantenimientoValidator.Validate(contratos);


            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    MessageBox.Show("Error: " + failure.ErrorMessage);
                }
            }
            else
            {

                if (isEditMode == false)
                {
                    contratosBusiness.AddContrato(contratos);
                    LoadContratosData();
                    ClearFormContratos();
                }
                else
                {

                    contratos.Id = int.Parse(s: contratosdataGridView.CurrentRow.Cells[0].Value.ToString());

                    contratosBusiness.UpdateContrato(contratos);
                    LoadContratosData();
                    ClearFormContratos();
                    isEditMode = false;
                }

            }


        }

        private void pdfcontratosbutton_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Manuel\Documents\Nuevacarpeta\ContratosPDF";

            try
            {
                iTextPDF contratosPDF = new iTextPDF();

                var document = contratosPDF.InitializePDF(path);

                document.Add(contratosPDF.GenerateHeaderPDF("Reporte Contratos"));
                document.Add(contratosPDF.GenerateTablePDF(5, contratosdataGridView));

                document.Close();
                MessageBox.Show("PDF se genero correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editarcontratosbutton_Click(object sender, EventArgs e)
        {
            if (contratosdataGridView.SelectedRows.Count > 0)
            {
                string fechastring = contratosdataGridView.CurrentRow.Cells[1].Value.ToString();
                DateTime fechaSeleccionada = DateTime.Parse(fechastring);
                fechainiciodateTimePicker.Value = fechaSeleccionada;
                fechafindateTimePicker.Value = fechaSeleccionada;

                montomensualtextBox.Text = contratosdataGridView.CurrentRow.Cells[2].Value.ToString();

                propiedadComBo.SelectedValue = contratosdataGridView.CurrentRow.Cells[4].Value.ToString();
                InquilinocomboBox.SelectedValue = contratosdataGridView.CurrentRow.Cells[5].Value.ToString();

                isEditMode = true;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void eliminarcontratosbutton_Click(object sender, EventArgs e)
        {
            if(contratosdataGridView.SelectedRows.Count > 0)
            {
                ContratosBusiness contratosBusiness = new ContratosBusiness();
                Contratos contratos = new Contratos();
                contratos.Id = int.Parse(s: contratosdataGridView.CurrentRow.Cells[0].Value.ToString());
                contratosBusiness.DeleteContrato(contratos);
                LoadContratosData();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila antes de eliminar");
            }

        }

    }
}

