namespace CapaEntidad
{
    public class CeCliente
    {
        //Variables tbl Vendedor
        public string? venUsuario { get; set; }

        //Variables tbl Producto
        public int proCodigo { get; set; }
        public string? ProDescripcion { get; set; }
        public int proValor { get; set; }
        public int proCantidad { get; set; }

        //Variables tbl Clientes
        public string? cliNombre { get; set; }
        public int cliDocumento { get; set; }
        public string? cliDireccion { get; set; }
        public string? cliCorreo { get; set; }
        public string? cliTelefono { get; set; }

        //Variables tbl Factura
        public int facNumero { get; set; }
        public string? facFecha { get; set; }
        public int facCliente { get; set; }
        public int facValorTotal { get; set; }
        public string? facVendedor { get; set; }
    }
}