using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm()
        {
            CeCliente ceCliente = new CeCliente();
            txtCodigo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }
        public bool ValidarDatos()
        {
            bool resultado = true;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Codigo es un campo obligatorio");
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Descripcion es un campo obligatorio");
            }
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Cantidad es un campo obligatorio");
            }
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Valor es un campo obligatorio");
            }
            return resultado;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ceCliente.proCodigo = Convert.ToInt32(txtCodigo.Text);
            ceCliente.proDescripcion = txtDescripcion.Text;
            ceCliente.proCantidad = Convert.ToInt32(txtCantidad.Text);
            ceCliente.proValor = Convert.ToInt32((txtValor.Text));
            bool resultado;
            resultado = ValidarDatos();
            if (resultado == false)
            {
                return;
            }
            cnCliente.CrearProducto(ceCliente);
            LimpiarForm();
        }
        private void cbProductos2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tpConsultarPro_Click(object sender, EventArgs e) { }

        private void FrProductos_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            connection.Open();
            string Query = "SELECT `proDescripcion` FROM tbl_productos ";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                cbProductos2.Items.Add(Adaptador["proDescripcion"].ToString());
            }
            connection.Close();
        }
    }
}
