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
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            i++;
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            i++;
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            i++;
        }

        private void rb13_CheckedChanged(object sender, EventArgs e)
        {
            i++;
        }

        private void rb18_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            if (i == 6)
                MessageBox.Show("6/6, Bravo!!");
            else
                MessageBox.Show("Mai incearca!");
        }
    }
}
