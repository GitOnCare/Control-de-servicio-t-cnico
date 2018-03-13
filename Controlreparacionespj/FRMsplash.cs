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
    public partial class FRMsplash : Form
    {
        public FRMsplash()
        {
            InitializeComponent();
        }
        int i;
        private void FRMsplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 5;
            PB1.Value = i;
            lblpor.Text = i.ToString() + "%";
            if (i == 100)
            {
                timer1.Stop();
                this.Hide();
                FRMMenu frm = new FRMMenu();
                frm.Show();
            }
        }
    }
}
