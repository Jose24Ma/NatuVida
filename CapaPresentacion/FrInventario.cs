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

        private void FrInventario_Load(object sender, EventArgs e) { }
       

        private void CargarDatosPro()
        {
            GridInventario.DataSource = cnCliente.ObtenerDatosPro();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatosPro();
        }
    }
}
