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
            pdfpropiedadesbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            SuspendLayout();
            // 
            // labelPropiedad
            // 
            labelPropiedad.AutoSize = true;
            labelPropiedad.ForeColor = Color.DimGray;
            labelPropiedad.Location = new Point(-151, -4);
            labelPropiedad.Margin = new Padding(4, 0, 4, 0);
            labelPropiedad.Name = "labelPropiedad";
            labelPropiedad.Size = new Size(99, 15);
            labelPropiedad.TabIndex = 66;
            labelPropiedad.Text = "Lista Propiedades";
            // 
            // btnEliminarPropiedad
            // 
            btnEliminarPropiedad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarPropiedad.ForeColor = Color.Black;
            btnEliminarPropiedad.Location = new Point(223, 278);
            btnEliminarPropiedad.Margin = new Padding(4, 3, 4, 3);
            btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            btnEliminarPropiedad.Size = new Size(124, 33);
            btnEliminarPropiedad.TabIndex = 61;
            btnEliminarPropiedad.Text = "Eliminar";
            btnEliminarPropiedad.UseVisualStyleBackColor = true;
            btnEliminarPropiedad.Click += btnEliminarPropiedad_Click;
            // 
            // btnEditarPropiedad
            // 
            btnEditarPropiedad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPropiedad.ForeColor = Color.Black;
            btnEditarPropiedad.Location = new Point(118, 278);
            btnEditarPropiedad.Margin = new Padding(4, 3, 4, 3);
            btnEditarPropiedad.Name = "btnEditarPropiedad";
            btnEditarPropiedad.Size = new Size(102, 33);
            btnEditarPropiedad.TabIndex = 60;
            btnEditarPropiedad.Text = "Editar";
            btnEditarPropiedad.UseVisualStyleBackColor = true;
            btnEditarPropiedad.Click += btnEditarPropiedad_Click;
            // 
            // btnGuardarPropiedad
            // 
            btnGuardarPropiedad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarPropiedad.ForeColor = Color.Black;
            btnGuardarPropiedad.Location = new Point(4, 278);
            btnGuardarPropiedad.Margin = new Padding(4, 3, 4, 3);
            btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            btnGuardarPropiedad.Size = new Size(105, 33);
            btnGuardarPropiedad.TabIndex = 59;
            btnGuardarPropiedad.Text = "Guardar";
            btnGuardarPropiedad.UseVisualStyleBackColor = true;
            btnGuardarPropiedad.Click += btnGuardarPropiedad_Click_1;
            // 
            // labelPrecioMensual
            // 
            labelPrecioMensual.AutoSize = true;
            labelPrecioMensual.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecioMensual.ForeColor = Color.Black;
            labelPrecioMensual.Location = new Point(388, 212);
            labelPrecioMensual.Margin = new Padding(4, 0, 4, 0);
            labelPrecioMensual.Name = "labelPrecioMensual";
            labelPrecioMensual.Size = new Size(155, 24);
            labelPrecioMensual.TabIndex = 58;
            labelPrecioMensual.Text = "Precio Mensual";
            // 
            // labelTipoPropiedad
            // 
            labelTipoPropiedad.AutoSize = true;
            labelTipoPropiedad.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoPropiedad.ForeColor = Color.Black;
            labelTipoPropiedad.Location = new Point(388, 152);
            labelTipoPropiedad.Margin = new Padding(4, 0, 4, 0);
            labelTipoPropiedad.Name = "labelTipoPropiedad";
            labelTipoPropiedad.Size = new Size(153, 24);
            labelTipoPropiedad.TabIndex = 57;
            labelTipoPropiedad.Text = "Tipo propiedad";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDireccion.ForeColor = Color.Black;
            labelDireccion.Location = new Point(388, 88);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(99, 24);
            labelDireccion.TabIndex = 56;
            labelDireccion.Text = "Direccion";
            // 
            // textBoxPrecioMensualPropiedad
            // 
            textBoxPrecioMensualPropiedad.Location = new Point(391, 238);
            textBoxPrecioMensualPropiedad.Margin = new Padding(4, 3, 4, 3);
            textBoxPrecioMensualPropiedad.Name = "textBoxPrecioMensualPropiedad";
            textBoxPrecioMensualPropiedad.Size = new Size(163, 23);
            textBoxPrecioMensualPropiedad.TabIndex = 55;
            textBoxPrecioMensualPropiedad.KeyPress += textBoxPrecioMensualPropiedad_KeyPress;
            // 
            // textBoxTipoPropiedadPropiedad
            // 
            textBoxTipoPropiedadPropiedad.Location = new Point(391, 177);
            textBoxTipoPropiedadPropiedad.Margin = new Padding(4, 3, 4, 3);
            textBoxTipoPropiedadPropiedad.Name = "textBoxTipoPropiedadPropiedad";
            textBoxTipoPropiedadPropiedad.Size = new Size(163, 23);
            textBoxTipoPropiedadPropiedad.TabIndex = 54;
            // 
            // textBoxDireccionPropiedad
            // 
            textBoxDireccionPropiedad.Location = new Point(391, 113);
            textBoxDireccionPropiedad.Margin = new Padding(4, 3, 4, 3);
            textBoxDireccionPropiedad.Name = "textBoxDireccionPropiedad";
            textBoxDireccionPropiedad.Size = new Size(163, 23);
            textBoxDireccionPropiedad.TabIndex = 53;
            // 
            // textboxNombrePropiedad
            // 
            textboxNombrePropiedad.Location = new Point(391, 53);
            textboxNombrePropiedad.Margin = new Padding(4, 3, 4, 3);
            textboxNombrePropiedad.Name = "textboxNombrePropiedad";
            textboxNombrePropiedad.Size = new Size(163, 23);
            textboxNombrePropiedad.TabIndex = 52;
            textboxNombrePropiedad.KeyPress += textboxNombrePropiedad_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(391, 28);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 24);
            label10.TabIndex = 51;
            label10.Text = "Nombre";
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(4, 28);
            dgvPropiedades.Margin = new Padding(4, 3, 4, 3);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.RowTemplate.Height = 29;
            dgvPropiedades.Size = new Size(378, 241);
            dgvPropiedades.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 24);
            label1.TabIndex = 67;
            label1.Text = "Lista de propiedades";
            // 
            // pdfpropiedadesbutton
            // 
            pdfpropiedadesbutton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pdfpropiedadesbutton.ForeColor = Color.Black;
            pdfpropiedadesbutton.Location = new Point(356, 278);
            pdfpropiedadesbutton.Margin = new Padding(4, 3, 4, 3);
            pdfpropiedadesbutton.Name = "pdfpropiedadesbutton";
            pdfpropiedadesbutton.Size = new Size(116, 33);
            pdfpropiedadesbutton.TabIndex = 68;
            pdfpropiedadesbutton.Text = "PDF";
            pdfpropiedadesbutton.UseVisualStyleBackColor = true;
            pdfpropiedadesbutton.Click += pdfpropiedadesbutton_Click;
            // 
            // PropiedadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(638, 321);
            Controls.Add(pdfpropiedadesbutton);
            Controls.Add(label1);
            Controls.Add(labelPropiedad);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "PropiedadesForm";
            Opacity = 0.8D;
            Text = "PropiedadesForm";
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPropiedad;
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
        private Button pdfpropiedadesbutton;
    }
}