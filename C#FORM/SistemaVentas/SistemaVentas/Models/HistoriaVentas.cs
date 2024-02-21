using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Models
{
    public class HistorialVentas
    {
        [Key]
        public int HistorialVentaID { get; set; }

        [Required]
        public int VentaID { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        // Agregar otros campos según tus necesidades (ej. notas, estado de entrega)

        // Propiedad de navegación para representar la relación con la venta
        public Venta Venta { get; set; }
    }
}
