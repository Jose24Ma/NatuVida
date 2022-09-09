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
    public partial class FrInventario : Form
    {
        CnCliente cnCliente = new CnCliente();
        CeCliente ceCliente = new CeCliente();

        public FrInventario()
        {
            InitializeComponent();
        }
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;";

        private void FrInventario_Load(object sender, EventArgs e) 
        {
            ActuDatosPro();
        }
        private void ActuDatosPro()
        {
            MySqlConnection connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            string Query = "SELECT `proDescripcion`,`proCodigo` FROM tbl_productos";
            MySqlCommand command = new MySqlCommand(Query, connection);
            //command.Parameters.AddWithValue("@proCodigo", cbProducto4.Text);
            MySqlDataReader Adaptador = command.ExecuteReader();
            cbInventario.Items.Clear();
            while (Adaptador.Read())
            {
                cbInventario.Items.Add(Adaptador["proDescripcion"].ToString());
            }
            connection.Close();
        }
        private void CargarDatosPro()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT `proDescripcion` AS Descripcion,`proValor` AS Valor, `proCantidad`AS Disponible FROM tbl_productos WHERE proDescripcion LIKE ('" + cbInventario.Text + "');";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridInventario.DataSource = dt;
            mySqlConnection.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatosPro();
            ActuDatosPro();
        }
    }
}
