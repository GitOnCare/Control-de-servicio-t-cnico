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
    public partial class FRMconsultaclientes : Form
    {
        public FRMconsultaclientes()
        {
            InitializeComponent();
        }

        private void FRMconsultaclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reparacionesDS.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.reparacionesDS.cliente);
            cmbfiltro.SelectedIndex = 0;
        }
        DataTable clientes = new DataTable();
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == 0)
            {
                DataView view = reparacionesDS.cliente.DefaultView;
                view.RowFilter = string.Format("" + cmbfiltro.Text + " like '%{0}%'", txtbuscar.Text);
                dgvclientes.DataSource = view.ToTable();
            }
        }
    }
}
