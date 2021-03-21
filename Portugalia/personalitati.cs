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

        private void blisabona_Click(object sender, EventArgs e)
        {
            rtbpersonalitati.LoadFile("vascodagama.rtf");
        }
    }
}
