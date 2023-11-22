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
            this.labelPropiedad = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEliminarPropiedad = new System.Windows.Forms.Button();
            this.btnEditarPropiedad = new System.Windows.Forms.Button();
            this.btnGuardarPropiedad = new System.Windows.Forms.Button();
            this.labelPrecioMensual = new System.Windows.Forms.Label();
            this.labelTipoPropiedad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxPrecioMensualPropiedad = new System.Windows.Forms.TextBox();
            this.textBoxTipoPropiedadPropiedad = new System.Windows.Forms.TextBox();
            this.textBoxDireccionPropiedad = new System.Windows.Forms.TextBox();
            this.textboxNombrePropiedad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPropiedad
            // 
            this.labelPropiedad.AutoSize = true;
            this.labelPropiedad.ForeColor = System.Drawing.Color.DimGray;
            this.labelPropiedad.Location = new System.Drawing.Point(-173, -5);
            this.labelPropiedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPropiedad.Name = "labelPropiedad";
            this.labelPropiedad.Size = new System.Drawing.Size(126, 20);
            this.labelPropiedad.TabIndex = 66;
            this.labelPropiedad.Text = "Lista Propiedades";
            this.labelPropiedad.Click += new System.EventHandler(this.labelPropiedad_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(444, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(186, 27);
            this.txtBuscar.TabIndex = 63;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(444, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 62;
            this.label11.Text = "Buscar:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPropiedad.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(248, 371);
            this.btnEliminarPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(132, 44);
            this.btnEliminarPropiedad.TabIndex = 61;
            this.btnEliminarPropiedad.Text = "Eliminar";
            this.btnEliminarPropiedad.UseVisualStyleBackColor = true;
            this.btnEliminarPropiedad.Click += new System.EventHandler(this.btnEliminarPropiedad_Click);
            // 
            // btnEditarPropiedad
            // 
            this.btnEditarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarPropiedad.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPropiedad.Location = new System.Drawing.Point(132, 371);
            this.btnEditarPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarPropiedad.Name = "btnEditarPropiedad";
            this.btnEditarPropiedad.Size = new System.Drawing.Size(107, 44);
            this.btnEditarPropiedad.TabIndex = 60;
            this.btnEditarPropiedad.Text = "Editar";
            this.btnEditarPropiedad.UseVisualStyleBackColor = true;
            this.btnEditarPropiedad.Click += new System.EventHandler(this.btnEditarPropiedad_Click);
            // 
            // btnGuardarPropiedad
            // 
            this.btnGuardarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarPropiedad.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarPropiedad.Location = new System.Drawing.Point(4, 371);
            this.btnGuardarPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            this.btnGuardarPropiedad.Size = new System.Drawing.Size(120, 44);
            this.btnGuardarPropiedad.TabIndex = 59;
            this.btnGuardarPropiedad.Text = "Guardar";
            this.btnGuardarPropiedad.UseVisualStyleBackColor = true;
            this.btnGuardarPropiedad.Click += new System.EventHandler(this.btnGuardarPropiedad_Click);
            // 
            // labelPrecioMensual
            // 
            this.labelPrecioMensual.AutoSize = true;
            this.labelPrecioMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrecioMensual.ForeColor = System.Drawing.Color.Black;
            this.labelPrecioMensual.Location = new System.Drawing.Point(444, 298);
            this.labelPrecioMensual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioMensual.Name = "labelPrecioMensual";
            this.labelPrecioMensual.Size = new System.Drawing.Size(194, 29);
            this.labelPrecioMensual.TabIndex = 58;
            this.labelPrecioMensual.Text = "Precio Mensual";
            this.labelPrecioMensual.Click += new System.EventHandler(this.labelPrecioMensual_Click);
            // 
            // labelTipoPropiedad
            // 
            this.labelTipoPropiedad.AutoSize = true;
            this.labelTipoPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoPropiedad.ForeColor = System.Drawing.Color.Black;
            this.labelTipoPropiedad.Location = new System.Drawing.Point(444, 220);
            this.labelTipoPropiedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoPropiedad.Name = "labelTipoPropiedad";
            this.labelTipoPropiedad.Size = new System.Drawing.Size(194, 29);
            this.labelTipoPropiedad.TabIndex = 57;
            this.labelTipoPropiedad.Text = "Tipo propiedad";
            this.labelTipoPropiedad.Click += new System.EventHandler(this.labelTipoPropiedad_Click);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDireccion.ForeColor = System.Drawing.Color.Black;
            this.labelDireccion.Location = new System.Drawing.Point(444, 145);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(124, 29);
            this.labelDireccion.TabIndex = 56;
            this.labelDireccion.Text = "Direccion";
            this.labelDireccion.Click += new System.EventHandler(this.labelDireccion_Click);
            // 
            // textBoxPrecioMensualPropiedad
            // 
            this.textBoxPrecioMensualPropiedad.Location = new System.Drawing.Point(444, 331);
            this.textBoxPrecioMensualPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecioMensualPropiedad.Name = "textBoxPrecioMensualPropiedad";
            this.textBoxPrecioMensualPropiedad.Size = new System.Drawing.Size(186, 27);
            this.textBoxPrecioMensualPropiedad.TabIndex = 55;
            this.textBoxPrecioMensualPropiedad.TextChanged += new System.EventHandler(this.textBoxPrecioMensualPropiedad_TextChanged);
            // 
            // textBoxTipoPropiedadPropiedad
            // 
            this.textBoxTipoPropiedadPropiedad.Location = new System.Drawing.Point(444, 253);
            this.textBoxTipoPropiedadPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTipoPropiedadPropiedad.Name = "textBoxTipoPropiedadPropiedad";
            this.textBoxTipoPropiedadPropiedad.Size = new System.Drawing.Size(186, 27);
            this.textBoxTipoPropiedadPropiedad.TabIndex = 54;
            this.textBoxTipoPropiedadPropiedad.TextChanged += new System.EventHandler(this.textBoxTipoPropiedadPropiedad_TextChanged);
            // 
            // textBoxDireccionPropiedad
            // 
            this.textBoxDireccionPropiedad.Location = new System.Drawing.Point(444, 178);
            this.textBoxDireccionPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccionPropiedad.Name = "textBoxDireccionPropiedad";
            this.textBoxDireccionPropiedad.Size = new System.Drawing.Size(186, 27);
            this.textBoxDireccionPropiedad.TabIndex = 53;
            this.textBoxDireccionPropiedad.TextChanged += new System.EventHandler(this.textBoxDireccionPropiedad_TextChanged);
            // 
            // textboxNombrePropiedad
            // 
            this.textboxNombrePropiedad.Location = new System.Drawing.Point(444, 114);
            this.textboxNombrePropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNombrePropiedad.Name = "textboxNombrePropiedad";
            this.textboxNombrePropiedad.Size = new System.Drawing.Size(186, 27);
            this.textboxNombrePropiedad.TabIndex = 52;
            this.textboxNombrePropiedad.TextChanged += new System.EventHandler(this.textboxNombrePropiedad_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(444, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 51;
            this.label10.Text = "Nombre";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedades.Location = new System.Drawing.Point(4, 38);
            this.dgvPropiedades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.RowHeadersWidth = 51;
            this.dgvPropiedades.RowTemplate.Height = 29;
            this.dgvPropiedades.Size = new System.Drawing.Size(432, 302);
            this.dgvPropiedades.TabIndex = 50;
            this.dgvPropiedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropiedades_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Lista de propiedades";
            // 
            // PropiedadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(729, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPropiedad);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.btnEditarPropiedad);
            this.Controls.Add(this.btnGuardarPropiedad);
            this.Controls.Add(this.labelPrecioMensual);
            this.Controls.Add(this.labelTipoPropiedad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxPrecioMensualPropiedad);
            this.Controls.Add(this.textBoxTipoPropiedadPropiedad);
            this.Controls.Add(this.textBoxDireccionPropiedad);
            this.Controls.Add(this.textboxNombrePropiedad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropiedadesForm";
            this.Text = "PropiedadesForm";
            this.Load += new System.EventHandler(this.PropiedadesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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