namespace PresentatorLayer.Forms
{
    partial class inquilinosForm
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
            tituloinquilinoslabel = new Label();
            ((System.ComponentModel.ISupportInitialize)inquilinosdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(-165, -1);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(130, 20);
            label18.TabIndex = 73;
            label18.Text = "Lista De Inquilinos";
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(410, 151);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(214, 27);
            direccionTextBox.TabIndex = 72;
            // 
            // direccionlabel
            // 
            direccionlabel.AutoSize = true;
            direccionlabel.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            direccionlabel.ForeColor = SystemColors.ActiveCaptionText;
            direccionlabel.Location = new Point(410, 117);
            direccionlabel.Name = "direccionlabel";
            direccionlabel.Size = new Size(139, 30);
            direccionlabel.TabIndex = 71;
            direccionlabel.Text = "Direccion";
            // 
            // editarInquilinoButton
            // 
            editarInquilinoButton.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            editarInquilinoButton.ForeColor = SystemColors.ActiveCaptionText;
            editarInquilinoButton.Location = new Point(12, 356);
            editarInquilinoButton.Name = "editarInquilinoButton";
            editarInquilinoButton.Size = new Size(118, 41);
            editarInquilinoButton.TabIndex = 70;
            editarInquilinoButton.Text = "Editar";
            editarInquilinoButton.UseVisualStyleBackColor = true;
            editarInquilinoButton.Click += editarInquilinoButton_Click;
            // 
            // eliminarInquilinoButton
            // 
            eliminarInquilinoButton.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarInquilinoButton.ForeColor = SystemColors.ActiveCaptionText;
            eliminarInquilinoButton.Location = new Point(261, 356);
            eliminarInquilinoButton.Name = "eliminarInquilinoButton";
            eliminarInquilinoButton.Size = new Size(134, 41);
            eliminarInquilinoButton.TabIndex = 69;
            eliminarInquilinoButton.Text = "Eliminar";
            eliminarInquilinoButton.UseVisualStyleBackColor = true;
            eliminarInquilinoButton.Click += eliminarInquilinoButton_Click;
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.Location = new Point(410, 228);
            telefonoTextbox.Name = "telefonoTextbox";
            telefonoTextbox.Size = new Size(214, 27);
            telefonoTextbox.TabIndex = 68;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(410, 310);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(214, 27);
            emailTextBox.TabIndex = 67;
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            emaillabel.ForeColor = SystemColors.ActiveCaptionText;
            emaillabel.Location = new Point(410, 194);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(125, 30);
            emaillabel.TabIndex = 66;
            emaillabel.Text = "Telefono";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(410, 269);
            label17.Name = "label17";
            label17.Size = new Size(83, 30);
            label17.TabIndex = 65;
            label17.Text = "Email";
            // 
            // guardarInquilinoButton
            // 
            guardarInquilinoButton.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            guardarInquilinoButton.ForeColor = SystemColors.ActiveCaptionText;
            guardarInquilinoButton.Location = new Point(136, 356);
            guardarInquilinoButton.Name = "guardarInquilinoButton";
            guardarInquilinoButton.Size = new Size(119, 41);
            guardarInquilinoButton.TabIndex = 64;
            guardarInquilinoButton.Text = "Guardar";
            guardarInquilinoButton.UseVisualStyleBackColor = true;
            guardarInquilinoButton.Click += guardarInquilinoButton_Click;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BackColor = SystemColors.HighlightText;
            nombreTextBox.ForeColor = SystemColors.InfoText;
            nombreTextBox.Location = new Point(410, 66);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(214, 27);
            nombreTextBox.TabIndex = 63;
            // 
            // nombrelabel
            // 
            nombrelabel.AutoSize = true;
            nombrelabel.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            nombrelabel.ForeColor = SystemColors.ActiveCaptionText;
            nombrelabel.Location = new Point(410, 32);
            nombrelabel.Name = "nombrelabel";
            nombrelabel.Size = new Size(97, 30);
            nombrelabel.TabIndex = 62;
            nombrelabel.Text = "Nombre";
            // 
            // inquilinosdataGridView
            // 
            inquilinosdataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            inquilinosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inquilinosdataGridView.Location = new Point(12, 32);
            inquilinosdataGridView.Name = "inquilinosdataGridView";
            inquilinosdataGridView.RowHeadersWidth = 51;
            inquilinosdataGridView.RowTemplate.Height = 29;
            inquilinosdataGridView.Size = new Size(377, 305);
            inquilinosdataGridView.TabIndex = 61;
            // 
            // tituloinquilinoslabel
            // 
            tituloinquilinoslabel.AutoSize = true;
            tituloinquilinoslabel.Font = new Font("JetBrains Mono NL SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tituloinquilinoslabel.ForeColor = Color.Black;
            tituloinquilinoslabel.Location = new Point(12, 3);
            tituloinquilinoslabel.Margin = new Padding(4, 0, 4, 0);
            tituloinquilinoslabel.Name = "tituloinquilinoslabel";
            tituloinquilinoslabel.Size = new Size(240, 26);
            tituloinquilinoslabel.TabIndex = 74;
            tituloinquilinoslabel.Text = "Lista De Inquilinos";
            // 
            // inquilinosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(729, 428);
            Controls.Add(tituloinquilinoslabel);
            Controls.Add(label18);
            Controls.Add(direccionTextBox);
            Controls.Add(direccionlabel);
            Controls.Add(editarInquilinoButton);
            Controls.Add(eliminarInquilinoButton);
            Controls.Add(telefonoTextbox);
            Controls.Add(emailTextBox);
            Controls.Add(emaillabel);
            Controls.Add(label17);
            Controls.Add(guardarInquilinoButton);
            Controls.Add(nombreTextBox);
            Controls.Add(nombrelabel);
            Controls.Add(inquilinosdataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inquilinosForm";
            Opacity = 0.8D;
            Text = "inquilinosForm";
            ((System.ComponentModel.ISupportInitialize)inquilinosdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label tituloinquilinoslabel;
    }
}