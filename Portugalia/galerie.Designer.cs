namespace Portugalia
{
    partial class galerie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.binainte = new System.Windows.Forms.Button();
            this.Inapoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // binainte
            // 
            this.binainte.Location = new System.Drawing.Point(669, 202);
            this.binainte.Name = "binainte";
            this.binainte.Size = new System.Drawing.Size(103, 56);
            this.binainte.TabIndex = 1;
            this.binainte.Text = "Inainte";
            this.binainte.UseVisualStyleBackColor = true;
            // 
            // Inapoi
            // 
            this.Inapoi.Location = new System.Drawing.Point(12, 202);
            this.Inapoi.Name = "Inapoi";
            this.Inapoi.Size = new System.Drawing.Size(103, 56);
            this.Inapoi.TabIndex = 2;
            this.Inapoi.Text = "Inapoi";
            this.Inapoi.UseVisualStyleBackColor = true;
            // 
            // galerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inapoi);
            this.Controls.Add(this.binainte);
            this.Controls.Add(this.pictureBox1);
            this.Name = "galerie";
            this.Text = "Galerie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button binainte;
        private System.Windows.Forms.Button Inapoi;
    }
}