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
            this.bistoric = new System.Windows.Forms.Button();
            this.borase = new System.Windows.Forms.Button();
            this.butontest = new System.Windows.Forms.Button();
            this.bpersonalitati = new System.Windows.Forms.Button();
            this.rtbistoric = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bistoric
            // 
            this.bistoric.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bistoric.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bistoric.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bistoric.Location = new System.Drawing.Point(13, 28);
            this.bistoric.Name = "bistoric";
            this.bistoric.Size = new System.Drawing.Size(130, 50);
            this.bistoric.TabIndex = 0;
            this.bistoric.Text = "Istoric";
            this.bistoric.UseVisualStyleBackColor = false;
            this.bistoric.Click += new System.EventHandler(this.bistoric_Click);
            // 
            // borase
            // 
            this.borase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borase.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.borase.Location = new System.Drawing.Point(13, 94);
            this.borase.Name = "borase";
            this.borase.Size = new System.Drawing.Size(130, 50);
            this.borase.TabIndex = 2;
            this.borase.Text = "Orașe";
            this.borase.UseVisualStyleBackColor = false;
            this.borase.Click += new System.EventHandler(this.borase_Click);
            // 
            // butontest
            // 
            this.butontest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butontest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butontest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butontest.Location = new System.Drawing.Point(13, 157);
            this.butontest.Name = "butontest";
            this.butontest.Size = new System.Drawing.Size(130, 50);
            this.butontest.TabIndex = 3;
            this.butontest.Text = "Test";
            this.butontest.UseVisualStyleBackColor = false;
            this.butontest.Click += new System.EventHandler(this.butontest_Click);
            // 
            // bpersonalitati
            // 
            this.bpersonalitati.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bpersonalitati.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpersonalitati.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bpersonalitati.Location = new System.Drawing.Point(13, 221);
            this.bpersonalitati.Name = "bpersonalitati";
            this.bpersonalitati.Size = new System.Drawing.Size(130, 50);
            this.bpersonalitati.TabIndex = 4;
            this.bpersonalitati.Text = "Personalități";
            this.bpersonalitati.UseVisualStyleBackColor = false;
            this.bpersonalitati.Click += new System.EventHandler(this.bpersonalitati_Click);
            // 
            // rtbistoric
            // 
            this.rtbistoric.Location = new System.Drawing.Point(330, 28);
            this.rtbistoric.Name = "rtbistoric";
            this.rtbistoric.ReadOnly = true;
            this.rtbistoric.Size = new System.Drawing.Size(470, 441);
            this.rtbistoric.TabIndex = 6;
            this.rtbistoric.Text = "";
            this.rtbistoric.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.rtbistoric);
            this.Controls.Add(this.bpersonalitati);
            this.Controls.Add(this.butontest);
            this.Controls.Add(this.borase);
            this.Controls.Add(this.bistoric);
            this.Name = "Principal";
            this.Text = "Portugalia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bistoric;
        private System.Windows.Forms.Button borase;
        private System.Windows.Forms.Button butontest;
        private System.Windows.Forms.Button bpersonalitati;
        private System.Windows.Forms.RichTextBox rtbistoric;
    }
}

