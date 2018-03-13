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
    public partial class FRMRegistroDeOrden : Form
    {
        public FRMRegistroDeOrden()
        {
            InitializeComponent();
        }
        public static string connectionstring = ConfigurationManager.ConnectionStrings["Controlreparacionespj"].ConnectionString;

        private void RegistroDeOrden_Load(object sender, EventArgs e)
        {
            txtabono.Text = 0.ToString();
            txtabono_Leave(sender, e);
            Llenar_combobox_Tipos(sender, e);
            Llenar_combobox_Marcas(sender, e);
            Llenar_combobox_Estados(sender, e);
            LLenar_combobox_Estados_factura(sender, e);
            llenar_texbox_numeroorden(sender, e);
            llenar_texbox_numerofac( sender, e);
            llenar_texbox_cod_cliente(sender, e);


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
            cmbxtipo.SelectedValue = "id_tipo";
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
            cmbmarca.SelectedValue = "id_marca";
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
            cmbestado.SelectedValue = "id_estado";
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
            cmbestadofac.SelectedValue = "id_estadofact";
            cmbestadofac.DataSource = estadosfac;
        }
        
        //llenar textbox numero de orden
        private void llenar_texbox_numeroorden(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionstring);
            using (conn)
            {
                conn.Open();
                string query = "Select MAX (id_ordenrep) as id_ordenrep from registro_ordenrep";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["id_ordenrep"].ToString() == string.Empty)
                    {
                        txtorden.Text = 1.ToString();
                    }
                    else
                    {
                        txtorden.Text = (Convert.ToInt32(dr["id_ordenrep"].ToString()) + 1).ToString();
                    }
                }
                dr.Close();
                conn.Close();

            }
        }
        
        //llenar textbox numero de factura
        private void llenar_texbox_numerofac(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionstring);
            using (conn)
            {
                conn.Open();
                string query = "Select MAX (id_factura) as id_factura  from facturas";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["id_factura"].ToString() == string.Empty)
                    {
                        txtfnofactura.Text = 1.ToString();
                    }
                    else
                    {
                        txtfnofactura.Text = (Convert.ToInt32(dr["id_ordenrep"].ToString()) + 1).ToString();
                    }
                }
                dr.Close();
                conn.Close();

            }
        }

        //llenar texbox cod_cliente
        private void llenar_texbox_cod_cliente(object sender,EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionstring);
            using (conn)
            {
                conn.Open();
                string query = "Select MAX (id_cliente) as id_cliente from cliente";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["id_cliente"].ToString() == string.Empty)
                    {
                        txtcod_cliente.Text = 1.ToString();
                    }
                    else
                    {
                        txtcod_cliente.Text = (Convert.ToInt32(dr["id_cliente"].ToString()) + 1).ToString();
                    }
                }
                dr.Close();
                conn.Close();

            }
        }

        //filtrar letras y signos
        private void txtfnofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Colocación del cursor
        private void txttelefono_Enter_1(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txttelefono.Select(0, 0);
            });
        }

        //Pasar datos a datagridview
        private void btnañadir_Click(object sender, EventArgs e)
        {

            string id_orden = txtorden.Text;
            string id_tipo = cmbxtipo.SelectedValue.ToString();
            string tipo = cmbxtipo.Text;
            string id_marca = cmbmarca.SelectedValue.ToString();
            string marca = cmbmarca.Text;
            string id_estado = cmbestado.SelectedValue.ToString();
            string estado = cmbestado.Text;
            string detalles = txtdetalles.Text;
            string abono = txtabono.Text;
            string fecha = dateTimePicker1.Text;
            txtabono.Text = 0.ToString();
            txtabono_Leave(sender, e);
            string[] fila = { id_orden, id_tipo, tipo, id_marca, marca, id_estado, estado, detalles, abono, fecha };
            dgvordenes.Rows.Add(fila);
            txtorden.Text = (Convert.ToInt32(txtorden.Text) + 1).ToString();
            cmbestado.SelectedIndex = 0;
            cmbestadofac.SelectedIndex = 0;
            cmbmarca.SelectedIndex = 0;
            cmbxtipo.SelectedIndex = 0;
            txtdetalles.Clear();

        }

        //Colocar formato de moneda
        private void txtabono_Leave(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(txtabono.Text, out valor))
            {
                txtabono.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", valor);

            }

            else
            {
                txtabono.Text = string.Empty;
            }

        }

        //Quitar fila
        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Desea borrar el registro?", "Atención", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvordenes.SelectedRows)
                {
                    dgvordenes.Rows.RemoveAt(row.Index);
                    dgvordenes.Refresh();
                    txtorden.Text = (Convert.ToInt32(txtorden.Text) - 1).ToString();

                }
            }

        }

        //Guardar datos
        private void btninsertar_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionstring))
            {


                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(30);
                conn.Open();
                string guardar_orden = "insert into registro_ordenrep(id_ordenrep,id_tipo,id_marca,detalles,id_estado,id_factura,fecha_expiracion) values(" +
                  "@id_ordenrep,@id_tipo,@idmarca,@detalles,@id_estado,@id_factura,@fecha_expiracion)";
                string guardar_cliente = "insert into cliente(id_cliente,nombre,telefono,celular,fecha_registro)" +
                    "values(@id_cliente,@nombre,@telefono,@celular,@fecha_registro)";
                string guardar_factura = "insert into facturas(id_factura,fecha_creacion,id_cliente,id_usuario,id_estadofact)" +
                    "values(@id_factura,@fecha_creacion,@id_cliente,@id_usuario,@id_estadofact)";
                OleDbCommand odm = new OleDbCommand();
                odm.CommandText = guardar_orden;
                odm.CommandType = CommandType.Text;
                odm.Connection = conn;


                foreach (DataGridViewRow row in dgvordenes.Rows)
                {

                    odm.Parameters.Clear();
                    odm.Parameters.AddWithValue("@id_ordenrep", row.Cells["idordenrep"].Value);
                    odm.Parameters.AddWithValue("@id_tipo", row.Cells["idtipo"].Value);
                    odm.Parameters.AddWithValue("@id_marca", row.Cells["idmarca"].Value);
                    odm.Parameters.AddWithValue("@detalles", row.Cells["Detalles"].Value);
                    odm.Parameters.AddWithValue("@id_etado", row.Cells["idestado"].Value);
                    odm.Parameters.AddWithValue("@id_factura", Convert.ToInt16(txtfnofactura.Text));
                    odm.Parameters.AddWithValue("@fecha_expiracion", Convert.ToDateTime(dateTimePicker1.Text));

                    odm.ExecuteNonQuery();
                }
                
                {
                    dateTimePicker1.Value = DateTime.Now;
                    odm.CommandText = guardar_cliente;
                    odm.CommandType = CommandType.Text;
                    odm.Connection = conn;
                    odm.Parameters.Clear();
                    odm.Parameters.AddWithValue("@id_cliente", Convert.ToInt16(txtcod_cliente.Text));
                    odm.Parameters.AddWithValue("@nombre", txtcliente.Text);
                    odm.Parameters.AddWithValue("@telefono", txttelefono.Text);
                    odm.Parameters.AddWithValue("@celular", txtcelular.Text);
                    odm.Parameters.AddWithValue("@fecha_registro", Convert.ToDateTime(dateTimePicker1.Text));
                    odm.ExecuteNonQuery();
                    
                }

                {
                    odm.CommandText = guardar_factura;
                    odm.CommandType = CommandType.Text;
                    odm.Connection = conn;
                    odm.Parameters.Clear();
                    odm.Parameters.AddWithValue("@id_factura", Convert.ToInt16(txtfnofactura.Text));
                    odm.Parameters.AddWithValue("@fecha_creacion", Convert.ToDateTime(dateTimePicker1.Text));
                    odm.Parameters.AddWithValue("@id_cliente", Convert.ToInt16(txtcod_cliente.Text));
                    odm.Parameters.AddWithValue("@id_usuario", Convert.ToInt16(txtcod_cliente.Text));
                    odm.Parameters.AddWithValue("@id_estadofact",cmbestadofac.SelectedValue);
                    odm.ExecuteNonQuery();
                }

                dgvordenes.Rows.Clear();
                txtfnofactura.Text = (Convert.ToInt32(txtfnofactura.Text) + 1).ToString();
                txtcod_cliente.Text = (Convert.ToInt32(txtcod_cliente.Text) + 1).ToString();
                txtcliente.Clear();
                txtcelular.Clear();
                cmbestadofac.SelectedIndex = 0;


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcliente_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txttelefono.Select(0, 0);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

              