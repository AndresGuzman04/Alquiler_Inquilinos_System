using BusinessLayer.Crud;
using CommonLayer;
using CommonLayer.Entities;
using PresentatorLayer.Validaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace PresentatorLayer.Forms
{
    public partial class LoginForm : Form
    {
        private bool isEditMode = false;
        public LoginForm()
        {
            InitializeComponent();
            Loads();

        }

        public void Loads()
        {

            rentasControl.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTabIndex = rentasControl.SelectedIndex;

            switch (selectedTabIndex)
            {
                case 0:
                    LoadContratosData();
                    LoadInquilinoComboBox();
                    LoadPropiedadComboBox();
                    break;
                case 1:
                    LoadIquilinos();
                    break;
                case 2:
                    LoadMantenimientosData();
                    LoadPropiedadComboBox();
                    break;
                case 3:
                    LoadPagosData();
                    LoadContratoComboBox();
                    break;
                case 4:
                    LoadPropiedadData();
                    break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lockedTexbox()
        {

            if (isEditMode == false)
            {
                textBoxPrecioMensualPropiedad.ReadOnly = false;
                montoPagoTextBox.ReadOnly = false;
                contratoComboBox.Enabled = true;
            }
            else
            {
                textBoxPrecioMensualPropiedad.ReadOnly = true;
                montoPagoTextBox.ReadOnly = true;
                contratoComboBox.Enabled = false;
            }

        }


        private void LoadMantenimientosData()
        {
            MantenimientoBusiness mantenimientoBusiness = new MantenimientoBusiness();
            mantenimientoDataGridView.DataSource = mantenimientoBusiness.GetMantenimientos();

        }
        private void LoadPagosData()
        {
            PagoBusiness pagoBusiness = new PagoBusiness();
            pagosDataGridView.DataSource = pagoBusiness.GetPagos();


        }
        private void LoadPropiedadData()
        {
            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();

            dgvPropiedades.DataSource = propiedadBusiness.GetPropiedad();
        }

        private void LoadPropiedadComboBox()
        {

            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();
            propiedadComboBox.DataSource = propiedadBusiness.GetPropiedad();

            propiedadComBo.DataSource = propiedadBusiness.GetPropiedad();

            propiedadComboBox.DisplayMember = "Nombre";
            propiedadComboBox.ValueMember = "PropiedadID";

            propiedadComBo.DisplayMember = "Nombre";
            propiedadComBo.ValueMember = "PropiedadID";

        }
        private void LoadInquilinoComboBox()
        {

            InquilinoBusiness inquilinoBusiness = new InquilinoBusiness();
            InquilinocomboBox.DataSource = inquilinoBusiness.GetInquilinos();


            propiedadComBo.DisplayMember = "Nombre";
            propiedadComBo.ValueMember = "InquilinoID";

        }
        private void LoadContratoComboBox()
        {

            ContratosBusiness contratoBusiness = new ContratosBusiness();
            contratoComboBox.DataSource = contratoBusiness.GetContratos();
            contratoComboBox.DisplayMember = "ContratoID";
            contratoComboBox.ValueMember = "ContratoID";

        }

        public void LoadIquilinos()
        {
            InquilinoBusiness inquilinoBussiness = new InquilinoBusiness();
            inquilinosdataGridView.DataSource = null;
            inquilinosdataGridView.DataSource = inquilinoBussiness.GetInquilinos();
            inquilinosdataGridView.Columns["InquilinoID"].HeaderText = "ID";
        }
        private void LoadContratosData()
        {
            ContratosBusiness contratosBusiness = new ContratosBusiness();
            contratosdataGridView.DataSource = contratosBusiness.GetContratos();

        }



        private void ClearFormMantenimiento()
        {

            costoTextbox.Clear();
            descripcionTextBox.Clear();

        }
        private void ClearFormPago()
        {

            montoPagoTextBox.Clear();

        }
        private void clearPropiedad()
        {
            textboxNombrePropiedad.Clear();
            textBoxDireccionPropiedad.Clear();
            textBoxTipoPropiedadPropiedad.Clear();
            textBoxPrecioMensualPropiedad.Clear();
        }
        private void ClearFormInquilino()
        {
            nombreTextBox.Clear();
            emailTextBox.Clear();
            telefonoTextbox.Clear();
            direccionTextBox.Clear();

        }
        private void ClearFormContratos()
        {
            montomensualtextBox.Clear();
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

                    pago.id = int.Parse(s: pagosDataGridView.CurrentRow.Cells[0].Value.ToString());

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
                    lockedTexbox();
                }
            }
        }

        private void btnEditarPropiedad_Click_1(object sender, EventArgs e)
        {
            if (dgvPropiedades.SelectedRows.Count > 0)
            {
                textboxNombrePropiedad.Text = dgvPropiedades.CurrentRow.Cells[1].Value.ToString();
                textBoxDireccionPropiedad.Text = dgvPropiedades.CurrentRow.Cells[2].Value.ToString();
                textBoxTipoPropiedadPropiedad.Text = dgvPropiedades.CurrentRow.Cells[3].Value.ToString();
                textBoxPrecioMensualPropiedad.Text = dgvPropiedades.CurrentRow.Cells[4].Value.ToString();

                isEditMode = true;
                lockedTexbox();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para poder editar");
            }


        }

        private void btnEliminarPropiedad_Click_1(object sender, EventArgs e)
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            PropiedadBusiness propiedadBusiness = new PropiedadBusiness();
            dgvPropiedades.DataSource = propiedadBusiness.SearchPropiedad(txtBuscar.Text);
        }

        private void guardarInquilinoButton_Click(object sender, EventArgs e)
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

        private void editarInquilinoButton_Click(object sender, EventArgs e)
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

        private void eliminarInquilinoButton_Click(object sender, EventArgs e)
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
