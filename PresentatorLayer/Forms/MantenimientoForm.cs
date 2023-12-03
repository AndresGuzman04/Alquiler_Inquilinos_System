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
    public partial class MantenimientoForm : Form
    {
        private bool isEditMode = false;
        public MantenimientoForm()
        {
            InitializeComponent();
            LoadMantenimientosData();
            LoadPropiedadComboBox();


        }
        private void LoadMantenimientosData()
        {
            MantenimientoBusiness mantenimientoBusiness = new MantenimientoBusiness();
            mantenimientoDataGridView.DataSource = mantenimientoBusiness.GetMantenimientos();

        }
        private void LoadPropiedadComboBox()
        {
            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();
            propiedadComboBox.DataSource = propiedadBusiness.GetPropiedad();

            propiedadComboBox.DisplayMember = "Nombre";
            propiedadComboBox.ValueMember = "ID";
        }
        private void ClearFormMantenimiento()
        {

            costoTextbox.Clear();
            descripcionTextBox.Clear();

        }

        private void guardarMantenimientoButton_Click(object sender, EventArgs e)
        {
            MantenimientoBusiness mantenimientoBusiness = new MantenimientoBusiness();
            Mantenimiento mantenimiento = new Mantenimiento();

            DateTime fechaSeleccionada = mantenimientoDateTimePicker.Value;
            mantenimiento.fechaMantenimiento = fechaSeleccionada;
            mantenimiento.costo = costoTextbox.Text;
            mantenimiento.descripcion = descripcionTextBox.Text;

            mantenimiento.propiedadId = (int)propiedadComboBox.SelectedValue;

            mantenimientoValidator mantenimientoValidator = new mantenimientoValidator();
            ValidationResult result = mantenimientoValidator.Validate(mantenimiento);


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
                    mantenimientoBusiness.AddMantenimiento(mantenimiento);
                    LoadMantenimientosData();
                    ClearFormMantenimiento();
                }
                else
                {

                    mantenimiento.id = int.Parse(s: mantenimientoDataGridView.CurrentRow.Cells[0].Value.ToString());

                    mantenimientoBusiness.Updatemantenimiento(mantenimiento);
                    LoadMantenimientosData();
                    ClearFormMantenimiento();
                    isEditMode = false;
                }

            }

        }

        private void eliminarMantenimientoButton_Click(object sender, EventArgs e)
        {
            if (mantenimientoDataGridView.SelectedRows.Count > 0)
            {

                MantenimientoBusiness mantenimientoBusiness = new MantenimientoBusiness();
                Mantenimiento mantenimiento = new Mantenimiento();
                mantenimiento.id = int.Parse(s: mantenimientoDataGridView.CurrentRow.Cells[0].Value.ToString());
                mantenimientoBusiness.DeleteMantenimiento(mantenimiento);
                LoadMantenimientosData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void editarMantenimientoButton_Click(object sender, EventArgs e)
        {
            if (mantenimientoDataGridView.SelectedRows.Count > 0)
            {

                string fechaString = mantenimientoDataGridView.CurrentRow.Cells[1].Value.ToString();
                DateTime fechaSeleccionada = DateTime.Parse(fechaString);
                mantenimientoDateTimePicker.Value = fechaSeleccionada;

                descripcionTextBox.Text = mantenimientoDataGridView.CurrentRow.Cells[2].Value.ToString();
                costoTextbox.Text = mantenimientoDataGridView.CurrentRow.Cells[3].Value.ToString();
                propiedadComboBox.SelectedValue = mantenimientoDataGridView.CurrentRow.Cells[4].Value.ToString();

                isEditMode = true;


            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void pdfMantenimientobutton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Manuel\Documents\Nueva carpeta\MantenimientoPDF";

            try
            {
                iTextPDF MantenimientoPDF = new iTextPDF();

                var document = MantenimientoPDF.InitializePDF(path);

                document.Add(MantenimientoPDF.GenerateHeaderPDF("Reporte del mantenimiento"));
                document.Add(MantenimientoPDF.GenerateTablePDF(5, mantenimientoDataGridView));

                document.Close();
                MessageBox.Show("PDF se genero correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void descripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void costoTextbox_KeyPress(object sender, KeyPressEventArgs e)
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
