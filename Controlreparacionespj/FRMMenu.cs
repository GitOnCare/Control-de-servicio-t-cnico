using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlreparacionespj
{
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMRegistroDeOrden frm = new FRMRegistroDeOrden();
            frm.ShowDialog();
        }
    }
}
