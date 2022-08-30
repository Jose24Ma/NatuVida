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
        public DataTable ObtenerDatosPro()
        {
            return cdCliente.Leer();
        }
        public void ActualizarProducto(CeCliente ActualizarProducto)
        {
            cdCliente.Actualizar(ActualizarProducto);
        }
        public void EliminarProducto(CeCliente EliminarProducto)
        {
            cdCliente.Eliminar(EliminarProducto);
        }


        public void CrearCliente(CeCliente CrearCliente)
        {
            cdCliente.InsertarCliente(CrearCliente);
        }
        public DataTable ObtenerDatosCli()
        {
            return cdCliente.LeerCli();
        }
        public void ActualizarCliente(CeCliente ActualizarCliente)
        {
            cdCliente.ActualizarCli(ActualizarCliente);
        }
        public void EliminarCliente(CeCliente EliminarCliente)
        {
            cdCliente.EliminarCli(EliminarCliente);
        }
    }
}