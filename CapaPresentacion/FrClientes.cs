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
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;";


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
            if (true)
            {
                if (String.IsNullOrEmpty(txtDocumento.Text))
                {
                    MessageBox.Show("El documento es obligatorio");
                }
                else
                {
                    ceCliente.cliDocumento = Convert.ToInt32(txtDocumento.Text);
                }
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio");
                }
                else
                {
                    ceCliente.cliNombre = txtNombre.Text;
                }
                if (String.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("La dirección es obligatorio");
                }
                else
                {
                    ceCliente.cliDireccion = txtDireccion.Text;
                }
                if (String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("El telefono es obligatorio");
                }
                else
                {
                    ceCliente.cliTelefono = txtTelefono.Text;
                }
                if (String.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("El correo es obligatorio");
                }
                else
                {
                    ceCliente.cliCorreo = txtCorreo.Text;
                }
            }
            cnCliente.CrearCliente(ceCliente);
            LimpiarFormCli();
            ActuDatosCli();
        }
        //Consultar Cliente
        private void tpConsultarCli_Click(object sender, EventArgs e)
        {
            cnCliente.ObtenerDatosCli();
        }
        private void CargarDatosCli()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_clientes WHERE cliNombre LIKE ('" + cbCliente.Text + "');";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridDatosCli.DataSource = dt;
            mySqlConnection.Close();
        }
        private void GridDatosCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDocumento.Text = GridDatosCli.CurrentRow.Cells["cliDocumento"].Value.ToString();
            txtNombre.Text = GridDatosCli.CurrentRow.Cells["cliNombre"].Value.ToString();
            txtDireccion.Text = GridDatosCli.CurrentRow.Cells["cliDireccion"].Value.ToString();
            txtTelefono.Text = GridDatosCli.CurrentRow.Cells["cliTelefono"].Value.ToString();
            txtCorreo.Text = GridDatosCli.CurrentRow.Cells["cliCorreo"].Value.ToString();
        }
        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            CargarDatosCli();
            ActuDatosCli();
        }
        private void ActuDatosCli()
        {
            MySqlConnection connection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
            connection.Open();
            string Query = "SELECT `cliNombre`,`cliDocumento` FROM tbl_clientes";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
            cbCliente.Items.Clear();
            cbClienteModificar.Items.Clear();
            cbClienteEliminar.Items.Clear();
            while (Adaptador.Read())
            {
                cbCliente.Items.Add(Adaptador["cliNombre"].ToString());
                cbClienteModificar.Items.Add(Adaptador["cliNombre"].ToString());
                cbClienteEliminar.Items.Add(Adaptador["cliDocumento"].ToString());
            }
            connection.Close();
        }


        //Modificar Cliente
        private void FrClientes_Load(object sender, EventArgs e)
        {
            ActuDatosCli();
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
            ActuDatosCli();
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
            ActuDatosCli();
        }

        //Eliminar Cliente
        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ceCliente.cliDocumento = Convert.ToInt32(cbClienteEliminar.Text);
                cnCliente.EliminarCliente(ceCliente);
                cbClienteEliminar.Text = string.Empty;
                CargarDatosCli();
                ActuDatosCli();
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtDocumentoCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNombreCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtTelefonoCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }   
}
