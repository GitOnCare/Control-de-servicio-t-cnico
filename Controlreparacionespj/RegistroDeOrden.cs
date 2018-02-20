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
    public partial class RegistroDeOrden : Form
    {
        public RegistroDeOrden()
        {
            InitializeComponent();
        }

        private void RegistroDeOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reparacionesDS.tipos' Puede moverla o quitarla según sea necesario.
            this.tiposTableAdapter.Fill(this.reparacionesDS.tipos);


        }

        //Llenar combobox tipos

        private void Llenar_combobox_Tipos(object sender, EventArgs e)
        {

        } 
    }
}
