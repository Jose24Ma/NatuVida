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
            ceCliente.proCodigo = Convert.ToInt32(txtCodigo.Text);
            ceCliente.ProDescripcion = txtDescripcion.Text;
            ceCliente.proCantidad = Convert.ToInt32(txtCantidad.Text);
            ceCliente.proValor = Convert.ToInt32(txtValor.Text);
            cnCliente.CrearProducto(ceCliente);
            LimpiarForm();
        }
        private void cbProductos2_SelectedIndexChanged(object sender, EventArgs e) { } // Accion de Herramienta sin uso

        //Consultar Producto
        private void tpConsultarPro_Click(object sender, EventArgs e) 
        {
            cnCliente.ObtenerDatosPro();
        }
        private void FrProductos_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            connection.Open();
            string Query = "SELECT `proDescripcion`,`proCodigo` FROM tbl_productos";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
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
            GridProductos.DataSource = cnCliente.ObtenerDatosPro();
            
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
                    CargarDatosPro();    
            }
        }
    }
}
