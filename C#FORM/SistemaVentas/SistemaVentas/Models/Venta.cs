using System;
using System.Collections.Generic;

namespace SistemaVentas.Models
{
    public class Venta
    {
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }

        // Agregar otros campos relacionados con la venta (ej. método de pago, dirección de envío)

        // Propiedad de navegación para representar la relación con el cliente
        public Cliente Cliente { get; set; }

        // Colección de DetalleVenta para representar la relación uno a muchos
        public List<DetalleVenta> DetallesVentas { get; set; }
        public List<Producto>Productos { get; set; }

        // Colección de HistorialVentas para representar la relación uno a muchos
        public ICollection<HistorialVentas> HistorialVentas { get; set; }
    }
}
