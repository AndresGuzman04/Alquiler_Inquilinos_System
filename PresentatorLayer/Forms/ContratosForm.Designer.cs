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
            titulocontratoslabel.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titulocontratoslabel.ForeColor = Color.Black;
            titulocontratoslabel.Location = new Point(3, 3);
            titulocontratoslabel.Margin = new Padding(4, 0, 4, 0);
            titulocontratoslabel.Name = "titulocontratoslabel";
            titulocontratoslabel.Size = new Size(228, 26);
            titulocontratoslabel.TabIndex = 74;
            titulocontratoslabel.Text = "Lista De Contratos";
            // 
            // editarcontratosbutton
            // 
            editarcontratosbutton.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editarcontratosbutton.ForeColor = Color.Black;
            editarcontratosbutton.Location = new Point(152, 330);
            editarcontratosbutton.Margin = new Padding(4);
            editarcontratosbutton.Name = "editarcontratosbutton";
            editarcontratosbutton.Size = new Size(127, 41);
            editarcontratosbutton.TabIndex = 71;
            editarcontratosbutton.Text = "Editar";
            editarcontratosbutton.UseVisualStyleBackColor = true;
            // 
            // eliminarcontratosbutton
            // 
            eliminarcontratosbutton.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarcontratosbutton.ForeColor = Color.Black;
            eliminarcontratosbutton.Location = new Point(287, 330);
            eliminarcontratosbutton.Margin = new Padding(4);
            eliminarcontratosbutton.Name = "eliminarcontratosbutton";
            eliminarcontratosbutton.Size = new Size(134, 41);
            eliminarcontratosbutton.TabIndex = 73;
            eliminarcontratosbutton.Text = "Eliminar";
            eliminarcontratosbutton.UseVisualStyleBackColor = true;
            // 
            // guardarcontratosbutton
            // 
            guardarcontratosbutton.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guardarcontratosbutton.ForeColor = Color.Black;
            guardarcontratosbutton.Location = new Point(3, 330);
            guardarcontratosbutton.Margin = new Padding(4);
            guardarcontratosbutton.Name = "guardarcontratosbutton";
            guardarcontratosbutton.Size = new Size(130, 41);
            guardarcontratosbutton.TabIndex = 72;
            guardarcontratosbutton.Text = "Guardar";
            guardarcontratosbutton.UseVisualStyleBackColor = true;
            guardarcontratosbutton.Click += guardarcontratosbutton_Click;
            // 
            // InquilinocomboBox
            // 
            InquilinocomboBox.FormattingEnabled = true;
            InquilinocomboBox.Location = new Point(427, 294);
            InquilinocomboBox.Name = "InquilinocomboBox";
            InquilinocomboBox.Size = new Size(250, 28);
            InquilinocomboBox.TabIndex = 70;
            // 
            // propiedadComBo
            // 
            propiedadComBo.FormattingEnabled = true;
            propiedadComBo.Location = new Point(424, 235);
            propiedadComBo.Name = "propiedadComBo";
            propiedadComBo.Size = new Size(250, 28);
            propiedadComBo.TabIndex = 69;
            // 
            // inquilinolabel
            // 
            inquilinolabel.AutoSize = true;
            inquilinolabel.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inquilinolabel.ForeColor = Color.Black;
            inquilinolabel.Location = new Point(427, 265);
            inquilinolabel.Name = "inquilinolabel";
            inquilinolabel.Size = new Size(132, 26);
            inquilinolabel.TabIndex = 68;
            inquilinolabel.Text = "Inquilino:";
            // 
            // prpiedadlabel
            // 
            prpiedadlabel.AutoSize = true;
            prpiedadlabel.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prpiedadlabel.ForeColor = Color.Black;
            prpiedadlabel.Location = new Point(424, 206);
            prpiedadlabel.Name = "prpiedadlabel";
            prpiedadlabel.Size = new Size(120, 26);
            prpiedadlabel.TabIndex = 67;
            prpiedadlabel.Text = "Propiedad";
            // 
            // fechafindateTimePicker
            // 
            fechafindateTimePicker.Location = new Point(424, 112);
            fechafindateTimePicker.Name = "fechafindateTimePicker";
            fechafindateTimePicker.Size = new Size(250, 27);
            fechafindateTimePicker.TabIndex = 66;
            // 
            // fechainiciodateTimePicker
            // 
            fechainiciodateTimePicker.Location = new Point(424, 49);
            fechainiciodateTimePicker.Name = "fechainiciodateTimePicker";
            fechainiciodateTimePicker.Size = new Size(250, 27);
            fechainiciodateTimePicker.TabIndex = 65;
            // 
            // fechafincontratoslabel
            // 
            fechafincontratoslabel.AutoSize = true;
            fechafincontratoslabel.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fechafincontratoslabel.ForeColor = Color.Black;
            fechafincontratoslabel.Location = new Point(424, 83);
            fechafincontratoslabel.Name = "fechafincontratoslabel";
            fechafincontratoslabel.Size = new Size(120, 26);
            fechafincontratoslabel.TabIndex = 62;
            fechafincontratoslabel.Text = "Fecha Fin";
            // 
            // montomensualtextBox
            // 
            montomensualtextBox.Location = new Point(424, 176);
            montomensualtextBox.Name = "montomensualtextBox";
            montomensualtextBox.Size = new Size(250, 27);
            montomensualtextBox.TabIndex = 64;
            // 
            // montocontratoslabel
            // 
            montocontratoslabel.AutoSize = true;
            montocontratoslabel.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            montocontratoslabel.ForeColor = Color.Black;
            montocontratoslabel.Location = new Point(424, 147);
            montocontratoslabel.Name = "montocontratoslabel";
            montocontratoslabel.Size = new Size(168, 26);
            montocontratoslabel.TabIndex = 63;
            montocontratoslabel.Text = "Monto Mensual";
            // 
            // fechainiciocontratoslabel
            // 
            fechainiciocontratoslabel.AutoSize = true;
            fechainiciocontratoslabel.BackColor = Color.SkyBlue;
            fechainiciocontratoslabel.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fechainiciocontratoslabel.ForeColor = Color.Black;
            fechainiciocontratoslabel.Location = new Point(424, 20);
            fechainiciocontratoslabel.Name = "fechainiciocontratoslabel";
            fechainiciocontratoslabel.Size = new Size(156, 26);
            fechainiciocontratoslabel.TabIndex = 61;
            fechainiciocontratoslabel.Text = "Fecha Inicio";
            // 
            // contratosdataGridView
            // 
            contratosdataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            contratosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contratosdataGridView.Location = new Point(3, 32);
            contratosdataGridView.Name = "contratosdataGridView";
            contratosdataGridView.RowHeadersWidth = 51;
            contratosdataGridView.RowTemplate.Height = 29;
            contratosdataGridView.Size = new Size(418, 291);
            contratosdataGridView.TabIndex = 60;
            // 
            // pdfcontratosbutton
            // 
            pdfcontratosbutton.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pdfcontratosbutton.ForeColor = Color.Black;
            pdfcontratosbutton.Location = new Point(429, 327);
            pdfcontratosbutton.Margin = new Padding(4);
            pdfcontratosbutton.Name = "pdfcontratosbutton";
            pdfcontratosbutton.Size = new Size(130, 41);
            pdfcontratosbutton.TabIndex = 75;
            pdfcontratosbutton.Text = "PDF";
            pdfcontratosbutton.UseVisualStyleBackColor = true;
            // 
            // ContratosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(711, 381);
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