using BusinessLayer.Crud;
using CommonLayer;
using FluentValidation.Results;
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
    public partial class PropiedadesForm : Form
    {
        private bool isEditMode = false;
        public PropiedadesForm()
        {
            InitializeComponent();
            LoadPropiedadData();
        }
        private void LoadPropiedadData()
        {
            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();

            dgvPropiedades.DataSource = propiedadBusiness.GetPropiedad();
        }
        private void clearPropiedad()
        {
            textboxNombrePropiedad.Clear();
            textBoxDireccionPropiedad.Clear();
            textBoxTipoPropiedadPropiedad.Clear();
            textBoxPrecioMensualPropiedad.Clear();
        }

        private void btnGuardarPropiedad_Click_1(object sender, EventArgs e)
        {
            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();
            Propiedad propiedad = new Propiedad();

            propiedad.Nombre = textboxNombrePropiedad.Text;
            propiedad.Direccion = textBoxDireccionPropiedad.Text;
            propiedad.TipoPropiedad = textBoxTipoPropiedadPropiedad.Text;
            propiedad.PagoMensual = textBoxPrecioMensualPropiedad.Text;

            PropiedadesValidator propiedadValidator = new PropiedadesValidator();
            ValidationResult result = propiedadValidator.Validate(propiedad);


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
                    propiedadBusiness.AddPropiedad(propiedad);
                    LoadPropiedadData();
                    clearPropiedad();
                }
                else
                {

                    propiedad.id = int.Parse(s: dgvPropiedades.CurrentRow.Cells[0].Value.ToString());
                    propiedadBusiness.UpdatePropiedad(propiedad);
                    LoadPropiedadData();
                    clearPropiedad();

                    isEditMode = false;

                }
            }
        }

        private void btnEliminarPropiedad_Click(object sender, EventArgs e)
        {
            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();
            Propiedad propiedad = new Propiedad();

            if (dgvPropiedades.SelectedRows.Count > 0)
            {
                propiedad.id = int.Parse(dgvPropiedades.CurrentRow.Cells[0].Value.ToString());

                propiedadBusiness.DeletePropiedad(propiedad);

                LoadPropiedadData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }

        private void btnEditarPropiedad_Click(object sender, EventArgs e)
        {
            if (dgvPropiedades.SelectedRows.Count > 0)
            {
                textboxNombrePropiedad.Text = dgvPropiedades.CurrentRow.Cells[1].Value.ToString();
                textBoxDireccionPropiedad.Text = dgvPropiedades.CurrentRow.Cells[2].Value.ToString();
                textBoxTipoPropiedadPropiedad.Text = dgvPropiedades.CurrentRow.Cells[3].Value.ToString();
                textBoxPrecioMensualPropiedad.Text = dgvPropiedades.CurrentRow.Cells[4].Value.ToString();

                isEditMode = true;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para poder editar");
            }
        }
    }
}
