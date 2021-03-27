namespace Portugalia
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.rtbistoric = new System.Windows.Forms.RichTextBox();
            this.labelistoric = new System.Windows.Forms.Label();
            this.labelorase = new System.Windows.Forms.Label();
            this.labelpersonalitati = new System.Windows.Forms.Label();
            this.labeltest = new System.Windows.Forms.Label();
            this.labelinfgen = new System.Windows.Forms.Label();
            this.labeliesire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbistoric
            // 
            this.rtbistoric.Location = new System.Drawing.Point(330, 36);
            this.rtbistoric.Name = "rtbistoric";
            this.rtbistoric.ReadOnly = true;
            this.rtbistoric.Size = new System.Drawing.Size(454, 419);
            this.rtbistoric.TabIndex = 6;
            this.rtbistoric.Text = "";
            this.rtbistoric.Visible = false;
            // 
            // labelistoric
            // 
            this.labelistoric.AutoSize = true;
            this.labelistoric.BackColor = System.Drawing.Color.Transparent;
            this.labelistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelistoric.ForeColor = System.Drawing.Color.White;
            this.labelistoric.Location = new System.Drawing.Point(12, 9);
            this.labelistoric.Name = "labelistoric";
            this.labelistoric.Size = new System.Drawing.Size(58, 24);
            this.labelistoric.TabIndex = 8;
            this.labelistoric.Text = "Istoric";
            this.labelistoric.Click += new System.EventHandler(this.labelistoric_Click);
            // 
            // labelorase
            // 
            this.labelorase.AutoSize = true;
            this.labelorase.BackColor = System.Drawing.Color.Transparent;
            this.labelorase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelorase.ForeColor = System.Drawing.Color.Transparent;
            this.labelorase.Location = new System.Drawing.Point(76, 9);
            this.labelorase.Name = "labelorase";
            this.labelorase.Size = new System.Drawing.Size(61, 24);
            this.labelorase.TabIndex = 9;
            this.labelorase.Text = "Orașe";
            this.labelorase.Click += new System.EventHandler(this.labelorase_Click);
            // 
            // labelpersonalitati
            // 
            this.labelpersonalitati.AutoSize = true;
            this.labelpersonalitati.BackColor = System.Drawing.Color.Transparent;
            this.labelpersonalitati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpersonalitati.ForeColor = System.Drawing.Color.White;
            this.labelpersonalitati.Location = new System.Drawing.Point(143, 9);
            this.labelpersonalitati.Name = "labelpersonalitati";
            this.labelpersonalitati.Size = new System.Drawing.Size(110, 24);
            this.labelpersonalitati.TabIndex = 10;
            this.labelpersonalitati.Text = "Personalități";
            this.labelpersonalitati.Click += new System.EventHandler(this.labelpersonalitati_Click);
            // 
            // labeltest
            // 
            this.labeltest.AutoSize = true;
            this.labeltest.BackColor = System.Drawing.Color.Transparent;
            this.labeltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltest.ForeColor = System.Drawing.Color.White;
            this.labeltest.Location = new System.Drawing.Point(259, 9);
            this.labeltest.Name = "labeltest";
            this.labeltest.Size = new System.Drawing.Size(46, 24);
            this.labeltest.TabIndex = 11;
            this.labeltest.Text = "Test";
            this.labeltest.Click += new System.EventHandler(this.labeltest_Click);
            // 
            // labelinfgen
            // 
            this.labelinfgen.AutoSize = true;
            this.labelinfgen.BackColor = System.Drawing.Color.Transparent;
            this.labelinfgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfgen.ForeColor = System.Drawing.Color.White;
            this.labelinfgen.Location = new System.Drawing.Point(311, 9);
            this.labelinfgen.Name = "labelinfgen";
            this.labelinfgen.Size = new System.Drawing.Size(164, 24);
            this.labelinfgen.TabIndex = 12;
            this.labelinfgen.Text = "Informații generale";
            this.labelinfgen.Click += new System.EventHandler(this.labelinfgen_Click);
            // 
            // labeliesire
            // 
            this.labeliesire.AutoSize = true;
            this.labeliesire.BackColor = System.Drawing.Color.Transparent;
            this.labeliesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeliesire.ForeColor = System.Drawing.Color.White;
            this.labeliesire.Location = new System.Drawing.Point(481, 9);
            this.labeliesire.Name = "labeliesire";
            this.labeliesire.Size = new System.Drawing.Size(55, 24);
            this.labeliesire.TabIndex = 13;
            this.labeliesire.Text = "Ieșire";
            this.labeliesire.Click += new System.EventHandler(this.labeliesire_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.labeliesire);
            this.Controls.Add(this.labelinfgen);
            this.Controls.Add(this.labeltest);
            this.Controls.Add(this.labelpersonalitati);
            this.Controls.Add(this.labelorase);
            this.Controls.Add(this.labelistoric);
            this.Controls.Add(this.rtbistoric);
            this.Name = "Principal";
            this.Text = "Portugalia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbistoric;
        private System.Windows.Forms.Label labelistoric;
        private System.Windows.Forms.Label labelorase;
        private System.Windows.Forms.Label labelpersonalitati;
        private System.Windows.Forms.Label labeltest;
        private System.Windows.Forms.Label labelinfgen;
        private System.Windows.Forms.Label labeliesire;
    }
}

