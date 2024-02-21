using SistemaVentaProyectoFinal.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Articulos
{
    public int IdArticulo { get; set; }

    [Required]
    [StringLength(50)]
    public string Codigo { get; set; }

    [Required]
    [StringLength(50)]
    public string Nombre { get; set; }

    [StringLength(1024)]
    public string Descripcion { get; set; }

    public byte[] Imagen { get; set; }

    public int IdCategoria { get; set; }
    public int IdPresentacion { get; set; }

    public Categoria Categoria { get; set; }
    public Presentacion Presentacion { get; set; }
}
