namespace PresentatorLayer.Forms
{
    partial class MantenimientoForm
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
            pdfMantenimientobutton = new Button();
            ((System.ComponentModel.ISupportInitialize)mantenimientoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mantenimientoDateTimePicker
            // 
            mantenimientoDateTimePicker.Location = new Point(379, 46);
            mantenimientoDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            mantenimientoDateTimePicker.Name = "mantenimientoDateTimePicker";
            mantenimientoDateTimePicker.Size = new Size(239, 23);
            mantenimientoDateTimePicker.TabIndex = 49;
            // 
            // costoTextbox
            // 
            costoTextbox.Location = new Point(381, 160);
            costoTextbox.Margin = new Padding(4, 3, 4, 3);
            costoTextbox.Name = "costoTextbox";
            costoTextbox.Size = new Size(238, 23);
            costoTextbox.TabIndex = 48;
            costoTextbox.KeyPress += costoTextbox_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(381, 138);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 47;
            label9.Text = "Costo:";
            // 
            // propiedadComboBox
            // 
            propiedadComboBox.FormattingEnabled = true;
            propiedadComboBox.Location = new Point(380, 220);
            propiedadComboBox.Margin = new Padding(3, 2, 3, 2);
            propiedadComboBox.Name = "propiedadComboBox";
            propiedadComboBox.Size = new Size(238, 23);
            propiedadComboBox.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(381, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 45;
            label4.Text = "Propiedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(11, -1);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(237, 24);
            label5.TabIndex = 44;
            label5.Text = "Lista De Mantenimientos";
            // 
            // mantenimientoDataGridView
            // 
            mantenimientoDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            mantenimientoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mantenimientoDataGridView.Location = new Point(10, 25);
            mantenimientoDataGridView.Margin = new Padding(4, 3, 4, 3);
            mantenimientoDataGridView.Name = "mantenimientoDataGridView";
            mantenimientoDataGridView.RowHeadersWidth = 51;
            mantenimientoDataGridView.RowTemplate.Height = 29;
            mantenimientoDataGridView.Size = new Size(363, 258);
            mantenimientoDataGridView.TabIndex = 40;
            // 
            // editarMantenimientoButton
            // 
            editarMantenimientoButton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            editarMantenimientoButton.ForeColor = Color.Black;
            editarMantenimientoButton.Location = new Point(143, 289);
            editarMantenimientoButton.Margin = new Padding(4, 3, 4, 3);
            editarMantenimientoButton.Name = "editarMantenimientoButton";
            editarMantenimientoButton.Size = new Size(125, 31);
            editarMantenimientoButton.TabIndex = 41;
            editarMantenimientoButton.Text = "Editar";
            editarMantenimientoButton.UseVisualStyleBackColor = true;
            editarMantenimientoButton.Click += editarMantenimientoButton_Click;
            // 
            // eliminarMantenimientoButton
            // 
            eliminarMantenimientoButton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarMantenimientoButton.ForeColor = Color.Black;
            eliminarMantenimientoButton.Location = new Point(275, 289);
            eliminarMantenimientoButton.Margin = new Padding(4, 3, 4, 3);
            eliminarMantenimientoButton.Name = "eliminarMantenimientoButton";
            eliminarMantenimientoButton.Size = new Size(125, 31);
            eliminarMantenimientoButton.TabIndex = 43;
            eliminarMantenimientoButton.Text = "Eliminar";
            eliminarMantenimientoButton.UseVisualStyleBackColor = true;
            eliminarMantenimientoButton.Click += eliminarMantenimientoButton_Click;
            // 
            // guardarMantenimientoButton
            // 
            guardarMantenimientoButton.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            guardarMantenimientoButton.ForeColor = Color.Black;
            guardarMantenimientoButton.Location = new Point(10, 289);
            guardarMantenimientoButton.Margin = new Padding(4, 3, 4, 3);
            guardarMantenimientoButton.Name = "guardarMantenimientoButton";
            guardarMantenimientoButton.Size = new Size(125, 31);
            guardarMantenimientoButton.TabIndex = 42;
            guardarMantenimientoButton.Text = "Guardar";
            guardarMantenimientoButton.UseVisualStyleBackColor = true;
            guardarMantenimientoButton.Click += guardarMantenimientoButton_Click;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(379, 106);
            descripcionTextBox.Margin = new Padding(4, 3, 4, 3);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(239, 23);
            descripcionTextBox.TabIndex = 39;
            descripcionTextBox.KeyPress += descripcionTextBox_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(380, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(187, 20);
            label7.TabIndex = 38;
            label7.Text = "Fecha Mantenimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(379, 83);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 37;
            label8.Text = "Descripcion:";
            // 
            // pdfMantenimientobutton
            // 
            pdfMantenimientobutton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pdfMantenimientobutton.ForeColor = SystemColors.ActiveCaptionText;
            pdfMantenimientobutton.Location = new Point(407, 289);
            pdfMantenimientobutton.Margin = new Padding(3, 2, 3, 2);
            pdfMantenimientobutton.Name = "pdfMantenimientobutton";
            pdfMantenimientobutton.Size = new Size(117, 31);
            pdfMantenimientobutton.TabIndex = 76;
            pdfMantenimientobutton.Text = "PDF";
            pdfMantenimientobutton.UseVisualStyleBackColor = true;
            pdfMantenimientobutton.Click += pdfMantenimientobutton_Click;
            // 
            // MantenimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(638, 321);
            Controls.Add(pdfMantenimientobutton);
            Controls.Add(mantenimientoDateTimePicker);
            Controls.Add(costoTextbox);
            Controls.Add(label9);
            Controls.Add(propiedadComboBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(mantenimientoDataGridView);
            Controls.Add(editarMantenimientoButton);
            Controls.Add(eliminarMantenimientoButton);
            Controls.Add(guardarMantenimientoButton);
            Controls.Add(descripcionTextBox);
            Controls.Add(label7);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MantenimientoForm";
            Opacity = 0.8D;
            Text = "MantenimientoForm";
            ((System.ComponentModel.ISupportInitialize)mantenimientoDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker mantenimientoDateTimePicker;
        private TextBox costoTextbox;
        private Label label9;
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
        private Button pdfMantenimientobutton;
    }
}