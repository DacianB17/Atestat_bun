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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bistoric_Click(object sender, EventArgs e)
        {
            rtbistoric.Visible = true;
            rtbistoric.LoadFile("istoric.rtf");
        }

        private void borase_Click(object sender, EventArgs e)
        {
            rtbistoric.Visible = false;
            Form or = new orase();
            or.Show();
        }

        private void btest_Click(object sender, EventArgs e)
        {
        }

        private void butontest_Click(object sender, EventArgs e)
        {
            rtbistoric.Visible = false;
            Form te = new test();
            te.Show();
        }

        private void bpersonalitati_Click(object sender, EventArgs e)
        {
            rtbistoric.Visible = false;
            Form pe = new personalitati();
            pe.Show();
        }

        private void labelistoric_Click(object sender, EventArgs e)
        {
            labelfundal.Visible = false;
            tbdespre.Visible = false;
            rtbistoric.Visible = true;
            rtbistoric.LoadFile("istoric.rtf");
        }

        private void labelorase_Click(object sender, EventArgs e)
        {
            if (labelfundal.Visible == false)
                labelfundal.Visible = true;
            tbdespre.Visible = false;
            rtbistoric.Visible = false;
            Form or = new orase();
            or.Show();
        }

        private void labelpersonalitati_Click(object sender, EventArgs e)
        {
            if (labelfundal.Visible == false)
                labelfundal.Visible = true;
            tbdespre.Visible = false;
            rtbistoric.Visible = false;
            Form pe = new personalitati();
            pe.Show();
        }

        private void labeltest_Click(object sender, EventArgs e)
        {
            if (labelfundal.Visible == false)
                labelfundal.Visible = true;
            tbdespre.Visible = false;
            rtbistoric.Visible = false;
            Form te = new test();
            te.Show();
        }

        private void labelinfgen_Click(object sender, EventArgs e)
        {
            if (labelfundal.Visible == false)
                labelfundal.Visible = true;
            tbdespre.Visible = false;
            rtbistoric.Visible = false;
            Form ig = new infgen();
            ig.Show();
        }

        private void labeliesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labeldespre_Click(object sender, EventArgs e)
        {
            if (labelfundal.Visible == false)
                labelfundal.Visible = true;
            rtbistoric.Visible = false;
            tbdespre.Visible = true;
        }

        private void labelobiective_Click(object sender, EventArgs e)
        {
            if (labelfundal.Visible == false)
                labelfundal.Visible = true;
            tbdespre.Visible = false;
            rtbistoric.Visible = false;
            Form ob = new obiective();
            ob.Show();
        }
    }
}
