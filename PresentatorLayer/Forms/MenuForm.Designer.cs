namespace PresentatorLayer.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 584);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.WindowText;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(254, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(911, 584);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(911, 2);
            label3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(881, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 584);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
    }
}