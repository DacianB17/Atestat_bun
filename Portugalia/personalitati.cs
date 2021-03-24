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

        private void bvasco_Click(object sender, EventArgs e)
        {
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("vascodagama.rtf");
            imagpersonalitati.Visible = true;
            Image image = Image.FromFile("vasco.jpg");
            imagpersonalitati.Image = image;
        }

        private void bpedro_Click(object sender, EventArgs e)
        {
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("pedroalvarescabral.rtf");
            imagpersonalitati.Visible = true;
            Image image = Image.FromFile("pedro.jpg");
            imagpersonalitati.Image = image;
        }

        private void bmaria_Click(object sender, EventArgs e)
        {
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("maria1.rtf");
            imagpersonalitati.Visible = true;
            Image image = Image.FromFile("maria.jpg");
            imagpersonalitati.Image = image;
        }

        private void bcristiano_Click(object sender, EventArgs e)
        {
            rtbpersonalitati.Visible = true;
            rtbpersonalitati.LoadFile("cristianoronaldo.rtf");
            imagpersonalitati.Visible = true;
            Image image = Image.FromFile("cristiano.jpg");
            imagpersonalitati.Image = image;
        }
    }
}
