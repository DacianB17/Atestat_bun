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
    }
}