using BusinessLayer.Crud;
using CommonLayer.Entities;
using FluentValidation.Results;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using PresentatorLayer.PDF;
using PresentatorLayer.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iText.Layout.Document;

namespace PresentatorLayer.Forms
{
    public partial class inquilinosForm : Form
    {
        private bool isEditMode = false;
        public inquilinosForm()
        {
            InitializeComponent();
            LoadIquilinos();
        }
        private void ClearFormInquilino()
        {
            nombreTextBox.Clear();
            emailTextBox.Clear();
            telefonoTextbox.Clear();
            direccionTextBox.Clear();

        }
        public void LoadIquilinos()
        {
            InquilinoBusiness inquilinoBussiness = new InquilinoBusiness();
            inquilinosdataGridView.DataSource = null;
            inquilinosdataGridView.DataSource = inquilinoBussiness.GetInquilinos();
            inquilinosdataGridView.Columns["InquilinoID"].HeaderText = "ID";
        }

        private void guardarInquilinoButton_Click_1(object sender, EventArgs e)
        {
            InquilinoBusiness inquilinoBusiness = new InquilinoBusiness();
            Inquilino inquilino = new Inquilino();

            inquilino.Nombre = nombreTextBox.Text;
            inquilino.Email = emailTextBox.Text;
            inquilino.Telefono = telefonoTextbox.Text;
            inquilino.Direccion = direccionTextBox.Text;

            inquilinosValidator inquilinoValidator = new inquilinosValidator();
            ValidationResult result = inquilinoValidator.Validate(inquilino);


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
                    inquilinoBusiness.AddInquilino(inquilino);
                    LoadIquilinos();
                    ClearFormInquilino();
                }
                else
                {
                    inquilino.Id = int.Parse(inquilinosdataGridView.CurrentRow.Cells[0].Value.ToString());
                    inquilinoBusiness.UpdateInquilino(inquilino);
                    LoadIquilinos();
                    ClearFormInquilino();
                    isEditMode = false;
                }
            }
        }

        private void editarInquilinoButton_Click_1(object sender, EventArgs e)
        {
            if (inquilinosdataGridView.SelectedRows.Count > 0)
            {
                nombreTextBox.Text = inquilinosdataGridView.CurrentRow.Cells[1].Value.ToString();
                emailTextBox.Text = inquilinosdataGridView.CurrentRow.Cells[2].Value.ToString();
                telefonoTextbox.Text = inquilinosdataGridView.CurrentRow.Cells[3].Value.ToString();
                direccionTextBox.Text = inquilinosdataGridView.CurrentRow.Cells[4].Value.ToString();
                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para editar");
            }
        }

        private void eliminarInquilinoButton_Click_1(object sender, EventArgs e)
        {
            if (inquilinosdataGridView.SelectedRows.Count > 0)
            {
                int inquilinoId = int.Parse(s: inquilinosdataGridView.CurrentRow.Cells[0].Value.ToString());
                InquilinoBusiness inquilinoBusiness = new InquilinoBusiness();
                Inquilino inquilino = new Inquilino();
                inquilino.Id = inquilinoId;
                inquilinoBusiness.DeleteInquilino(inquilino);
                LoadIquilinos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila antes de elimniar");
            }
        }

        private void pdfinquilinosbutton_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Manuel\Documents\Nueva carpeta\InquilinosPDF";

            try
            {
                iTextPDF inquilinoPDF = new iTextPDF();

                var document = inquilinoPDF.InitializePDF(path);

                document.Add(inquilinoPDF.GenerateHeaderPDF("Reporte inquilinos"));
                document.Add(inquilinoPDF.GenerateTablePDF(5, inquilinosdataGridView));

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

