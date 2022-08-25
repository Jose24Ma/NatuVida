using CapaDatos;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;

namespace CapaNegocio
{
    public class CnCliente
    {

        CdCliente cdCliente = new CdCliente();
            
        public void CrearProducto(CeCliente CrearProducto)
        {
            cdCliente.InsertarProducto(CrearProducto);
        }
        
    }
}