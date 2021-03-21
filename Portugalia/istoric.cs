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
    public partial class istoric : Form
    {
        public istoric()
        {
            InitializeComponent();
        }

        private void istoric_Load(object sender, EventArgs e)
        {
            tbistoric.ReadOnly = true;
        }
    }
}
