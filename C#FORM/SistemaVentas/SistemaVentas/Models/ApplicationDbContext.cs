// ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<DetalleVenta> DetallesVentas { get; set; }
    public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
    public DbSet<HistorialVentas> HistorialVentas { get; set; }

    // Otros DbSet según sea necesario

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<HistorialVentas>()
       .HasOne(hv => hv.Venta)
       .WithMany(v => v.HistorialVentas)
       .HasForeignKey(hv => hv.VentaID)
       .IsRequired();


        // Otras configuraciones...
    }

}
