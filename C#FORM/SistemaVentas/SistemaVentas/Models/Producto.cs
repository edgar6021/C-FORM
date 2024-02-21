namespace SistemaVentas.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        // Agregar otros campos según tus necesidades (ej. categoría, proveedor)
        public List<DetalleVenta> DetallesVentas { get; set; }
    }
}
