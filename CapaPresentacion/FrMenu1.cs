using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrMenu1 : Form
    {
        public FrMenu1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrProductos frProductos = new FrProductos();
            frProductos.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frProductos);
            frProductos.Show();

        }


        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrFactura frFactura = new FrFactura();
            frFactura.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frFactura);
            frFactura.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrInventario frInventario = new FrInventario();
            frInventario.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frInventario);
            frInventario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrClientes frClientes = new FrClientes();
            frClientes.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frClientes);
            frClientes.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
