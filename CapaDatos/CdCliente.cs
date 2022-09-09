using System;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;
namespace CapaDatos
{
    public class CdCliente
    {
        // Conexion con la Base de Datos NaturVida
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;";

        //Metodos CRUD de productos
        public void InsertarProducto(CeCliente ceInsertarProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `tbl_productos` (`proCodigo`, `proDescripcion`, `proValor`, `proCantidad`) VALUES ('"+ceInsertarProducto.proCodigo+"','"+ceInsertarProducto.ProDescripcion+"','"+ceInsertarProducto.proValor+"','"+ceInsertarProducto.proCantidad+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro exitoso");
        }
        public DataTable Leer()
        {
            DataTable data = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "SELECT * FROM tbl_productos ;";
            MySqlDataAdapter Adaptador;
            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(data);
            return data;
        }
        public void Actualizar(CeCliente ceInsertarProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE `tbl_productos` SET `proDescripcion` = '" + ceInsertarProducto.ProDescripcion + "', `proValor` = '" + ceInsertarProducto.proValor + "', `proCantidad` = '" + ceInsertarProducto.proCantidad + "' WHERE (`proCodigo` = '"+ceInsertarProducto.proCodigo+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Actualizado");
        }
        public void Eliminar(CeCliente ceInsertarProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "DELETE FROM `tbl_productos` WHERE (`proCodigo` = '"+ceInsertarProducto.proCodigo+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        }

        //Metodos CRUD de clientes
        public void InsertarCliente(CeCliente ceInsertarCliente)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `tbl_clientes` (`cliNombre`, `cliDocumento`, `cliDireccion`, `cliCorreo`, `cliTelefono`) VALUES('"+ceInsertarCliente.cliNombre+"','"+ceInsertarCliente.cliDocumento+"','"+ceInsertarCliente.cliDireccion+"','"+ceInsertarCliente.cliCorreo+"','"+ceInsertarCliente.cliTelefono+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro exitoso");
        }
        public DataTable LeerCli()
        {
            DataTable data = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "SELECT `cliNombre`, `cliDocumento`, `cliDireccion`, `cliCorreo`, `cliTelefono` FROM tbl_clientes LIMIT 1000;";
            MySqlDataAdapter Adaptador;
            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(data);
            return data;
        }
        public void ActualizarCli(CeCliente ceInsertarCliente)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE `tbl_clientes` SET `cliNombre` = '" + ceInsertarCliente.cliNombre + "', `cliDireccion` = '" + ceInsertarCliente.cliDireccion + "', `cliCorreo` = '" + ceInsertarCliente.cliCorreo + "' ,`cliTelefono` = '" + ceInsertarCliente.cliTelefono + "' WHERE (`cliDocumento` = '" + ceInsertarCliente.cliDocumento + "');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Actualizado");
        }
        public void EliminarCli (CeCliente ceInsertarCliente)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "DELETE FROM `tbl_clientes` WHERE (`cliDocumento` = '" + ceInsertarCliente.cliDocumento + " ');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        }

        //Metodod de creacion de factura
        public void CrearFactura(CeCliente ceCrearFactura)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `tbl_facturas` (`facNumero`, `facFecha`, `facCliente`, `facValorTotal`, `facVendedor`) VALUES ('"+ceCrearFactura.facNumero+"','"+ceCrearFactura.facFecha+"','"+ceCrearFactura.facCliente+"','"+ceCrearFactura.facValorTotal+"','"+ceCrearFactura.facVendedor+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro exitoso");
        }

        //Metodo Inventario
        //public DataTable LeerInventario()
        //{
        //    DataTable data = new DataTable();
        //    MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
        //    mySqlConnection.Open();
        //    string Query = "SELECT `proDescripcion` AS Descripcion,`proValor` AS Valor, `proCantidad`AS Disponible FROM tbl_productos ;";
        //    MySqlDataAdapter Adaptador;
        //    Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
        //    Adaptador.Fill(data);
        //    return data;
        //}
    }
}