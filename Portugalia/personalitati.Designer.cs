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
            this.pbvasco = new System.Windows.Forms.PictureBox();
            this.pbpedro = new System.Windows.Forms.PictureBox();
            this.pbmaria = new System.Windows.Forms.PictureBox();
            this.pbcristiano = new System.Windows.Forms.PictureBox();
            this.rtbpersonalitati = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbvasco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpedro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcristiano)).BeginInit();
            this.SuspendLayout();
            // 
            // pbvasco
            // 
            this.pbvasco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbvasco.Image = ((System.Drawing.Image)(resources.GetObject("pbvasco.Image")));
            this.pbvasco.Location = new System.Drawing.Point(0, 0);
            this.pbvasco.Name = "pbvasco";
            this.pbvasco.Size = new System.Drawing.Size(311, 397);
            this.pbvasco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbvasco.TabIndex = 0;
            this.pbvasco.TabStop = false;
            this.pbvasco.Click += new System.EventHandler(this.pbvasco_Click);
            // 
            // pbpedro
            // 
            this.pbpedro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpedro.Image = ((System.Drawing.Image)(resources.GetObject("pbpedro.Image")));
            this.pbpedro.Location = new System.Drawing.Point(1070, 0);
            this.pbpedro.Name = "pbpedro";
            this.pbpedro.Size = new System.Drawing.Size(422, 397);
            this.pbpedro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpedro.TabIndex = 1;
            this.pbpedro.TabStop = false;
            this.pbpedro.Click += new System.EventHandler(this.pbpedro_Click);
            // 
            // pbmaria
            // 
            this.pbmaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbmaria.Image = ((System.Drawing.Image)(resources.GetObject("pbmaria.Image")));
            this.pbmaria.Location = new System.Drawing.Point(311, 0);
            this.pbmaria.Name = "pbmaria";
            this.pbmaria.Size = new System.Drawing.Size(363, 397);
            this.pbmaria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmaria.TabIndex = 2;
            this.pbmaria.TabStop = false;
            this.pbmaria.Click += new System.EventHandler(this.pbmaria_Click);
            // 
            // pbcristiano
            // 
            this.pbcristiano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbcristiano.Image = ((System.Drawing.Image)(resources.GetObject("pbcristiano.Image")));
            this.pbcristiano.Location = new System.Drawing.Point(672, 0);
            this.pbcristiano.Name = "pbcristiano";
            this.pbcristiano.Size = new System.Drawing.Size(419, 397);
            this.pbcristiano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcristiano.TabIndex = 3;
            this.pbcristiano.TabStop = false;
            this.pbcristiano.Click += new System.EventHandler(this.pbcristiano_Click);
            // 
            // rtbpersonalitati
            // 
            this.rtbpersonalitati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbpersonalitati.Location = new System.Drawing.Point(0, 397);
            this.rtbpersonalitati.Name = "rtbpersonalitati";
            this.rtbpersonalitati.ReadOnly = true;
            this.rtbpersonalitati.Size = new System.Drawing.Size(1472, 259);
            this.rtbpersonalitati.TabIndex = 4;
            this.rtbpersonalitati.Text = "";
            this.rtbpersonalitati.Visible = false;
            // 
            // personalitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1475, 396);
            this.Controls.Add(this.rtbpersonalitati);
            this.Controls.Add(this.pbcristiano);
            this.Controls.Add(this.pbmaria);
            this.Controls.Add(this.pbpedro);
            this.Controls.Add(this.pbvasco);
            this.Name = "personalitati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalități";
            ((System.ComponentModel.ISupportInitialize)(this.pbvasco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpedro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcristiano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbvasco;
        private System.Windows.Forms.PictureBox pbpedro;
        private System.Windows.Forms.PictureBox pbmaria;
        private System.Windows.Forms.PictureBox pbcristiano;
        private System.Windows.Forms.RichTextBox rtbpersonalitati;
    }
}