namespace SistemaVentas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Agregar otros campos según sea necesario

        // Propiedad de navegación para representar la relación con las ventas
        public List<Venta> Venta { get; set; }
    }
}
