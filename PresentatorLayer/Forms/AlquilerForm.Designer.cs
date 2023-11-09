namespace PresentatorLayer.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            encabezadoPanel = new Panel();
            closeButton = new Button();
            tituloLabel = new Label();
            rentasControl = new TabControl();
            Contratos = new TabPage();
            label16 = new Label();
            editarcontratosbutton = new Button();
            eliminarcontratosbutton = new Button();
            guardarcontratosbutton = new Button();
            InquilinocomboBox = new ComboBox();
            propiedadComBo = new ComboBox();
            inquilinolabel = new Label();
            prpiedadlabel = new Label();
            fechafindateTimePicker = new DateTimePicker();
            fechainiciodateTimePicker = new DateTimePicker();
            label13 = new Label();
            montomensualtextBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            contratosdataGridView = new DataGridView();
            Inquilinos = new TabPage();
            label18 = new Label();
            direccionTextBox = new TextBox();
            direccionlabel = new Label();
            editarInquilinoButton = new Button();
            eliminarInquilinoButton = new Button();
            telefonoTextbox = new TextBox();
            emailTextBox = new TextBox();
            emaillabel = new Label();
            label17 = new Label();
            guardarInquilinoButton = new Button();
            nombreTextBox = new TextBox();
            nombrelabel = new Label();
            inquilinosdataGridView = new DataGridView();
            Mantenimiento = new TabPage();
            mantenimientoDateTimePicker = new DateTimePicker();
            costoTextbox = new TextBox();
            label9 = new Label();
            propiedadComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            mantenimientoDataGridView = new DataGridView();
            editarMantenimientoButton = new Button();
            eliminarMantenimientoButton = new Button();
            guardarMantenimientoButton = new Button();
            descripcionTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            Pagos = new TabPage();
            pagoDateTimePicker = new DateTimePicker();
            contratoComboBox = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            pagosDataGridView = new DataGridView();
            editarPagoButton = new Button();
            eliminarPagoButton = new Button();
            guardarPagoButton = new Button();
            montoPagoTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Propiedades = new TabPage();
            labelPropiedad = new Label();
            txtId = new TextBox();
            label12 = new Label();
            txtBuscar = new TextBox();
            label11 = new Label();
            btnEliminarPropiedad = new Button();
            btnEditarPropiedad = new Button();
            btnGuardarPropiedad = new Button();
            labelPrecioMensual = new Label();
            labelTipoPropiedad = new Label();
            labelDireccion = new Label();
            textBoxPrecioMensualPropiedad = new TextBox();
            textBoxTipoPropiedadPropiedad = new TextBox();
            textBoxDireccionPropiedad = new TextBox();
            textboxNombrePropiedad = new TextBox();
            label10 = new Label();
            dgvPropiedades = new DataGridView();
            encabezadoPanel.SuspendLayout();
            rentasControl.SuspendLayout();
            Contratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contratosdataGridView).BeginInit();
            Inquilinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inquilinosdataGridView).BeginInit();
            Mantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mantenimientoDataGridView).BeginInit();
            Pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pagosDataGridView).BeginInit();
            Propiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            SuspendLayout();
            // 
            // encabezadoPanel
            // 
            encabezadoPanel.BackColor = Color.Gray;
            encabezadoPanel.Controls.Add(closeButton);
            encabezadoPanel.Controls.Add(tituloLabel);
            encabezadoPanel.Dock = DockStyle.Top;
            encabezadoPanel.Location = new Point(0, 0);
            encabezadoPanel.Name = "encabezadoPanel";
            encabezadoPanel.Size = new Size(1100, 63);
            encabezadoPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderColor = Color.White;
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1030, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(70, 63);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLabel.ForeColor = Color.White;
            tituloLabel.Location = new Point(12, 9);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(407, 38);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Sistema de Rentas de Alquiler";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rentasControl
            // 
            rentasControl.Controls.Add(Contratos);
            rentasControl.Controls.Add(Inquilinos);
            rentasControl.Controls.Add(Mantenimiento);
            rentasControl.Controls.Add(Pagos);
            rentasControl.Controls.Add(Propiedades);
            rentasControl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rentasControl.Location = new Point(0, 69);
            rentasControl.Name = "rentasControl";
            rentasControl.SelectedIndex = 0;
            rentasControl.Size = new Size(1100, 483);
            rentasControl.TabIndex = 1;
            // 
            // Contratos
            // 
            Contratos.BackColor = Color.Silver;
            Contratos.CausesValidation = false;
            Contratos.Controls.Add(label16);
            Contratos.Controls.Add(editarcontratosbutton);
            Contratos.Controls.Add(eliminarcontratosbutton);
            Contratos.Controls.Add(guardarcontratosbutton);
            Contratos.Controls.Add(InquilinocomboBox);
            Contratos.Controls.Add(propiedadComBo);
            Contratos.Controls.Add(inquilinolabel);
            Contratos.Controls.Add(prpiedadlabel);
            Contratos.Controls.Add(fechafindateTimePicker);
            Contratos.Controls.Add(fechainiciodateTimePicker);
            Contratos.Controls.Add(label13);
            Contratos.Controls.Add(montomensualtextBox);
            Contratos.Controls.Add(label14);
            Contratos.Controls.Add(label15);
            Contratos.Controls.Add(contratosdataGridView);
            Contratos.ForeColor = SystemColors.GrayText;
            Contratos.Location = new Point(4, 37);
            Contratos.Name = "Contratos";
            Contratos.Size = new Size(1092, 442);
            Contratos.TabIndex = 0;
            Contratos.Text = "Contratos";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(13, 30);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(186, 28);
            label16.TabIndex = 59;
            label16.Text = "Lista De Contratos";
            // 
            // editarcontratosbutton
            // 
            editarcontratosbutton.ForeColor = Color.DimGray;
            editarcontratosbutton.Location = new Point(751, 358);
            editarcontratosbutton.Margin = new Padding(4);
            editarcontratosbutton.Name = "editarcontratosbutton";
            editarcontratosbutton.Size = new Size(143, 41);
            editarcontratosbutton.TabIndex = 56;
            editarcontratosbutton.Text = "Editar";
            editarcontratosbutton.UseVisualStyleBackColor = true;
            // 
            // eliminarcontratosbutton
            // 
            eliminarcontratosbutton.ForeColor = Color.DimGray;
            eliminarcontratosbutton.Location = new Point(902, 358);
            eliminarcontratosbutton.Margin = new Padding(4);
            eliminarcontratosbutton.Name = "eliminarcontratosbutton";
            eliminarcontratosbutton.Size = new Size(143, 41);
            eliminarcontratosbutton.TabIndex = 58;
            eliminarcontratosbutton.Text = "Eliminar";
            eliminarcontratosbutton.UseVisualStyleBackColor = true;
            // 
            // guardarcontratosbutton
            // 
            guardarcontratosbutton.ForeColor = Color.DimGray;
            guardarcontratosbutton.Location = new Point(600, 358);
            guardarcontratosbutton.Margin = new Padding(4);
            guardarcontratosbutton.Name = "guardarcontratosbutton";
            guardarcontratosbutton.Size = new Size(143, 41);
            guardarcontratosbutton.TabIndex = 57;
            guardarcontratosbutton.Text = "Guardar";
            guardarcontratosbutton.UseVisualStyleBackColor = true;
            guardarcontratosbutton.Click += guardarcontratosbutton_Click;
            // 
            // InquilinocomboBox
            // 
            InquilinocomboBox.FormattingEnabled = true;
            InquilinocomboBox.Location = new Point(567, 242);
            InquilinocomboBox.Name = "InquilinocomboBox";
            InquilinocomboBox.Size = new Size(250, 36);
            InquilinocomboBox.TabIndex = 55;
            // 
            // propiedadComBo
            // 
            propiedadComBo.FormattingEnabled = true;
            propiedadComBo.Location = new Point(823, 153);
            propiedadComBo.Name = "propiedadComBo";
            propiedadComBo.Size = new Size(250, 36);
            propiedadComBo.TabIndex = 54;
            // 
            // inquilinolabel
            // 
            inquilinolabel.AutoSize = true;
            inquilinolabel.ForeColor = SystemColors.ControlDarkDark;
            inquilinolabel.Location = new Point(567, 211);
            inquilinolabel.Name = "inquilinolabel";
            inquilinolabel.Size = new Size(101, 28);
            inquilinolabel.TabIndex = 53;
            inquilinolabel.Text = "Inquilino:";
            // 
            // prpiedadlabel
            // 
            prpiedadlabel.AutoSize = true;
            prpiedadlabel.ForeColor = SystemColors.ControlDarkDark;
            prpiedadlabel.Location = new Point(823, 124);
            prpiedadlabel.Name = "prpiedadlabel";
            prpiedadlabel.Size = new Size(108, 28);
            prpiedadlabel.TabIndex = 52;
            prpiedadlabel.Text = "Propiedad";
            // 
            // fechafindateTimePicker
            // 
            fechafindateTimePicker.Location = new Point(823, 78);
            fechafindateTimePicker.Name = "fechafindateTimePicker";
            fechafindateTimePicker.Size = new Size(250, 34);
            fechafindateTimePicker.TabIndex = 51;
            // 
            // fechainiciodateTimePicker
            // 
            fechainiciodateTimePicker.Location = new Point(567, 78);
            fechainiciodateTimePicker.Name = "fechainiciodateTimePicker";
            fechainiciodateTimePicker.Size = new Size(250, 34);
            fechainiciodateTimePicker.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(823, 44);
            label13.Name = "label13";
            label13.Size = new Size(100, 28);
            label13.TabIndex = 47;
            label13.Text = "Fecha Fin";
            // 
            // montomensualtextBox
            // 
            montomensualtextBox.Location = new Point(567, 155);
            montomensualtextBox.Name = "montomensualtextBox";
            montomensualtextBox.Size = new Size(250, 34);
            montomensualtextBox.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(567, 124);
            label14.Name = "label14";
            label14.Size = new Size(161, 28);
            label14.TabIndex = 48;
            label14.Text = "Monto Mensual";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Silver;
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(567, 44);
            label15.Name = "label15";
            label15.Size = new Size(124, 28);
            label15.TabIndex = 46;
            label15.Text = "Fecha Inicio";
            // 
            // contratosdataGridView
            // 
            contratosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contratosdataGridView.Location = new Point(13, 61);
            contratosdataGridView.Name = "contratosdataGridView";
            contratosdataGridView.RowHeadersWidth = 51;
            contratosdataGridView.RowTemplate.Height = 29;
            contratosdataGridView.Size = new Size(548, 338);
            contratosdataGridView.TabIndex = 45;
            // 
            // Inquilinos
            // 
            Inquilinos.BackColor = Color.Silver;
            Inquilinos.Controls.Add(label18);
            Inquilinos.Controls.Add(direccionTextBox);
            Inquilinos.Controls.Add(direccionlabel);
            Inquilinos.Controls.Add(editarInquilinoButton);
            Inquilinos.Controls.Add(eliminarInquilinoButton);
            Inquilinos.Controls.Add(telefonoTextbox);
            Inquilinos.Controls.Add(emailTextBox);
            Inquilinos.Controls.Add(emaillabel);
            Inquilinos.Controls.Add(label17);
            Inquilinos.Controls.Add(guardarInquilinoButton);
            Inquilinos.Controls.Add(nombreTextBox);
            Inquilinos.Controls.Add(nombrelabel);
            Inquilinos.Controls.Add(inquilinosdataGridView);
            Inquilinos.ForeColor = Color.Gray;
            Inquilinos.Location = new Point(4, 37);
            Inquilinos.Name = "Inquilinos";
            Inquilinos.Size = new Size(1092, 442);
            Inquilinos.TabIndex = 1;
            Inquilinos.Text = "Inquilinos";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(19, 28);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(187, 28);
            label18.TabIndex = 60;
            label18.Text = "Lista De Inquilinos";
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(602, 213);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(214, 34);
            direccionTextBox.TabIndex = 23;
            // 
            // direccionlabel
            // 
            direccionlabel.AutoSize = true;
            direccionlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            direccionlabel.ForeColor = SystemColors.ControlDarkDark;
            direccionlabel.Location = new Point(602, 165);
            direccionlabel.Name = "direccionlabel";
            direccionlabel.Size = new Size(116, 31);
            direccionlabel.TabIndex = 22;
            direccionlabel.Text = "Direccion";
            // 
            // editarInquilinoButton
            // 
            editarInquilinoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            editarInquilinoButton.ForeColor = SystemColors.ControlDarkDark;
            editarInquilinoButton.Location = new Point(623, 369);
            editarInquilinoButton.Name = "editarInquilinoButton";
            editarInquilinoButton.Size = new Size(118, 41);
            editarInquilinoButton.TabIndex = 21;
            editarInquilinoButton.Text = "Editar";
            editarInquilinoButton.UseVisualStyleBackColor = true;
            editarInquilinoButton.Click += editarInquilinoButton_Click;
            // 
            // eliminarInquilinoButton
            // 
            eliminarInquilinoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarInquilinoButton.ForeColor = SystemColors.ControlDarkDark;
            eliminarInquilinoButton.Location = new Point(923, 369);
            eliminarInquilinoButton.Name = "eliminarInquilinoButton";
            eliminarInquilinoButton.Size = new Size(119, 41);
            eliminarInquilinoButton.TabIndex = 20;
            eliminarInquilinoButton.Text = "Eliminar";
            eliminarInquilinoButton.UseVisualStyleBackColor = true;
            eliminarInquilinoButton.Click += eliminarInquilinoButton_Click;
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.Location = new Point(845, 213);
            telefonoTextbox.Name = "telefonoTextbox";
            telefonoTextbox.Size = new Size(214, 34);
            telefonoTextbox.TabIndex = 19;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(845, 104);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(214, 34);
            emailTextBox.TabIndex = 18;
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            emaillabel.ForeColor = SystemColors.ControlDarkDark;
            emaillabel.Location = new Point(845, 179);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(107, 31);
            emaillabel.TabIndex = 17;
            emaillabel.Text = "Telefono";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(845, 59);
            label17.Name = "label17";
            label17.Size = new Size(73, 31);
            label17.TabIndex = 16;
            label17.Text = "Email";
            // 
            // guardarInquilinoButton
            // 
            guardarInquilinoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            guardarInquilinoButton.ForeColor = SystemColors.ControlDarkDark;
            guardarInquilinoButton.Location = new Point(775, 369);
            guardarInquilinoButton.Name = "guardarInquilinoButton";
            guardarInquilinoButton.Size = new Size(119, 41);
            guardarInquilinoButton.TabIndex = 15;
            guardarInquilinoButton.Text = "Guardar";
            guardarInquilinoButton.UseVisualStyleBackColor = true;
            guardarInquilinoButton.Click += guardarInquilinoButton_Click;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(602, 104);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(214, 34);
            nombreTextBox.TabIndex = 14;
            // 
            // nombrelabel
            // 
            nombrelabel.AutoSize = true;
            nombrelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nombrelabel.ForeColor = SystemColors.ControlDarkDark;
            nombrelabel.Location = new Point(602, 59);
            nombrelabel.Name = "nombrelabel";
            nombrelabel.Size = new Size(102, 31);
            nombrelabel.TabIndex = 13;
            nombrelabel.Text = "Nombre";
            // 
            // inquilinosdataGridView
            // 
            inquilinosdataGridView.BackgroundColor = SystemColors.AppWorkspace;
            inquilinosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inquilinosdataGridView.Location = new Point(19, 59);
            inquilinosdataGridView.Name = "inquilinosdataGridView";
            inquilinosdataGridView.RowHeadersWidth = 51;
            inquilinosdataGridView.RowTemplate.Height = 29;
            inquilinosdataGridView.Size = new Size(577, 351);
            inquilinosdataGridView.TabIndex = 12;
            // 
            // Mantenimiento
            // 
            Mantenimiento.BackColor = Color.Silver;
            Mantenimiento.Controls.Add(mantenimientoDateTimePicker);
            Mantenimiento.Controls.Add(costoTextbox);
            Mantenimiento.Controls.Add(label9);
            Mantenimiento.Controls.Add(propiedadComboBox);
            Mantenimiento.Controls.Add(label4);
            Mantenimiento.Controls.Add(label5);
            Mantenimiento.Controls.Add(mantenimientoDataGridView);
            Mantenimiento.Controls.Add(editarMantenimientoButton);
            Mantenimiento.Controls.Add(eliminarMantenimientoButton);
            Mantenimiento.Controls.Add(guardarMantenimientoButton);
            Mantenimiento.Controls.Add(descripcionTextBox);
            Mantenimiento.Controls.Add(label7);
            Mantenimiento.Controls.Add(label8);
            Mantenimiento.ForeColor = Color.Gray;
            Mantenimiento.Location = new Point(4, 37);
            Mantenimiento.Name = "Mantenimiento";
            Mantenimiento.Size = new Size(1092, 442);
            Mantenimiento.TabIndex = 2;
            Mantenimiento.Text = "Mantenimiento";
            // 
            // mantenimientoDateTimePicker
            // 
            mantenimientoDateTimePicker.Location = new Point(635, 84);
            mantenimientoDateTimePicker.Name = "mantenimientoDateTimePicker";
            mantenimientoDateTimePicker.Size = new Size(445, 34);
            mantenimientoDateTimePicker.TabIndex = 36;
            // 
            // costoTextbox
            // 
            costoTextbox.Location = new Point(635, 302);
            costoTextbox.Margin = new Padding(4);
            costoTextbox.Name = "costoTextbox";
            costoTextbox.Size = new Size(186, 34);
            costoTextbox.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(635, 270);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 34;
            label9.Text = "Costo:";
            // 
            // propiedadComboBox
            // 
            propiedadComboBox.FormattingEnabled = true;
            propiedadComboBox.Location = new Point(894, 302);
            propiedadComboBox.Name = "propiedadComboBox";
            propiedadComboBox.Size = new Size(186, 36);
            propiedadComboBox.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(894, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 32;
            label4.Text = "Propiedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(9, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(249, 28);
            label5.TabIndex = 31;
            label5.Text = "Lista De Mantenimientos";
            // 
            // mantenimientoDataGridView
            // 
            mantenimientoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mantenimientoDataGridView.Location = new Point(9, 52);
            mantenimientoDataGridView.Margin = new Padding(4);
            mantenimientoDataGridView.Name = "mantenimientoDataGridView";
            mantenimientoDataGridView.RowHeadersWidth = 51;
            mantenimientoDataGridView.RowTemplate.Height = 29;
            mantenimientoDataGridView.Size = new Size(603, 365);
            mantenimientoDataGridView.TabIndex = 27;
            // 
            // editarMantenimientoButton
            // 
            editarMantenimientoButton.ForeColor = Color.DimGray;
            editarMantenimientoButton.Location = new Point(786, 376);
            editarMantenimientoButton.Margin = new Padding(4);
            editarMantenimientoButton.Name = "editarMantenimientoButton";
            editarMantenimientoButton.Size = new Size(143, 41);
            editarMantenimientoButton.TabIndex = 28;
            editarMantenimientoButton.Text = "Editar";
            editarMantenimientoButton.UseVisualStyleBackColor = true;
            editarMantenimientoButton.Click += editarMantenimientoButton_Click;
            // 
            // eliminarMantenimientoButton
            // 
            eliminarMantenimientoButton.ForeColor = Color.DimGray;
            eliminarMantenimientoButton.Location = new Point(937, 376);
            eliminarMantenimientoButton.Margin = new Padding(4);
            eliminarMantenimientoButton.Name = "eliminarMantenimientoButton";
            eliminarMantenimientoButton.Size = new Size(143, 41);
            eliminarMantenimientoButton.TabIndex = 30;
            eliminarMantenimientoButton.Text = "Eliminar";
            eliminarMantenimientoButton.UseVisualStyleBackColor = true;
            eliminarMantenimientoButton.Click += eliminarMantenimientoButton_Click;
            // 
            // guardarMantenimientoButton
            // 
            guardarMantenimientoButton.ForeColor = Color.DimGray;
            guardarMantenimientoButton.Location = new Point(635, 376);
            guardarMantenimientoButton.Margin = new Padding(4);
            guardarMantenimientoButton.Name = "guardarMantenimientoButton";
            guardarMantenimientoButton.Size = new Size(143, 41);
            guardarMantenimientoButton.TabIndex = 29;
            guardarMantenimientoButton.Text = "Guardar";
            guardarMantenimientoButton.UseVisualStyleBackColor = true;
            guardarMantenimientoButton.Click += guardarMantenimientoButton_Click;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(635, 194);
            descripcionTextBox.Margin = new Padding(4);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(445, 34);
            descripcionTextBox.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(635, 52);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(223, 28);
            label7.TabIndex = 24;
            label7.Text = "Fecha Mantenimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(635, 162);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 23;
            label8.Text = "Descripcion:";
            // 
            // Pagos
            // 
            Pagos.BackColor = Color.Silver;
            Pagos.Controls.Add(pagoDateTimePicker);
            Pagos.Controls.Add(contratoComboBox);
            Pagos.Controls.Add(label3);
            Pagos.Controls.Add(label6);
            Pagos.Controls.Add(pagosDataGridView);
            Pagos.Controls.Add(editarPagoButton);
            Pagos.Controls.Add(eliminarPagoButton);
            Pagos.Controls.Add(guardarPagoButton);
            Pagos.Controls.Add(montoPagoTextBox);
            Pagos.Controls.Add(label1);
            Pagos.Controls.Add(label2);
            Pagos.ForeColor = Color.Gray;
            Pagos.Location = new Point(4, 37);
            Pagos.Name = "Pagos";
            Pagos.Size = new Size(1092, 442);
            Pagos.TabIndex = 3;
            Pagos.Text = "Pagos";
            // 
            // pagoDateTimePicker
            // 
            pagoDateTimePicker.Location = new Point(635, 194);
            pagoDateTimePicker.Name = "pagoDateTimePicker";
            pagoDateTimePicker.Size = new Size(436, 34);
            pagoDateTimePicker.TabIndex = 23;
            // 
            // contratoComboBox
            // 
            contratoComboBox.FormattingEnabled = true;
            contratoComboBox.Location = new Point(885, 84);
            contratoComboBox.Name = "contratoComboBox";
            contratoComboBox.Size = new Size(186, 36);
            contratoComboBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(885, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 20;
            label3.Text = "Contrato:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(9, 20);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 28);
            label6.TabIndex = 19;
            label6.Text = "Lista De Pagos";
            // 
            // pagosDataGridView
            // 
            pagosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pagosDataGridView.Location = new Point(9, 52);
            pagosDataGridView.Margin = new Padding(4);
            pagosDataGridView.Name = "pagosDataGridView";
            pagosDataGridView.RowHeadersWidth = 51;
            pagosDataGridView.RowTemplate.Height = 29;
            pagosDataGridView.Size = new Size(603, 365);
            pagosDataGridView.TabIndex = 15;
            // 
            // editarPagoButton
            // 
            editarPagoButton.ForeColor = Color.DimGray;
            editarPagoButton.Location = new Point(786, 376);
            editarPagoButton.Margin = new Padding(4);
            editarPagoButton.Name = "editarPagoButton";
            editarPagoButton.Size = new Size(143, 41);
            editarPagoButton.TabIndex = 16;
            editarPagoButton.Text = "Editar";
            editarPagoButton.UseVisualStyleBackColor = true;
            editarPagoButton.Click += editarPagoButton_Click;
            // 
            // eliminarPagoButton
            // 
            eliminarPagoButton.ForeColor = Color.DimGray;
            eliminarPagoButton.Location = new Point(937, 376);
            eliminarPagoButton.Margin = new Padding(4);
            eliminarPagoButton.Name = "eliminarPagoButton";
            eliminarPagoButton.Size = new Size(143, 41);
            eliminarPagoButton.TabIndex = 18;
            eliminarPagoButton.Text = "Eliminar";
            eliminarPagoButton.UseVisualStyleBackColor = true;
            eliminarPagoButton.Click += eliminarPagoButton_Click;
            // 
            // guardarPagoButton
            // 
            guardarPagoButton.ForeColor = Color.DimGray;
            guardarPagoButton.Location = new Point(635, 376);
            guardarPagoButton.Margin = new Padding(4);
            guardarPagoButton.Name = "guardarPagoButton";
            guardarPagoButton.Size = new Size(143, 41);
            guardarPagoButton.TabIndex = 17;
            guardarPagoButton.Text = "Guardar";
            guardarPagoButton.UseVisualStyleBackColor = true;
            guardarPagoButton.Click += guardarPagoButton_Click;
            // 
            // montoPagoTextBox
            // 
            montoPagoTextBox.Location = new Point(635, 84);
            montoPagoTextBox.Margin = new Padding(4);
            montoPagoTextBox.Name = "montoPagoTextBox";
            montoPagoTextBox.Size = new Size(186, 34);
            montoPagoTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(635, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 12;
            label1.Text = "Monto A Pagar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(635, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 11;
            label2.Text = "Fecha De Pago:";
            // 
            // Propiedades
            // 
            Propiedades.BackColor = Color.Silver;
            Propiedades.Controls.Add(labelPropiedad);
            Propiedades.Controls.Add(txtId);
            Propiedades.Controls.Add(label12);
            Propiedades.Controls.Add(txtBuscar);
            Propiedades.Controls.Add(label11);
            Propiedades.Controls.Add(btnEliminarPropiedad);
            Propiedades.Controls.Add(btnEditarPropiedad);
            Propiedades.Controls.Add(btnGuardarPropiedad);
            Propiedades.Controls.Add(labelPrecioMensual);
            Propiedades.Controls.Add(labelTipoPropiedad);
            Propiedades.Controls.Add(labelDireccion);
            Propiedades.Controls.Add(textBoxPrecioMensualPropiedad);
            Propiedades.Controls.Add(textBoxTipoPropiedadPropiedad);
            Propiedades.Controls.Add(textBoxDireccionPropiedad);
            Propiedades.Controls.Add(textboxNombrePropiedad);
            Propiedades.Controls.Add(label10);
            Propiedades.Controls.Add(dgvPropiedades);
            Propiedades.ForeColor = Color.Gray;
            Propiedades.Location = new Point(4, 37);
            Propiedades.Name = "Propiedades";
            Propiedades.Size = new Size(1092, 442);
            Propiedades.TabIndex = 4;
            Propiedades.Text = "Propiedades";
            // 
            // labelPropiedad
            // 
            labelPropiedad.AutoSize = true;
            labelPropiedad.ForeColor = Color.DimGray;
            labelPropiedad.Location = new Point(18, 26);
            labelPropiedad.Margin = new Padding(4, 0, 4, 0);
            labelPropiedad.Name = "labelPropiedad";
            labelPropiedad.Size = new Size(178, 28);
            labelPropiedad.TabIndex = 49;
            labelPropiedad.Text = "Lista Propiedades";
            // 
            // txtId
            // 
            txtId.Location = new Point(1001, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 34);
            txtId.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(966, 36);
            label12.Name = "label12";
            label12.Size = new Size(35, 28);
            label12.TabIndex = 47;
            label12.Text = "Id:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(723, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(218, 34);
            txtBuscar.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(652, 39);
            label11.Name = "label11";
            label11.Size = new Size(81, 28);
            label11.TabIndex = 45;
            label11.Text = "Buscar:";
            // 
            // btnEliminarPropiedad
            // 
            btnEliminarPropiedad.ForeColor = Color.DimGray;
            btnEliminarPropiedad.Location = new Point(931, 329);
            btnEliminarPropiedad.Margin = new Padding(4);
            btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            btnEliminarPropiedad.Size = new Size(143, 41);
            btnEliminarPropiedad.TabIndex = 44;
            btnEliminarPropiedad.Text = "Eliminar";
            btnEliminarPropiedad.UseVisualStyleBackColor = true;
            btnEliminarPropiedad.Click += btnEliminarPropiedad_Click_1;
            // 
            // btnEditarPropiedad
            // 
            btnEditarPropiedad.ForeColor = Color.DimGray;
            btnEditarPropiedad.Location = new Point(780, 329);
            btnEditarPropiedad.Margin = new Padding(4);
            btnEditarPropiedad.Name = "btnEditarPropiedad";
            btnEditarPropiedad.Size = new Size(143, 41);
            btnEditarPropiedad.TabIndex = 43;
            btnEditarPropiedad.Text = "Editar";
            btnEditarPropiedad.UseVisualStyleBackColor = true;
            btnEditarPropiedad.Click += btnEditarPropiedad_Click_1;
            // 
            // btnGuardarPropiedad
            // 
            btnGuardarPropiedad.ForeColor = Color.DimGray;
            btnGuardarPropiedad.Location = new Point(629, 329);
            btnGuardarPropiedad.Margin = new Padding(4);
            btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            btnGuardarPropiedad.Size = new Size(143, 41);
            btnGuardarPropiedad.TabIndex = 42;
            btnGuardarPropiedad.Text = "Guardar";
            btnGuardarPropiedad.UseVisualStyleBackColor = true;
            btnGuardarPropiedad.Click += btnGuardarPropiedad_Click_1;
            // 
            // labelPrecioMensual
            // 
            labelPrecioMensual.AutoSize = true;
            labelPrecioMensual.ForeColor = Color.DimGray;
            labelPrecioMensual.Location = new Point(893, 209);
            labelPrecioMensual.Margin = new Padding(4, 0, 4, 0);
            labelPrecioMensual.Name = "labelPrecioMensual";
            labelPrecioMensual.Size = new Size(157, 28);
            labelPrecioMensual.TabIndex = 41;
            labelPrecioMensual.Text = "Precio Mensual";
            // 
            // labelTipoPropiedad
            // 
            labelTipoPropiedad.AutoSize = true;
            labelTipoPropiedad.ForeColor = Color.DimGray;
            labelTipoPropiedad.Location = new Point(668, 209);
            labelTipoPropiedad.Margin = new Padding(4, 0, 4, 0);
            labelTipoPropiedad.Name = "labelTipoPropiedad";
            labelTipoPropiedad.Size = new Size(156, 28);
            labelTipoPropiedad.TabIndex = 40;
            labelTipoPropiedad.Text = "Tipo propiedad";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.ForeColor = Color.DimGray;
            labelDireccion.Location = new Point(912, 95);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(102, 28);
            labelDireccion.TabIndex = 39;
            labelDireccion.Text = "Direccion";
            // 
            // textBoxPrecioMensualPropiedad
            // 
            textBoxPrecioMensualPropiedad.Location = new Point(875, 247);
            textBoxPrecioMensualPropiedad.Margin = new Padding(4);
            textBoxPrecioMensualPropiedad.Name = "textBoxPrecioMensualPropiedad";
            textBoxPrecioMensualPropiedad.Size = new Size(186, 34);
            textBoxPrecioMensualPropiedad.TabIndex = 38;
            // 
            // textBoxTipoPropiedadPropiedad
            // 
            textBoxTipoPropiedadPropiedad.Location = new Point(652, 247);
            textBoxTipoPropiedadPropiedad.Margin = new Padding(4);
            textBoxTipoPropiedadPropiedad.Name = "textBoxTipoPropiedadPropiedad";
            textBoxTipoPropiedadPropiedad.Size = new Size(186, 34);
            textBoxTipoPropiedadPropiedad.TabIndex = 37;
            // 
            // textBoxDireccionPropiedad
            // 
            textBoxDireccionPropiedad.Location = new Point(875, 147);
            textBoxDireccionPropiedad.Margin = new Padding(4);
            textBoxDireccionPropiedad.Name = "textBoxDireccionPropiedad";
            textBoxDireccionPropiedad.Size = new Size(186, 34);
            textBoxDireccionPropiedad.TabIndex = 36;
            // 
            // textboxNombrePropiedad
            // 
            textboxNombrePropiedad.Location = new Point(652, 147);
            textboxNombrePropiedad.Margin = new Padding(4);
            textboxNombrePropiedad.Name = "textboxNombrePropiedad";
            textboxNombrePropiedad.Size = new Size(186, 34);
            textboxNombrePropiedad.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(699, 95);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 28);
            label10.TabIndex = 34;
            label10.Text = "Nombre";
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(18, 51);
            dgvPropiedades.Margin = new Padding(4);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.RowTemplate.Height = 29;
            dgvPropiedades.Size = new Size(603, 365);
            dgvPropiedades.TabIndex = 33;
            // 
            // AlquilerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1100, 547);
            Controls.Add(rentasControl);
            Controls.Add(encabezadoPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AlquilerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alquiler";
            encabezadoPanel.ResumeLayout(false);
            encabezadoPanel.PerformLayout();
            rentasControl.ResumeLayout(false);
            Contratos.ResumeLayout(false);
            Contratos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contratosdataGridView).EndInit();
            Inquilinos.ResumeLayout(false);
            Inquilinos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inquilinosdataGridView).EndInit();
            Mantenimiento.ResumeLayout(false);
            Mantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mantenimientoDataGridView).EndInit();
            Pagos.ResumeLayout(false);
            Pagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pagosDataGridView).EndInit();
            Propiedades.ResumeLayout(false);
            Propiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel encabezadoPanel;
        private Label tituloLabel;
        private Button closeButton;
        private TabControl rentasControl;
        private TabPage Contratos;
        private TabPage Inquilinos;
        private TabPage Mantenimiento;
        private TabPage Pagos;
        private TabPage Propiedades;
        private Label label3;
        private Label label6;
        private DataGridView pagosDataGridView;
        private Button editarPagoButton;
        private Button eliminarPagoButton;
        private Button guardarPagoButton;
        private TextBox montoPagoTextBox;
        private Label label1;
        private Label label2;
        private ComboBox contratoComboBox;
        private ComboBox propiedadComboBox;
        private Label label4;
        private Label label5;
        private DataGridView mantenimientoDataGridView;
        private Button editarMantenimientoButton;
        private Button eliminarMantenimientoButton;
        private Button guardarMantenimientoButton;
        private TextBox descripcionTextBox;
        private Label label7;
        private Label label8;
        private TextBox costoTextbox;
        private Label label9;
        private DateTimePicker mantenimientoDateTimePicker;
        private DateTimePicker pagoDateTimePicker;
        private Label labelPropiedad;
        private TextBox txtId;
        private Label label12;
        private TextBox txtBuscar;
        private Label label11;
        private Button btnEliminarPropiedad;
        private Button btnEditarPropiedad;
        private Button btnGuardarPropiedad;
        private Label labelPrecioMensual;
        private Label labelTipoPropiedad;
        private Label labelDireccion;
        private TextBox textBoxPrecioMensualPropiedad;
        private TextBox textBoxTipoPropiedadPropiedad;
        private TextBox textBoxDireccionPropiedad;
        private TextBox textboxNombrePropiedad;
        private Label label10;
        private DataGridView dgvPropiedades;
        private Label label16;
        private Button editarcontratosbutton;
        private Button eliminarcontratosbutton;
        private Button guardarcontratosbutton;
        private ComboBox InquilinocomboBox;
        private ComboBox propiedadComBo;
        private Label inquilinolabel;
        private Label prpiedadlabel;
        private DateTimePicker fechafindateTimePicker;
        private DateTimePicker fechainiciodateTimePicker;
        private Label label13;
        private TextBox montomensualtextBox;
        private Label label14;
        private Label label15;
        private DataGridView contratosdataGridView;
        private Label label18;
        private TextBox direccionTextBox;
        private Label direccionlabel;
        private Button editarInquilinoButton;
        private Button eliminarInquilinoButton;
        private TextBox telefonoTextbox;
        private TextBox emailTextBox;
        private Label emaillabel;
        private Label label17;
        private Button guardarInquilinoButton;
        private TextBox nombreTextBox;
        private Label nombrelabel;
        private DataGridView inquilinosdataGridView;
    }
}