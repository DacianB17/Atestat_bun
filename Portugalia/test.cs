﻿using System;
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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            labelnext.Visible = true;
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            labelnext.Visible = true;
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            labelnext.Visible = true;
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            labelnext.Visible = true;
        }

        private void rb13_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            labelnext.Visible = true;
        }

        private void rb18_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            intrebarea6.Visible = false;
            if (i == 6)
                MessageBox.Show("6/6, Bravo!!");
            else
                MessageBox.Show("Mai încearcă!");
        }

        private void labelsintra_Click(object sender, EventArgs e)
        {
            intrebarea1.Location = new Point(12, 12);
            intrebarea1.Visible = true;
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb11_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb12_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb14_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb15_CheckedChanged(object sender, EventArgs e)
        {
            labelnext.Visible = true;
        }

        private void rb16_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Mai încearcă!");
            intrebarea6.Visible = false;
        }

        private void rb17_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Mai încearcă!");
            intrebarea6.Visible = false;
        }
        int j = 0;
        private void labelnext_Click(object sender, EventArgs e)
        {
            labelnext.Visible = false;
            j++;
            if(j==1)
            {
                intrebarea1.Visible = false;
                intrebarea1.Location = new Point(12, 369);
                intrebarea2.Location = new Point(12, 12);
                intrebarea2.Visible = true;
            }
            if(j==2)
            {
                intrebarea2.Visible = false;
                intrebarea2.Location = new Point(12, 369);
                intrebarea3.Location = new Point(12, 12);
                intrebarea3.Visible = true;
            }
            if(j==3)
            {
                intrebarea3.Visible = false;
                intrebarea3.Location = new Point(12, 369);
                intrebarea4.Location = new Point(12, 12);
                intrebarea4.Visible = true;
            }
            if(j==4)
            {
                intrebarea4.Visible = false;
                intrebarea4.Location = new Point(12, 369);
                intrebarea5.Location = new Point(12, 12);
                intrebarea5.Visible = true;
            }
            if(j==5)
            {
                intrebarea5.Visible = false;
                intrebarea5.Location = new Point(12, 369);
                intrebarea6.Location = new Point(12, 12);
                intrebarea6.Visible = true;
                labelnext.Visible = false;
                j = 0;
            }
        }
    }
}
