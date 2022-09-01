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

        // Acciones del MenuStrip de llamado de Forms
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)//Accion para llamar dentro del form de menu el form de productos
        {
            FrProductos frProductos = new FrProductos();
            frProductos.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frProductos);
            frProductos.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)//Accion para llamar dentro del form de menu el form de facturacion
        {
            FrFactura frFactura = new FrFactura();
            frFactura.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frFactura);
            frFactura.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)//Accion para llamar dentro del form de menu el form de inventario (sin terminar)
        {
            FrInventario frInventario = new FrInventario();
            frInventario.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frInventario);
            frInventario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) //Accion para llamar dentro del form de menu el form de clientes
        {
            FrClientes frClientes = new FrClientes();
            frClientes.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(frClientes);
            frClientes.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e) // Accion para terminar el programa
        {
            Application.Exit();
        }
    }
}
