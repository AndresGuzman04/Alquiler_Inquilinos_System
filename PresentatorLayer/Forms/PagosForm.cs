using BusinessLayer.Crud;
using CommonLayer;
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
    public partial class PagosForm : Form
    {
        private bool isEditMode = false;
        public PagosForm()
        {
            InitializeComponent();
            LoadPagosData();
            LoadContratoComboBox();
        }
        private void LoadPagosData()
        {
            PagoBusiness pagoBusiness = new PagoBusiness();
            pagosDataGridView.DataSource = pagoBusiness.GetPagos();
        }
        public void LoadContratoComboBox()
        {
            ContratosBusiness contratoBusiness = new ContratosBusiness();
            contratoComboBox.DataSource = contratoBusiness.GetContratos();
            contratoComboBox.DisplayMember = "ID";
            contratoComboBox.ValueMember = "ID";

        }
        private void ClearFormPago()
        {

            montoPagoTextBox.Clear();

        }
        private void lockedTexbox()
        {

            if (isEditMode == false)
            {

                contratoComboBox.Enabled = true;
            }
            else
            {

                contratoComboBox.Enabled = false;
            }

        }

        private void guardarPagoButton_Click(object sender, EventArgs e)
        {
            PagoBusiness pagoBusiness = new PagoBusiness();
            Pago pago = new Pago();

            DateTime fechaSeleccionada = pagoDateTimePicker.Value;
            pago.fechaPago = fechaSeleccionada;
            pago.monto = montoPagoTextBox.Text;

            pago.contratoID = (int)contratoComboBox.SelectedValue;

            PagoValidator pagoValidator = new PagoValidator();
            ValidationResult result = pagoValidator.Validate(pago);

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
                    pagoBusiness.AddPago(pago);
                    LoadPagosData();
                    ClearFormPago();
                }
                else
                {
                    // Corrected the line for parsing the ID
                    pago.id = int.Parse(pagosDataGridView.CurrentRow.Cells[0].Value.ToString());

                    pagoBusiness.UpdatePago(pago);
                    LoadPagosData();
                    ClearFormPago();
                    isEditMode = false;
                    lockedTexbox();
                }
            }
        }


        private void editarPagoButton_Click(object sender, EventArgs e)
        {

            if (pagosDataGridView.SelectedRows.Count > 0)
            {

                string fechaString = pagosDataGridView.CurrentRow.Cells[1].Value.ToString();
                DateTime fechaSeleccionada = DateTime.Parse(fechaString);
                pagoDateTimePicker.Value = fechaSeleccionada;

                montoPagoTextBox.Text = pagosDataGridView.CurrentRow.Cells[2].Value.ToString();
                contratoComboBox.SelectedValue = pagosDataGridView.CurrentRow.Cells[3].Value.ToString();

                isEditMode = true;
                lockedTexbox();


            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void eliminarPagoButton_Click(object sender, EventArgs e)
        {
            if (pagosDataGridView.SelectedRows.Count > 0)
            {

                PagoBusiness pagoBusiness = new PagoBusiness();
                Pago pago = new Pago();
                pago.id = int.Parse(s: pagosDataGridView.CurrentRow.Cells[0].Value.ToString());
                pagoBusiness.DeletePago(pago);
                LoadPagosData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void pdfpagosbutton_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pagos.PDF");

            try
            {
                iTextPDF PagosPDF = new iTextPDF();

                var document = PagosPDF.InitializePDF(path);

                document.Add(PagosPDF.GenerateHeaderPDF("Reporte inquilinos"));
                document.Add(PagosPDF.GenerateTablePDF(5, pagosDataGridView));

                document.Close();
                MessageBox.Show("PDF se genero correctamente en la carpeta Documentos!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void montoPagoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar))
            {
                MessageBox.Show("Solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}

