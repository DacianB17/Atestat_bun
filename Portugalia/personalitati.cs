using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portugalia
{
    public partial class personalitati : Form
    {
        public personalitati()
        {
            InitializeComponent();
        }
        private void pbvasco_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1123, 574);
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("vascodagama.rtf");
        }
        private void pbpedro_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1123, 574);
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("pedroalvarescabral.rtf");
        }
        private void pbmaria_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1123, 574);
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("maria1.rtf");
        }
        private void pbcristiano_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1123, 574);
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("cristianoronaldo.rtf");
        }
    }
}
