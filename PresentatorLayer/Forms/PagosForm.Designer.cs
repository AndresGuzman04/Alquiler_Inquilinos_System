namespace PresentatorLayer.Forms
{
    partial class PagosForm
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
            pagoDateTimePicker = new DateTimePicker();
            contratoComboBox = new ComboBox();
            contratopagolabel = new Label();
            titulopagoslabel = new Label();
            pagosDataGridView = new DataGridView();
            editarPagoButton = new Button();
            eliminarPagoButton = new Button();
            guardarPagoButton = new Button();
            montoPagoTextBox = new TextBox();
            montopagolabel = new Label();
            fechapagolabel = new Label();
            pdfpagosbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pagosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // pagoDateTimePicker
            // 
            pagoDateTimePicker.Location = new Point(368, 160);
            pagoDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            pagoDateTimePicker.Name = "pagoDateTimePicker";
            pagoDateTimePicker.Size = new Size(225, 23);
            pagoDateTimePicker.TabIndex = 34;
            // 
            // contratoComboBox
            // 
            contratoComboBox.FormattingEnabled = true;
            contratoComboBox.Location = new Point(368, 100);
            contratoComboBox.Margin = new Padding(3, 2, 3, 2);
            contratoComboBox.Name = "contratoComboBox";
            contratoComboBox.Size = new Size(225, 23);
            contratoComboBox.TabIndex = 33;
            // 
            // contratopagolabel
            // 
            contratopagolabel.AutoSize = true;
            contratopagolabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contratopagolabel.ForeColor = Color.Black;
            contratopagolabel.Location = new Point(368, 79);
            contratopagolabel.Margin = new Padding(4, 0, 4, 0);
            contratopagolabel.Name = "contratopagolabel";
            contratopagolabel.Size = new Size(84, 20);
            contratopagolabel.TabIndex = 32;
            contratopagolabel.Text = "Contrato:";
            // 
            // titulopagoslabel
            // 
            titulopagoslabel.AutoSize = true;
            titulopagoslabel.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            titulopagoslabel.ForeColor = Color.Black;
            titulopagoslabel.Location = new Point(4, -1);
            titulopagoslabel.Margin = new Padding(4, 0, 4, 0);
            titulopagoslabel.Name = "titulopagoslabel";
            titulopagoslabel.Size = new Size(116, 24);
            titulopagoslabel.TabIndex = 31;
            titulopagoslabel.Text = "Lista Pagos";
            // 
            // pagosDataGridView
            // 
            pagosDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            pagosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pagosDataGridView.GridColor = SystemColors.ButtonShadow;
            pagosDataGridView.Location = new Point(4, 25);
            pagosDataGridView.Margin = new Padding(4, 3, 4, 3);
            pagosDataGridView.Name = "pagosDataGridView";
            pagosDataGridView.RowHeadersWidth = 51;
            pagosDataGridView.RowTemplate.Height = 29;
            pagosDataGridView.Size = new Size(357, 244);
            pagosDataGridView.TabIndex = 27;
            // 
            // editarPagoButton
            // 
            editarPagoButton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            editarPagoButton.ForeColor = Color.Black;
            editarPagoButton.Location = new Point(144, 280);
            editarPagoButton.Margin = new Padding(4, 3, 4, 3);
            editarPagoButton.Name = "editarPagoButton";
            editarPagoButton.Size = new Size(125, 31);
            editarPagoButton.TabIndex = 28;
            editarPagoButton.Text = "Editar";
            editarPagoButton.UseVisualStyleBackColor = true;
            editarPagoButton.Click += editarPagoButton_Click;
            // 
            // eliminarPagoButton
            // 
            eliminarPagoButton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarPagoButton.ForeColor = Color.Black;
            eliminarPagoButton.Location = new Point(276, 280);
            eliminarPagoButton.Margin = new Padding(4, 3, 4, 3);
            eliminarPagoButton.Name = "eliminarPagoButton";
            eliminarPagoButton.Size = new Size(125, 31);
            eliminarPagoButton.TabIndex = 30;
            eliminarPagoButton.Text = "Eliminar";
            eliminarPagoButton.UseVisualStyleBackColor = true;
            eliminarPagoButton.Click += eliminarPagoButton_Click;
            // 
            // guardarPagoButton
            // 
            guardarPagoButton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            guardarPagoButton.ForeColor = Color.Black;
            guardarPagoButton.Location = new Point(11, 280);
            guardarPagoButton.Margin = new Padding(4, 3, 4, 3);
            guardarPagoButton.Name = "guardarPagoButton";
            guardarPagoButton.Size = new Size(125, 31);
            guardarPagoButton.TabIndex = 29;
            guardarPagoButton.Text = "Guardar";
            guardarPagoButton.UseVisualStyleBackColor = true;
            guardarPagoButton.Click += guardarPagoButton_Click;
            // 
            // montoPagoTextBox
            // 
            montoPagoTextBox.Location = new Point(368, 50);
            montoPagoTextBox.Margin = new Padding(4, 3, 4, 3);
            montoPagoTextBox.Name = "montoPagoTextBox";
            montoPagoTextBox.Size = new Size(225, 23);
            montoPagoTextBox.TabIndex = 26;
            // 
            // montopagolabel
            // 
            montopagolabel.AutoSize = true;
            montopagolabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            montopagolabel.ForeColor = Color.Black;
            montopagolabel.Location = new Point(368, 27);
            montopagolabel.Margin = new Padding(4, 0, 4, 0);
            montopagolabel.Name = "montopagolabel";
            montopagolabel.Size = new Size(133, 20);
            montopagolabel.TabIndex = 25;
            montopagolabel.Text = "Monto A Pagar:";
            // 
            // fechapagolabel
            // 
            fechapagolabel.AutoSize = true;
            fechapagolabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fechapagolabel.ForeColor = Color.Black;
            fechapagolabel.Location = new Point(368, 138);
            fechapagolabel.Margin = new Padding(4, 0, 4, 0);
            fechapagolabel.Name = "fechapagolabel";
            fechapagolabel.Size = new Size(138, 20);
            fechapagolabel.TabIndex = 24;
            fechapagolabel.Text = "Fecha De Pago:";
            // 
            // pdfpagosbutton
            // 
            pdfpagosbutton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            pdfpagosbutton.ForeColor = Color.Black;
            pdfpagosbutton.Location = new Point(408, 280);
            pdfpagosbutton.Margin = new Padding(4, 3, 4, 3);
            pdfpagosbutton.Name = "pdfpagosbutton";
            pdfpagosbutton.Size = new Size(125, 31);
            pdfpagosbutton.TabIndex = 35;
            pdfpagosbutton.Text = "PDF";
            pdfpagosbutton.UseVisualStyleBackColor = true;
            pdfpagosbutton.Click += pdfpagosbutton_Click;
            // 
            // PagosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(638, 321);
            Controls.Add(pdfpagosbutton);
            Controls.Add(pagoDateTimePicker);
            Controls.Add(contratoComboBox);
            Controls.Add(contratopagolabel);
            Controls.Add(titulopagoslabel);
            Controls.Add(pagosDataGridView);
            Controls.Add(editarPagoButton);
            Controls.Add(eliminarPagoButton);
            Controls.Add(guardarPagoButton);
            Controls.Add(montoPagoTextBox);
            Controls.Add(montopagolabel);
            Controls.Add(fechapagolabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PagosForm";
            Opacity = 0.8D;
            Text = "PagosForm";
            ((System.ComponentModel.ISupportInitialize)pagosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker pagoDateTimePicker;
        private ComboBox contratoComboBox;
        private Label contratopagolabel;
        private Label titulopagoslabel;
        private DataGridView pagosDataGridView;
        private Button editarPagoButton;
        private Button eliminarPagoButton;
        private Button guardarPagoButton;
        private TextBox montoPagoTextBox;
        private Label montopagolabel;
        private Label fechapagolabel;
        private Button pdfpagosbutton;
    }
}