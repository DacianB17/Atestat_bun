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
    public partial class obiective : Form
    {
        int i = 0;
        public obiective()
        {
            InitializeComponent();
        }

        private void labelfundal_Click(object sender, EventArgs e)
        {
            labeldaluz.Visible = true;
            labelnext.Visible = true;
            if (i == 3)
                labelpena.Visible = false;
            i = 0;
        }

        private void labelnext_Click(object sender, EventArgs e)
        {
            i++;
            if(i==1)
            {
                labeldaluz.Visible = false;
                labelbelem.Visible = true;
                labelbelem.Location = labeldaluz.Location;
            }
            if(i==2)
            {
                labelbelem.Visible = false;
                labelbairro.Visible = true;
                labelbairro.Location = labelbelem.Location;
            }
            if(i==3)
            {
                labelbairro.Visible = false;
                labelpena.Visible = true;
                labelpena.Location = labelbairro.Location;
                labelnext.Visible = false;
            }    
        }
    }
}
