namespace Portugalia
{
    partial class istoric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(istoric));
            this.tbistoric = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbistoric
            // 
            this.tbistoric.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbistoric.Location = new System.Drawing.Point(1, 0);
            this.tbistoric.Multiline = true;
            this.tbistoric.Name = "tbistoric";
            this.tbistoric.ReadOnly = true;
            this.tbistoric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbistoric.Size = new System.Drawing.Size(799, 451);
            this.tbistoric.TabIndex = 0;
            this.tbistoric.Text = resources.GetString("tbistoric.Text");
            // 
            // istoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbistoric);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "istoric";
            this.Text = "Istoric";
            this.Load += new System.EventHandler(this.istoric_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbistoric;
    }
}