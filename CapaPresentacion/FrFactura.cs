﻿using System;
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
    public partial class FrFactura : Form
    {
        CnCliente cnCliente = new CnCliente();
        CeCliente ceCliente = new CeCliente();

        //Conexion con la Base de datos
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;";
        public FrFactura()
        {
            InitializeComponent();
        }

        //Consulta de la informacion de las tablas de Cliente,Producto,Vendedor para la creacion de la factura
        private void FrFactura_Load(object sender, EventArgs e)
        {
            Clientes();
            Producto();
            Vendedor();
        }
        private void Clientes()//Metodo de llamado de datos de la tabla Clientes y mostrarlos en el ComboBox 
        {
            MySqlConnection connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            string Query = "SELECT `cliDocumento` FROM tbl_clientes";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                cbClientes.Items.Add(Adaptador["cliDocumento"].ToString());
            }
            connection.Close();
        }
        private void Producto()//Metodo de llamado de datos de la tabla Producto y mostrarlos en el ComboBox 
        {
            MySqlConnection connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            string Query = "SELECT `proDescripcion`,`proCodigo`,`proValor` FROM tbl_productos";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                cbProductos.Items.Add(Adaptador["proDescripcion"].ToString());
            }
            connection.Close();
        }
        private void Vendedor()//Metodo de llamado de datos de la tabla Producto y mostrarlos en el ComboBox 
        {
            MySqlConnection connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            string Query = "SELECT `venUsuario` FROM tbl_vendedor";
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader Adaptador = command.ExecuteReader();
            while (Adaptador.Read())
            {
                cbVendedor.Items.Add(Adaptador["venUsuario"].ToString());
            }
            connection.Close();
        }

        //Metodos de facturacion 
        private void addProducto()// Metodo para crear una fila del producto registrado en el DataGriewView
        {
            if(cbClientes.Text!=" " && cbProductos.Text!=" " && txtNumero.Text !=" " && txtCantidad.Text!=" " && txtFecha.Text!="")
            {
                DataGridViewRow row = (DataGridViewRow)GridFactura.Rows[0].Clone();
                row.Cells[0].Value = txtNumero.Text;
                row.Cells[1].Value = cbClientes.Text;
                row.Cells[2].Value = cbProductos.Text;
                row.Cells[3].Value = txtCantidad.Text;
                row.Cells[4].Value = txtFecha.Text;
                GridFactura.Rows.Add(row);
            }
        }
        private void totalFactura()// Metodo para realizar la operacion del total de la factura creada
        {
            int Valor = Convert.ToInt32(txtValor.Text);
            int Cantidad = Convert.ToInt32(txtCantidad.Text);
            double Sumatorio = Valor * Cantidad;
            textBox2.Text = Sumatorio.ToString();
        }
        private void LimpiarForm()//Metodo para limpiar formulario luego de guardar los datos
        {
            txtCantidad.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cbClientes.Text = string.Empty;
            cbProductos.Text = string.Empty;
            GridFactura.DataSource = string.Empty;
        }
        public void Guardar()//Metodo de guardar los datos ingresados en los textbos, para luego cargarlos a la BD
        {
            ceCliente.facNumero = Convert.ToInt32(txtNumero.Text);
            ceCliente.facFecha = txtFecha.Text;
            ceCliente.facCliente = Convert.ToInt32(cbClientes.Text);
            ceCliente.facValorTotal = Convert.ToInt32(textBox2.Text.ToString());
            ceCliente.facVendedor = cbVendedor.Text.ToString();
            cnCliente.CrearFactura(ceCliente);
            LimpiarForm();
        }
        
        //Crear Factura
        private void button2_Click(object sender, EventArgs e) //Boton Agregar Producto
        {
            addProducto();
            totalFactura();
        }
        private void button1_Click(object sender, EventArgs e) //Boton Terminar Factura
        {
            Guardar();     
        }
        
        private void GridFactura_CellContentClick(object sender, DataGridViewCellEventArgs e) { }// Accion sin usar

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
