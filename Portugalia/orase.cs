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
    public partial class orase : Form
    {
        public orase()
        {
            InitializeComponent();
        }

        private void orase_Load(object sender, EventArgs e)
        {

        }

        private void blisabona_Click(object sender, EventArgs e)
        {
            rtborase.LoadFile("lisabona.rtf");
        }

        private void rtborase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bporto_Click(object sender, EventArgs e)
        {
            rtborase.LoadFile("porto.rtf");
        }

        private void bbraga_Click(object sender, EventArgs e)
        {
            rtborase.LoadFile("braga.rtf");
        }

        private void bfunchal_Click(object sender, EventArgs e)
        {
            rtborase.LoadFile("funchal.rtf");
        }

        private void bsetubal_Click(object sender, EventArgs e)
        {
            rtborase.LoadFile("setubal.rtf");
        }

        private void bimagini_Click(object sender, EventArgs e)
        {
            rtborase.LoadFile("imagini.rtf");
        }
    }
}
