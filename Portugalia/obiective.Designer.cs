namespace Portugalia
{
    partial class obiective
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(obiective));
            this.labelfundal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelfundal
            // 
            this.labelfundal.AutoSize = true;
            this.labelfundal.BackColor = System.Drawing.Color.Transparent;
            this.labelfundal.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfundal.ForeColor = System.Drawing.Color.White;
            this.labelfundal.Location = new System.Drawing.Point(696, 27);
            this.labelfundal.Name = "labelfundal";
            this.labelfundal.Size = new System.Drawing.Size(190, 39);
            this.labelfundal.TabIndex = 13;
            this.labelfundal.Text = "Estadio Da Luz";
            // 
            // obiective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.labelfundal);
            this.Name = "obiective";
            this.Text = "Obiective turistice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfundal;
    }
}