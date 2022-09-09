using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CapaPresentacion
{
    public partial class FrProductos : Form
    {
        CnCliente cnCliente = new CnCliente();
        CeCliente ceCliente = new CeCliente();
        public FrProductos()
        {
            InitializeComponent();
        }
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;";


        //Ingresar Producto
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm()
        {
            txtCodigo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCodigoMod.Text = string.Empty;
            txtCantidadMod.Text = string.Empty;
            txtValorMod.Text = string.Empty;
            txtDescripcionMod.Text = string.Empty;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if (String.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("El codigo es obligatorio");
                }
                else
                {
                    ceCliente.proCodigo = Convert.ToInt32(txtCodigo.Text);
                }
                if (String.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripcion es obligatorio");
                }
                else
                {
                    ceCliente.ProDescripcion = txtDescripcion.Text;
                }
                if (String.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("La cantidad es obligatorio");
                }
                else
                {
                    ceCliente.proCantidad = Convert.ToInt32(txtCantidad.Text);
                }
                if (String.IsNullOrEmpty(txtValor.Text))
                {
                    MessageBox.Show("El valor es obligatorio");
                }
                else
                {
                    ceCliente.proValor = Convert.ToInt32(txtValor.Text);
                }
            }            
                cnCliente.CrearProducto(ceCliente);
                LimpiarForm();
                ActuDatosPro();      
        }
        private void cbProductos2_SelectedIndexChanged(object sender, EventArgs e) { } // Accion de Herramienta sin uso

        //Consultar Producto
        private void tpConsultarPro_Click(object sender, EventArgs e) 
        {
            cnCliente.ObtenerDatosPro();
        }
        private void FrProductos_Load(object sender, EventArgs e)
        {
            ActuDatosPro();
        }
        private void ActuDatosPro()
        {
            MySqlConnection connection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            connection.Open();
            string Query = "SELECT `proDescripcion`,`proCodigo` FROM tbl_productos";
            MySqlCommand command = new MySqlCommand(Query, connection);
            //command.Parameters.AddWithValue("@proCodigo", cbProducto4.Text);
            MySqlDataReader Adaptador = command.ExecuteReader();
            cbProducto.Items.Clear();
            cbProductos2.Items.Clear();
            cbProducto4.Items.Clear();
            while (Adaptador.Read())
            {
                cbProductos2.Items.Add(Adaptador["proDescripcion"].ToString());
                cbProducto.Items.Add(Adaptador["proDescripcion"].ToString());
                cbProducto4.Items.Add(Adaptador["proCodigo"].ToString());
            }
            connection.Close();
        }
        private void CargarDatosPro()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_productos WHERE proDescripcion LIKE ('"+cbProductos2.Text+"');";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridProductos.DataSource = dt;
            mySqlConnection.Close();          
        }
        private void GridProductos_CellDoubleClick(object sender, DataGridViewAutoSizeModeEventArgs e)
        {
            txtCodigo.Text = GridProductos.CurrentRow.Cells["proCodigo"].Value.ToString();
            txtDescripcion.Text = GridProductos.CurrentRow.Cells["proDescripcion"].Value.ToString();
            txtCantidad.Text = GridProductos.CurrentRow.Cells["proCantidad"].Value.ToString();
            txtValor.Text = GridProductos.CurrentRow.Cells["proValor"].Value.ToString();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatosPro();
            ActuDatosPro();
        }

        //Modificar Producto
        private void btnConsultarProMod_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            mySqlConnection.Open();
            string Query = "SELECT * FROM tbl_productos WHERE proDescripcion = @Des;";
            MySqlCommand command = new MySqlCommand(Query, mySqlConnection);
            command.Parameters.AddWithValue("@Des", cbProducto.Text);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                    txtCodigoMod.Text = Adaptador["proCodigo"].ToString();
                    txtDescripcionMod.Text = Adaptador["proDescripcion"].ToString();
                    txtValorMod.Text = Adaptador["proValor"].ToString();
                    txtCantidadMod.Text = Adaptador["proCantidad"].ToString();
            }
            ActuDatosPro();
        }
        private void btnGuardarPro_Click(object sender, EventArgs e)
        {
                ceCliente.proCodigo = Convert.ToInt32(txtCodigoMod.Text);
                ceCliente.ProDescripcion = txtDescripcionMod.Text;
                ceCliente.proCantidad = Convert.ToInt32(txtCantidadMod.Text);
                ceCliente.proValor = Convert.ToInt32(txtValorMod.Text);
                cnCliente.ActualizarProducto(ceCliente);
                LimpiarForm();
        }

        //Eliminar Producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ceCliente.proCodigo = Convert.ToInt32(cbProducto4.Text.ToString());
                cnCliente.EliminarProducto(ceCliente);
                cbProducto4.Text = string.Empty;
                CargarDatosPro();
                ActuDatosPro();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCodigoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtDescripcionMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtValorMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCantidadMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
