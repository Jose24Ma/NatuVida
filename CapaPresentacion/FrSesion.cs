using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrSesion : Form
    {
        public FrSesion()
        {
            InitializeComponent(); 
        }

        // Conexion Base de Datos
        MySqlConnection connection = new MySqlConnection("Server=Localhost;User=root;Password=admin;Port=3306;Database=naturvida;");
        
        //Inicio Sesion (Login)
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand("SELECT venUsuario,venConstrasena FROM tbl_vendedor WHERE venUsuario = @vusuario AND venConstrasena = @vconstrasena", connection);
                comando.Parameters.AddWithValue("@vusuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@vconstrasena", txtContraseña.Text);
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    FrMenu1 frMenu1 = new FrMenu1();
                    frMenu1.Show();
                }
                else if (txtUsuario.Text == string.Empty || txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("El usuario y/o contraseña son obligatorios");
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
