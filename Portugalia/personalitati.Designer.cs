namespace Portugalia
{
    partial class personalitati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personalitati));
            this.rtbpersonalitati = new System.Windows.Forms.RichTextBox();
            this.imagpersonalitati = new System.Windows.Forms.PictureBox();
            this.bvasco = new System.Windows.Forms.Label();
            this.bpedro = new System.Windows.Forms.Label();
            this.bmaria = new System.Windows.Forms.Label();
            this.bcristiano = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagpersonalitati)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbpersonalitati
            // 
            this.rtbpersonalitati.Location = new System.Drawing.Point(106, 73);
            this.rtbpersonalitati.Name = "rtbpersonalitati";
            this.rtbpersonalitati.ReadOnly = true;
            this.rtbpersonalitati.Size = new System.Drawing.Size(470, 563);
            this.rtbpersonalitati.TabIndex = 7;
            this.rtbpersonalitati.Text = "";
            this.rtbpersonalitati.Visible = false;
            // 
            // imagpersonalitati
            // 
            this.imagpersonalitati.Location = new System.Drawing.Point(595, 73);
            this.imagpersonalitati.Name = "imagpersonalitati";
            this.imagpersonalitati.Size = new System.Drawing.Size(572, 563);
            this.imagpersonalitati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagpersonalitati.TabIndex = 8;
            this.imagpersonalitati.TabStop = false;
            this.imagpersonalitati.Visible = false;
            // 
            // bvasco
            // 
            this.bvasco.AutoSize = true;
            this.bvasco.Location = new System.Drawing.Point(309, 19);
            this.bvasco.Name = "bvasco";
            this.bvasco.Size = new System.Drawing.Size(109, 17);
            this.bvasco.TabIndex = 9;
            this.bvasco.Text = "Vasco da Gama";
            this.bvasco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bvasco.Click += new System.EventHandler(this.bvasco_Click);
            // 
            // bpedro
            // 
            this.bpedro.AutoSize = true;
            this.bpedro.Location = new System.Drawing.Point(434, 19);
            this.bpedro.Name = "bpedro";
            this.bpedro.Size = new System.Drawing.Size(142, 17);
            this.bpedro.TabIndex = 10;
            this.bpedro.Text = "Pedro Alvares Cabral";
            this.bpedro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bpedro.Click += new System.EventHandler(this.bpedro_Click);
            // 
            // bmaria
            // 
            this.bmaria.AutoSize = true;
            this.bmaria.Location = new System.Drawing.Point(592, 19);
            this.bmaria.Name = "bmaria";
            this.bmaria.Size = new System.Drawing.Size(50, 17);
            this.bmaria.TabIndex = 11;
            this.bmaria.Text = "Maria I";
            this.bmaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bmaria.Click += new System.EventHandler(this.bmaria_Click);
            // 
            // bcristiano
            // 
            this.bcristiano.AutoSize = true;
            this.bcristiano.Location = new System.Drawing.Point(658, 19);
            this.bcristiano.Name = "bcristiano";
            this.bcristiano.Size = new System.Drawing.Size(120, 17);
            this.bcristiano.TabIndex = 12;
            this.bcristiano.Text = "Cristiano Ronaldo";
            this.bcristiano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bcristiano.Click += new System.EventHandler(this.bcristiano_Click);
            // 
            // personalitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 674);
            this.Controls.Add(this.bcristiano);
            this.Controls.Add(this.bmaria);
            this.Controls.Add(this.bpedro);
            this.Controls.Add(this.bvasco);
            this.Controls.Add(this.imagpersonalitati);
            this.Controls.Add(this.rtbpersonalitati);
            this.Name = "personalitati";
            this.Text = "Personalitati";
            ((System.ComponentModel.ISupportInitialize)(this.imagpersonalitati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbpersonalitati;
        private System.Windows.Forms.PictureBox imagpersonalitati;
        private System.Windows.Forms.Label bvasco;
        private System.Windows.Forms.Label bpedro;
        private System.Windows.Forms.Label bmaria;
        private System.Windows.Forms.Label bcristiano;
    }
}