namespace PresentatorLayer.Forms
{
    partial class PropiedadesForm
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
            labelPropiedad = new Label();
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            SuspendLayout();
            // 
            // labelPropiedad
            // 
            labelPropiedad.AutoSize = true;
            labelPropiedad.ForeColor = Color.DimGray;
            labelPropiedad.Location = new Point(-173, -5);
            labelPropiedad.Margin = new Padding(4, 0, 4, 0);
            labelPropiedad.Name = "labelPropiedad";
            labelPropiedad.Size = new Size(126, 20);
            labelPropiedad.TabIndex = 66;
            labelPropiedad.Text = "Lista Propiedades";
            labelPropiedad.Click += labelPropiedad_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(444, 51);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(186, 27);
            txtBuscar.TabIndex = 63;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(444, 19);
            label11.Name = "label11";
            label11.Size = new Size(97, 30);
            label11.TabIndex = 62;
            label11.Text = "Buscar";
            // 
            // btnEliminarPropiedad
            // 
            btnEliminarPropiedad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarPropiedad.ForeColor = Color.Black;
            btnEliminarPropiedad.Location = new Point(248, 371);
            btnEliminarPropiedad.Margin = new Padding(4);
            btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            btnEliminarPropiedad.Size = new Size(132, 44);
            btnEliminarPropiedad.TabIndex = 61;
            btnEliminarPropiedad.Text = "Eliminar";
            btnEliminarPropiedad.UseVisualStyleBackColor = true;
            btnEliminarPropiedad.Click += btnEliminarPropiedad_Click;
            // 
            // btnEditarPropiedad
            // 
            btnEditarPropiedad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPropiedad.ForeColor = Color.Black;
            btnEditarPropiedad.Location = new Point(132, 371);
            btnEditarPropiedad.Margin = new Padding(4);
            btnEditarPropiedad.Name = "btnEditarPropiedad";
            btnEditarPropiedad.Size = new Size(107, 44);
            btnEditarPropiedad.TabIndex = 60;
            btnEditarPropiedad.Text = "Editar";
            btnEditarPropiedad.UseVisualStyleBackColor = true;
            btnEditarPropiedad.Click += btnEditarPropiedad_Click;
            // 
            // btnGuardarPropiedad
            // 
            btnGuardarPropiedad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarPropiedad.ForeColor = Color.Black;
            btnGuardarPropiedad.Location = new Point(4, 371);
            btnGuardarPropiedad.Margin = new Padding(4);
            btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            btnGuardarPropiedad.Size = new Size(120, 44);
            btnGuardarPropiedad.TabIndex = 59;
            btnGuardarPropiedad.Text = "Guardar";
            btnGuardarPropiedad.UseVisualStyleBackColor = true;
            btnGuardarPropiedad.Click += btnGuardarPropiedad_Click;
            // 
            // labelPrecioMensual
            // 
            labelPrecioMensual.AutoSize = true;
            labelPrecioMensual.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecioMensual.ForeColor = Color.Black;
            labelPrecioMensual.Location = new Point(444, 298);
            labelPrecioMensual.Margin = new Padding(4, 0, 4, 0);
            labelPrecioMensual.Name = "labelPrecioMensual";
            labelPrecioMensual.Size = new Size(194, 29);
            labelPrecioMensual.TabIndex = 58;
            labelPrecioMensual.Text = "Precio Mensual";
            labelPrecioMensual.Click += labelPrecioMensual_Click;
            // 
            // labelTipoPropiedad
            // 
            labelTipoPropiedad.AutoSize = true;
            labelTipoPropiedad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoPropiedad.ForeColor = Color.Black;
            labelTipoPropiedad.Location = new Point(444, 220);
            labelTipoPropiedad.Margin = new Padding(4, 0, 4, 0);
            labelTipoPropiedad.Name = "labelTipoPropiedad";
            labelTipoPropiedad.Size = new Size(194, 29);
            labelTipoPropiedad.TabIndex = 57;
            labelTipoPropiedad.Text = "Tipo propiedad";
            labelTipoPropiedad.Click += labelTipoPropiedad_Click;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelDireccion.ForeColor = Color.Black;
            labelDireccion.Location = new Point(444, 145);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(139, 30);
            labelDireccion.TabIndex = 56;
            labelDireccion.Text = "Direccion";
            // 
            // textBoxPrecioMensualPropiedad
            // 
            textBoxPrecioMensualPropiedad.Location = new Point(444, 331);
            textBoxPrecioMensualPropiedad.Margin = new Padding(4);
            textBoxPrecioMensualPropiedad.Name = "textBoxPrecioMensualPropiedad";
            textBoxPrecioMensualPropiedad.Size = new Size(186, 27);
            textBoxPrecioMensualPropiedad.TabIndex = 55;
            textBoxPrecioMensualPropiedad.TextChanged += textBoxPrecioMensualPropiedad_TextChanged;
            // 
            // textBoxTipoPropiedadPropiedad
            // 
            textBoxTipoPropiedadPropiedad.Location = new Point(444, 253);
            textBoxTipoPropiedadPropiedad.Margin = new Padding(4);
            textBoxTipoPropiedadPropiedad.Name = "textBoxTipoPropiedadPropiedad";
            textBoxTipoPropiedadPropiedad.Size = new Size(186, 27);
            textBoxTipoPropiedadPropiedad.TabIndex = 54;
            textBoxTipoPropiedadPropiedad.TextChanged += textBoxTipoPropiedadPropiedad_TextChanged;
            // 
            // textBoxDireccionPropiedad
            // 
            textBoxDireccionPropiedad.Location = new Point(444, 178);
            textBoxDireccionPropiedad.Margin = new Padding(4);
            textBoxDireccionPropiedad.Name = "textBoxDireccionPropiedad";
            textBoxDireccionPropiedad.Size = new Size(186, 27);
            textBoxDireccionPropiedad.TabIndex = 53;
            textBoxDireccionPropiedad.TextChanged += textBoxDireccionPropiedad_TextChanged;
            // 
            // textboxNombrePropiedad
            // 
            textboxNombrePropiedad.Location = new Point(444, 114);
            textboxNombrePropiedad.Margin = new Padding(4);
            textboxNombrePropiedad.Name = "textboxNombrePropiedad";
            textboxNombrePropiedad.Size = new Size(186, 27);
            textboxNombrePropiedad.TabIndex = 52;
            textboxNombrePropiedad.TextChanged += textboxNombrePropiedad_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(444, 81);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(97, 30);
            label10.TabIndex = 51;
            label10.Text = "Nombre";
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(4, 38);
            dgvPropiedades.Margin = new Padding(4);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.RowTemplate.Height = 29;
            dgvPropiedades.Size = new Size(432, 302);
            dgvPropiedades.TabIndex = 50;
            dgvPropiedades.CellContentClick += dgvPropiedades_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(293, 30);
            label1.TabIndex = 67;
            label1.Text = "Lista de propiedades";
            // 
            // PropiedadesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(729, 428);
            Controls.Add(label1);
            Controls.Add(labelPropiedad);
            Controls.Add(txtBuscar);
            Controls.Add(label11);
            Controls.Add(btnEliminarPropiedad);
            Controls.Add(btnEditarPropiedad);
            Controls.Add(btnGuardarPropiedad);
            Controls.Add(labelPrecioMensual);
            Controls.Add(labelTipoPropiedad);
            Controls.Add(labelDireccion);
            Controls.Add(textBoxPrecioMensualPropiedad);
            Controls.Add(textBoxTipoPropiedadPropiedad);
            Controls.Add(textBoxDireccionPropiedad);
            Controls.Add(textboxNombrePropiedad);
            Controls.Add(label10);
            Controls.Add(dgvPropiedades);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PropiedadesForm";
            Text = "PropiedadesForm";
            Load += PropiedadesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPropiedad;
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
        private Label label1;
    }
}