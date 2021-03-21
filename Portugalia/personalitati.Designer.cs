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
            this.blisabona = new System.Windows.Forms.Button();
            this.rtbpersonalitati = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // blisabona
            // 
            this.blisabona.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blisabona.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blisabona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blisabona.Location = new System.Drawing.Point(3, 2);
            this.blisabona.Name = "blisabona";
            this.blisabona.Size = new System.Drawing.Size(105, 60);
            this.blisabona.TabIndex = 2;
            this.blisabona.Text = "Vasco da Gama";
            this.blisabona.UseVisualStyleBackColor = false;
            this.blisabona.Click += new System.EventHandler(this.blisabona_Click);
            // 
            // rtbpersonalitati
            // 
            this.rtbpersonalitati.Location = new System.Drawing.Point(3, 68);
            this.rtbpersonalitati.Name = "rtbpersonalitati";
            this.rtbpersonalitati.Size = new System.Drawing.Size(795, 379);
            this.rtbpersonalitati.TabIndex = 7;
            this.rtbpersonalitati.Text = "";
            // 
            // personalitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbpersonalitati);
            this.Controls.Add(this.blisabona);
            this.Name = "personalitati";
            this.Text = "personalitati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button blisabona;
        private System.Windows.Forms.RichTextBox rtbpersonalitati;
    }
}