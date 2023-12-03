namespace PresentatorLayer.Forms
{
    partial class ContratosForm
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
            titulocontratoslabel = new Label();
            editarcontratosbutton = new Button();
            eliminarcontratosbutton = new Button();
            guardarcontratosbutton = new Button();
            InquilinocomboBox = new ComboBox();
            propiedadComBo = new ComboBox();
            inquilinolabel = new Label();
            prpiedadlabel = new Label();
            fechafindateTimePicker = new DateTimePicker();
            fechainiciodateTimePicker = new DateTimePicker();
            fechafincontratoslabel = new Label();
            montomensualtextBox = new TextBox();
            montocontratoslabel = new Label();
            fechainiciocontratoslabel = new Label();
            contratosdataGridView = new DataGridView();
            pdfcontratosbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)contratosdataGridView).BeginInit();
            SuspendLayout();
            // 
            // titulocontratoslabel
            // 
            titulocontratoslabel.AutoSize = true;
            titulocontratoslabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titulocontratoslabel.ForeColor = Color.Black;
            titulocontratoslabel.Location = new Point(3, 2);
            titulocontratoslabel.Margin = new Padding(4, 0, 4, 0);
            titulocontratoslabel.Name = "titulocontratoslabel";
            titulocontratoslabel.Size = new Size(160, 20);
            titulocontratoslabel.TabIndex = 74;
            titulocontratoslabel.Text = "Lista De Contratos";
            // 
            // editarcontratosbutton
            // 
            editarcontratosbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editarcontratosbutton.ForeColor = Color.Black;
            editarcontratosbutton.Location = new Point(133, 247);
            editarcontratosbutton.Margin = new Padding(4, 3, 4, 3);
            editarcontratosbutton.Name = "editarcontratosbutton";
            editarcontratosbutton.Size = new Size(111, 31);
            editarcontratosbutton.TabIndex = 71;
            editarcontratosbutton.Text = "Editar";
            editarcontratosbutton.UseVisualStyleBackColor = true;
            editarcontratosbutton.Click += editarcontratosbutton_Click;
            // 
            // eliminarcontratosbutton
            // 
            eliminarcontratosbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarcontratosbutton.ForeColor = Color.Black;
            eliminarcontratosbutton.Location = new Point(251, 247);
            eliminarcontratosbutton.Margin = new Padding(4, 3, 4, 3);
            eliminarcontratosbutton.Name = "eliminarcontratosbutton";
            eliminarcontratosbutton.Size = new Size(118, 31);
            eliminarcontratosbutton.TabIndex = 73;
            eliminarcontratosbutton.Text = "Eliminar";
            eliminarcontratosbutton.UseVisualStyleBackColor = true;
            eliminarcontratosbutton.Click += eliminarcontratosbutton_Click;
            // 
            // guardarcontratosbutton
            // 
            guardarcontratosbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guardarcontratosbutton.ForeColor = Color.Black;
            guardarcontratosbutton.Location = new Point(3, 247);
            guardarcontratosbutton.Margin = new Padding(4, 3, 4, 3);
            guardarcontratosbutton.Name = "guardarcontratosbutton";
            guardarcontratosbutton.Size = new Size(113, 31);
            guardarcontratosbutton.TabIndex = 72;
            guardarcontratosbutton.Text = "Guardar";
            guardarcontratosbutton.UseVisualStyleBackColor = true;
            guardarcontratosbutton.Click += guardarcontratosbutton_Click;
            // 
            // InquilinocomboBox
            // 
            InquilinocomboBox.FormattingEnabled = true;
            InquilinocomboBox.Location = new Point(374, 221);
            InquilinocomboBox.Margin = new Padding(3, 2, 3, 2);
            InquilinocomboBox.Name = "InquilinocomboBox";
            InquilinocomboBox.Size = new Size(217, 23);
            InquilinocomboBox.TabIndex = 70;
            // 
            // propiedadComBo
            // 
            propiedadComBo.FormattingEnabled = true;
            propiedadComBo.Location = new Point(371, 176);
            propiedadComBo.Margin = new Padding(3, 2, 3, 2);
            propiedadComBo.Name = "propiedadComBo";
            propiedadComBo.Size = new Size(220, 23);
            propiedadComBo.TabIndex = 69;
            // 
            // inquilinolabel
            // 
            inquilinolabel.AutoSize = true;
            inquilinolabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inquilinolabel.ForeColor = Color.Black;
            inquilinolabel.Location = new Point(374, 199);
            inquilinolabel.Name = "inquilinolabel";
            inquilinolabel.Size = new Size(82, 20);
            inquilinolabel.TabIndex = 68;
            inquilinolabel.Text = "Inquilino:";
            // 
            // prpiedadlabel
            // 
            prpiedadlabel.AutoSize = true;
            prpiedadlabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prpiedadlabel.ForeColor = Color.Black;
            prpiedadlabel.Location = new Point(371, 155);
            prpiedadlabel.Name = "prpiedadlabel";
            prpiedadlabel.Size = new Size(90, 20);
            prpiedadlabel.TabIndex = 67;
            prpiedadlabel.Text = "Propiedad";
            // 
            // fechafindateTimePicker
            // 
            fechafindateTimePicker.Location = new Point(371, 84);
            fechafindateTimePicker.Margin = new Padding(3, 2, 3, 2);
            fechafindateTimePicker.Name = "fechafindateTimePicker";
            fechafindateTimePicker.Size = new Size(220, 23);
            fechafindateTimePicker.TabIndex = 66;
            // 
            // fechainiciodateTimePicker
            // 
            fechainiciodateTimePicker.Location = new Point(371, 37);
            fechainiciodateTimePicker.Margin = new Padding(3, 2, 3, 2);
            fechainiciodateTimePicker.Name = "fechainiciodateTimePicker";
            fechainiciodateTimePicker.Size = new Size(220, 23);
            fechainiciodateTimePicker.TabIndex = 65;
            // 
            // fechafincontratoslabel
            // 
            fechafincontratoslabel.AutoSize = true;
            fechafincontratoslabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fechafincontratoslabel.ForeColor = Color.Black;
            fechafincontratoslabel.Location = new Point(371, 62);
            fechafincontratoslabel.Name = "fechafincontratoslabel";
            fechafincontratoslabel.Size = new Size(89, 20);
            fechafincontratoslabel.TabIndex = 62;
            fechafincontratoslabel.Text = "Fecha Fin";
            // 
            // montomensualtextBox
            // 
            montomensualtextBox.Location = new Point(371, 132);
            montomensualtextBox.Margin = new Padding(3, 2, 3, 2);
            montomensualtextBox.Name = "montomensualtextBox";
            montomensualtextBox.Size = new Size(220, 23);
            montomensualtextBox.TabIndex = 64;
            montomensualtextBox.KeyPress += montomensualtextBox_KeyPress;
            // 
            // montocontratoslabel
            // 
            montocontratoslabel.AutoSize = true;
            montocontratoslabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            montocontratoslabel.ForeColor = Color.Black;
            montocontratoslabel.Location = new Point(371, 110);
            montocontratoslabel.Name = "montocontratoslabel";
            montocontratoslabel.Size = new Size(131, 20);
            montocontratoslabel.TabIndex = 63;
            montocontratoslabel.Text = "Monto Mensual";
            // 
            // fechainiciocontratoslabel
            // 
            fechainiciocontratoslabel.AutoSize = true;
            fechainiciocontratoslabel.BackColor = Color.SkyBlue;
            fechainiciocontratoslabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fechainiciocontratoslabel.ForeColor = Color.Black;
            fechainiciocontratoslabel.Location = new Point(371, 15);
            fechainiciocontratoslabel.Name = "fechainiciocontratoslabel";
            fechainiciocontratoslabel.Size = new Size(107, 20);
            fechainiciocontratoslabel.TabIndex = 61;
            fechainiciocontratoslabel.Text = "Fecha Inicio";
            // 
            // contratosdataGridView
            // 
            contratosdataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            contratosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contratosdataGridView.Location = new Point(3, 24);
            contratosdataGridView.Margin = new Padding(3, 2, 3, 2);
            contratosdataGridView.Name = "contratosdataGridView";
            contratosdataGridView.RowHeadersWidth = 51;
            contratosdataGridView.RowTemplate.Height = 29;
            contratosdataGridView.Size = new Size(365, 218);
            contratosdataGridView.TabIndex = 60;
            // 
            // pdfcontratosbutton
            // 
            pdfcontratosbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pdfcontratosbutton.ForeColor = Color.Black;
            pdfcontratosbutton.Location = new Point(375, 245);
            pdfcontratosbutton.Margin = new Padding(4, 3, 4, 3);
            pdfcontratosbutton.Name = "pdfcontratosbutton";
            pdfcontratosbutton.Size = new Size(113, 31);
            pdfcontratosbutton.TabIndex = 75;
            pdfcontratosbutton.Text = "PDF";
            pdfcontratosbutton.UseVisualStyleBackColor = true;
            pdfcontratosbutton.Click += pdfcontratosbutton_Click;
            // 
            // ContratosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(622, 286);
            Controls.Add(pdfcontratosbutton);
            Controls.Add(titulocontratoslabel);
            Controls.Add(editarcontratosbutton);
            Controls.Add(eliminarcontratosbutton);
            Controls.Add(guardarcontratosbutton);
            Controls.Add(InquilinocomboBox);
            Controls.Add(propiedadComBo);
            Controls.Add(inquilinolabel);
            Controls.Add(prpiedadlabel);
            Controls.Add(fechafindateTimePicker);
            Controls.Add(fechainiciodateTimePicker);
            Controls.Add(fechafincontratoslabel);
            Controls.Add(montomensualtextBox);
            Controls.Add(montocontratoslabel);
            Controls.Add(fechainiciocontratoslabel);
            Controls.Add(contratosdataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ContratosForm";
            Opacity = 0.8D;
            Text = "ContratosForm";
            ((System.ComponentModel.ISupportInitialize)contratosdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulocontratoslabel;
        private Button editarcontratosbutton;
        private Button eliminarcontratosbutton;
        private Button guardarcontratosbutton;
        private ComboBox InquilinocomboBox;
        private ComboBox propiedadComBo;
        private Label inquilinolabel;
        private Label prpiedadlabel;
        private DateTimePicker fechafindateTimePicker;
        private DateTimePicker fechainiciodateTimePicker;
        private Label fechafincontratoslabel;
        private TextBox montomensualtextBox;
        private Label montocontratoslabel;
        private Label fechainiciocontratoslabel;
        private DataGridView contratosdataGridView;
        private Button pdfcontratosbutton;
    }
}