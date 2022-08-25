using System;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;
namespace CapaDatos
{
    public class CdCliente
    {
        string CadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;";

        public void InsertarProducto(CeCliente ceInsertarProducto)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `tbl_productos` (`proCodigo`, `proDescripcion`, `proValor`, `proCantidad`) VALUES ('"+ceInsertarProducto.proCodigo+"','"+ceInsertarProducto.proDescripcion+"','"+ceInsertarProducto.proValor+"','"+ceInsertarProducto.proCantidad+"');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro exitoso");
        }
    }
}