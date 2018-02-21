using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Controlreparacionespj
{
    public partial class RegistroDeOrden : Form
    {
        public RegistroDeOrden()
        {
            InitializeComponent();
        }
        public static string connectionstring = ConfigurationManager.ConnectionStrings["Controlreparacionespj"].ConnectionString;
        
        private void RegistroDeOrden_Load(object sender, EventArgs e)
        {
            Llenar_combobox_Tipos(sender, e);
            Llenar_combobox_Marcas(sender, e);
            Llenar_combobox_Estados(sender, e);
            LLenar_combobox_Estados_factura(sender, e);


        }

        //Llenar combobox tipos
        private void Llenar_combobox_Tipos(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionstring);
            DataTable tipos = new DataTable();
            using (conn)
            {
                string query = "Select id_tipo,descripcion from tipos";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(tipos);
            }

            cmbxtipo.DisplayMember = "descripcion";
            cmbxtipo.ValueMember = "id_tipo";
            cmbxtipo.DataSource = tipos;
        }
        //Llenar combobox Marcas
        private void Llenar_combobox_Marcas(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection(connectionstring);
            DataTable marcas = new DataTable();
            using (conn)
            {
                string query = "Select id_marca,marca from marcas";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(marcas);
            }
            cmbmarca.DisplayMember = "marca";
            cmbmarca.ValueMember = "id_marca";
            cmbmarca.DataSource = marcas;


        }
        //llenar combobox Estados
        private void Llenar_combobox_Estados(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionstring);
            DataTable estados = new DataTable();
            using (conn)
            {
                string query = "Select id_estado,descripcion from estados";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(estados);
            }
            cmbestado.DisplayMember = "descripcion";
            cmbestado.ValueMember = "id_estado";
            cmbestado.DataSource = estados;
        }
        //llenar combobox Estados factura
        private void LLenar_combobox_Estados_factura(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionstring);
            DataTable estadosfac = new DataTable();
            using (conn)
            {
                string query = "Select id_estadofact,descripcion from estados_fac";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(estadosfac);
            }
            cmbestadofac.DisplayMember = "descripcion";
            cmbestadofac.ValueMember = "id_estadofact";
            cmbestadofac.DataSource = estadosfac;
        }

        private void txtfnofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar !='.'))
            {
                e.Handled = true;
            }
            if((e.KeyChar=='.')&&((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        

        private void txttelefono_Enter_1(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txttelefono.Select(0, 0);
            });
        }
    }
}
              