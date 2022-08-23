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
    public partial class FrSesion : Form
    {
        public FrSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Demo" && txtContraseña.Text =="1234")
            {

                FrMenu1 frMenu1 = new FrMenu1();
                frMenu1.Show();
            }
            else
            {
                MessageBox.Show("El usuario y la contreña que ingreso es incorrecto");
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
            
        }
    }
}
