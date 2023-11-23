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
            ((System.ComponentModel.ISupportInitialize)mantenimientoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mantenimientoDateTimePicker
            // 
            mantenimientoDateTimePicker.Location = new Point(433, 62);
            mantenimientoDateTimePicker.Name = "mantenimientoDateTimePicker";
            mantenimientoDateTimePicker.Size = new Size(273, 27);
            mantenimientoDateTimePicker.TabIndex = 49;
            // 
            // costoTextbox
            // 
            costoTextbox.Location = new Point(435, 214);
            costoTextbox.Margin = new Padding(4);
            costoTextbox.Name = "costoTextbox";
            costoTextbox.Size = new Size(272, 27);
            costoTextbox.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(435, 184);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 26);
            label9.TabIndex = 47;
            label9.Text = "Costo:";
            // 
            // propiedadComboBox
            // 
            propiedadComboBox.FormattingEnabled = true;
            propiedadComboBox.Location = new Point(434, 294);
            propiedadComboBox.Name = "propiedadComboBox";
            propiedadComboBox.Size = new Size(272, 28);
            propiedadComboBox.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(435, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 45;
            label4.Text = "Propiedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(13, -1);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(335, 30);
            label5.TabIndex = 44;
            label5.Text = "Lista De Mantenimientos";
            // 
            // mantenimientoDataGridView
            // 
            mantenimientoDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            mantenimientoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mantenimientoDataGridView.Location = new Point(12, 33);
            mantenimientoDataGridView.Margin = new Padding(4);
            mantenimientoDataGridView.Name = "mantenimientoDataGridView";
            mantenimientoDataGridView.RowHeadersWidth = 51;
            mantenimientoDataGridView.RowTemplate.Height = 29;
            mantenimientoDataGridView.Size = new Size(415, 344);
            mantenimientoDataGridView.TabIndex = 40;
            // 
            // editarMantenimientoButton
            // 
            editarMantenimientoButton.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            editarMantenimientoButton.ForeColor = Color.Black;
            editarMantenimientoButton.Location = new Point(163, 385);
            editarMantenimientoButton.Margin = new Padding(4);
            editarMantenimientoButton.Name = "editarMantenimientoButton";
            editarMantenimientoButton.Size = new Size(143, 41);
            editarMantenimientoButton.TabIndex = 41;
            editarMantenimientoButton.Text = "Editar";
            editarMantenimientoButton.UseVisualStyleBackColor = true;
            editarMantenimientoButton.Click += editarMantenimientoButton_Click;
            // 
            // eliminarMantenimientoButton
            // 
            eliminarMantenimientoButton.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarMantenimientoButton.ForeColor = Color.Black;
            eliminarMantenimientoButton.Location = new Point(314, 385);
            eliminarMantenimientoButton.Margin = new Padding(4);
            eliminarMantenimientoButton.Name = "eliminarMantenimientoButton";
            eliminarMantenimientoButton.Size = new Size(143, 41);
            eliminarMantenimientoButton.TabIndex = 43;
            eliminarMantenimientoButton.Text = "Eliminar";
            eliminarMantenimientoButton.UseVisualStyleBackColor = true;
            eliminarMantenimientoButton.Click += eliminarMantenimientoButton_Click;
            // 
            // guardarMantenimientoButton
            // 
            guardarMantenimientoButton.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            guardarMantenimientoButton.ForeColor = Color.Black;
            guardarMantenimientoButton.Location = new Point(12, 385);
            guardarMantenimientoButton.Margin = new Padding(4);
            guardarMantenimientoButton.Name = "guardarMantenimientoButton";
            guardarMantenimientoButton.Size = new Size(143, 41);
            guardarMantenimientoButton.TabIndex = 42;
            guardarMantenimientoButton.Text = "Guardar";
            guardarMantenimientoButton.UseVisualStyleBackColor = true;
            guardarMantenimientoButton.Click += guardarMantenimientoButton_Click;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(433, 141);
            descripcionTextBox.Margin = new Padding(4);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(273, 27);
            descripcionTextBox.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(434, 33);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(252, 26);
            label7.TabIndex = 38;
            label7.Text = "Fecha Mantenimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(433, 111);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 26);
            label8.TabIndex = 37;
            label8.Text = "Descripcion:";
            // 
            // MantenimientoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(729, 428);
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
    }
}