namespace Portugalia
{
    partial class orase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orase));
            this.rtborase = new System.Windows.Forms.RichTextBox();
            this.pbharta = new System.Windows.Forms.PictureBox();
            this.labellisabona = new System.Windows.Forms.Label();
            this.labelporto = new System.Windows.Forms.Label();
            this.labelbraga = new System.Windows.Forms.Label();
            this.labelsetubal = new System.Windows.Forms.Label();
            this.labelfundal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbharta)).BeginInit();
            this.SuspendLayout();
            // 
            // rtborase
            // 
            this.rtborase.Location = new System.Drawing.Point(610, 145);
            this.rtborase.Name = "rtborase";
            this.rtborase.ReadOnly = true;
            this.rtborase.Size = new System.Drawing.Size(673, 570);
            this.rtborase.TabIndex = 6;
            this.rtborase.Text = "";
            this.rtborase.Visible = false;
            this.rtborase.TextChanged += new System.EventHandler(this.rtborase_TextChanged);
            // 
            // pbharta
            // 
            this.pbharta.Image = ((System.Drawing.Image)(resources.GetObject("pbharta.Image")));
            this.pbharta.Location = new System.Drawing.Point(3, 6);
            this.pbharta.Name = "pbharta";
            this.pbharta.Size = new System.Drawing.Size(426, 813);
            this.pbharta.TabIndex = 7;
            this.pbharta.TabStop = false;
            this.pbharta.Visible = false;
            // 
            // labellisabona
            // 
            this.labellisabona.AutoSize = true;
            this.labellisabona.BackColor = System.Drawing.Color.Transparent;
            this.labellisabona.Location = new System.Drawing.Point(1280, 73);
            this.labellisabona.Name = "labellisabona";
            this.labellisabona.Size = new System.Drawing.Size(66, 17);
            this.labellisabona.TabIndex = 8;
            this.labellisabona.Text = "Lisabona";
            this.labellisabona.Visible = false;
            this.labellisabona.Click += new System.EventHandler(this.labellisabona_Click);
            // 
            // labelporto
            // 
            this.labelporto.AutoSize = true;
            this.labelporto.BackColor = System.Drawing.Color.Transparent;
            this.labelporto.Location = new System.Drawing.Point(1352, 73);
            this.labelporto.Name = "labelporto";
            this.labelporto.Size = new System.Drawing.Size(42, 17);
            this.labelporto.TabIndex = 9;
            this.labelporto.Text = "Porto";
            this.labelporto.Visible = false;
            this.labelporto.Click += new System.EventHandler(this.labelporto_Click);
            // 
            // labelbraga
            // 
            this.labelbraga.AutoSize = true;
            this.labelbraga.BackColor = System.Drawing.Color.Transparent;
            this.labelbraga.Location = new System.Drawing.Point(1280, 99);
            this.labelbraga.Name = "labelbraga";
            this.labelbraga.Size = new System.Drawing.Size(46, 17);
            this.labelbraga.TabIndex = 10;
            this.labelbraga.Text = "Braga";
            this.labelbraga.Visible = false;
            this.labelbraga.Click += new System.EventHandler(this.labelbraga_Click);
            // 
            // labelsetubal
            // 
            this.labelsetubal.AutoSize = true;
            this.labelsetubal.BackColor = System.Drawing.Color.Transparent;
            this.labelsetubal.Location = new System.Drawing.Point(1332, 99);
            this.labelsetubal.Name = "labelsetubal";
            this.labelsetubal.Size = new System.Drawing.Size(56, 17);
            this.labelsetubal.TabIndex = 11;
            this.labelsetubal.Text = "Setubal";
            this.labelsetubal.Visible = false;
            this.labelsetubal.Click += new System.EventHandler(this.labelsetubal_Click);
            // 
            // labelfundal
            // 
            this.labelfundal.AutoSize = true;
            this.labelfundal.BackColor = System.Drawing.Color.Transparent;
            this.labelfundal.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfundal.Location = new System.Drawing.Point(1276, 25);
            this.labelfundal.Name = "labelfundal";
            this.labelfundal.Size = new System.Drawing.Size(160, 39);
            this.labelfundal.TabIndex = 12;
            this.labelfundal.Text = "Turnul Belem";
            this.labelfundal.Click += new System.EventHandler(this.labelfundal_Click);
            // 
            // orase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1473, 826);
            this.Controls.Add(this.labelfundal);
            this.Controls.Add(this.labelsetubal);
            this.Controls.Add(this.labelbraga);
            this.Controls.Add(this.labelporto);
            this.Controls.Add(this.labellisabona);
            this.Controls.Add(this.pbharta);
            this.Controls.Add(this.rtborase);
            this.Name = "orase";
            this.Text = "Orase";
            this.Load += new System.EventHandler(this.orase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbharta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtborase;
        private System.Windows.Forms.PictureBox pbharta;
        private System.Windows.Forms.Label labellisabona;
        private System.Windows.Forms.Label labelporto;
        private System.Windows.Forms.Label labelbraga;
        private System.Windows.Forms.Label labelsetubal;
        private System.Windows.Forms.Label labelfundal;
    }
}