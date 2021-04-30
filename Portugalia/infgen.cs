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
    public partial class infgen : Form
    {
        public infgen()
        {
            InitializeComponent();
        }
        int i = 0;
        private void labelfundal_Click(object sender, EventArgs e)
        {
            i++;
            if(i==1)MessageBox.Show("Găsește numerele din fereastră pentru a afla lucruri noi despre această țară");
            labeldenof.Visible = true;
        }
        private void labeldenof_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denumire oficială: Republica Portugheză");
            labeldenof.Visible = false;
            labelcap.Visible = true;
        }

        private void labelcap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capitala: Lisabona");
            labelcap.Visible = false;
            labelsuprafata.Visible = true;
        }

        private void labelsuprafata_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suprafața: 92391 kmp");
            labelsuprafata.Visible = false;
            labelpopulatia.Visible = true;
        }

        private void labelpopulatia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Populația: 10295909 locuitori (2019)");
            labelpopulatia.Visible = false;
            labelmoneda.Visible = true;
        }

        private void labelmoneda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moneda: euro (EUR)");
            labelmoneda.Visible = false;
            labelformadeguv.Visible = true;
        }

        private void labelformadeguv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forma de guvernământ: democrație parlamentară");
            labelformadeguv.Visible = false;
            labelziuanat.Visible = true;
        }

        private void labelziuanat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ziua națională: 10 iunie");
            labelziuanat.Visible = false;
            labellimbaof.Visible = true;
        }

        private void labellimbaof_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limba oficială: portugheza");
            labellimbaof.Visible = false;
            labelreligie.Visible = true;
        }

        private void labelreligie_Click(object sender, EventArgs e)
        {
            labelreligie.Visible = false;
            MessageBox.Show("Religia: catolici 94% etc.");
        }

        private void infgen_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
