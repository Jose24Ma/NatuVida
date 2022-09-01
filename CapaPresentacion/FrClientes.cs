using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class FrClientes : Form
    {
        CnCliente cnCliente = new CnCliente();
        CeCliente ceCliente = new CeCliente();
        public FrClientes()
        {
            InitializeComponent();
        }

        //Ingresar Cliente
        private void LimpiarFormCli()
        {
            txtDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            txtDocumentoCli.Text = string.Empty;
            txtNombreCli.Text = string.Empty;
            txtDireccionCli.Text = string.Empty;
            txtCorreoCli.Text = string.Empty;
            txtTelefonoCli.Text = string.Empty;
        }
        private void btnLimpiarCli_Click(object sender, EventArgs e)
        {
            LimpiarFormCli();
        }
        private void btnGuardarCli_Click(object sender, EventArgs e)
        {
            ceCliente.cliDocumento = Convert.ToInt32(txtDocumento.Text);
            ceCliente.cliNombre = txtNombre.Text;
            ceCliente.cliDireccion = txtDireccion.Text;
            ceCliente.cliTelefono = txtTelefono.Text;
            ceCliente.cliCorreo = txtCorreo.Text;
            cnCliente.CrearCliente(ceCliente);
            LimpiarFormCli();
        }

        //Consular Cliente
        private void tpConsultarCli_Click(object sender, EventArgs e)
        {
            cnCliente.ObtenerDatosCli();
        }
        private void CargarDatosCli()
        {
            GridDatosCli.DataSource = cnCliente.ObtenerDatosCli();
        }
        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            CargarDatosCli();
        }

        //Modificar Cliente
        private void FrClientes_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            connection.Open();
            string Query = "SELECT `cliNombre`,`cliDocumento` FROM tbl_clientes";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                cbCliente.Items.Add(Adaptador["cliNombre"].ToString());
                cbClienteModificar.Items.Add(Adaptador["cliNombre"].ToString());
                cbClienteEliminar.Items.Add(Adaptador["cliDocumento"].ToString());
            }
            connection.Close();
        }
        private void btnConsularCli_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            mySqlConnection.Open();
            string Query = "SELECT * FROM tbl_clientes WHERE cliNombre = @Des;";
            MySqlCommand command = new MySqlCommand(Query, mySqlConnection);
            command.Parameters.AddWithValue("@Des", cbClienteModificar.Text);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                txtDocumentoCli.Text = Adaptador["cliDocumento"].ToString();
                txtNombreCli.Text = Adaptador["cliNombre"].ToString();
                txtDireccionCli.Text = Adaptador["cliDireccion"].ToString();
                txtCorreoCli.Text = Adaptador["cliCorreo"].ToString();
                txtTelefonoCli.Text = Adaptador["cliTelefono"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ceCliente.cliDocumento = Convert.ToInt32(txtDocumentoCli.Text);
            ceCliente.cliNombre = txtNombreCli.Text;
            ceCliente.cliDireccion = txtDireccionCli.Text;
            ceCliente.cliTelefono = txtTelefonoCli.Text;
            ceCliente.cliCorreo = txtCorreoCli.Text;
            cnCliente.ActualizarCliente(ceCliente);
            LimpiarFormCli();
        }

        //Eliminar Cliente
        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ceCliente.cliDocumento = Convert.ToInt32(cbClienteEliminar.Text.ToString());
                cnCliente.EliminarCliente(ceCliente);
                cbClienteEliminar.Text = string.Empty;
                CargarDatosCli();
            }
        }
    }   
}
