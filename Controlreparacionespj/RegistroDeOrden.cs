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
        static string connectionstring = ConfigurationManager.ConnectionStrings["Controlreparacionespj"].ConnectionString;
        OleDbConnection conn = new OleDbConnection(connectionstring);
        private void RegistroDeOrden_Load(object sender, EventArgs e)
        {
            Llenar_combobox_Tipos(sender,e);
            Llenar_combobox_Marca(sender,e);


        }

        //Llenar combobox tipos

        private void Llenar_combobox_Tipos(object sender, EventArgs e)
        {
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
        private void Llenar_combobox_Marca(object sender, EventArgs e)
        {
            DataTable marcas = new DataTable();
            using (conn)
            {
                string query = "Select id_marca, marca from marcas";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                marcas.Load(cmd.ExecuteReader());

            }
            cmbmarca.DisplayMember = "marca";
            cmbmarca.ValueMember = "id_marca";
            cmbmarca.DataSource = marcas;
            
        }
    }
}
