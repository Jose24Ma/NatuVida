using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class Validar
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if(Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if(Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if(char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se permiten valores de tipo caracter");
            }
        }
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se permiten valores de tipo entero");
            }
        }
    }
}
