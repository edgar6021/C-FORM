namespace SistemaVentas.Models
{
    public class PerfilUsuario
    {
        public int PerfilUsuarioID { get; set; }
        public int UsuarioID { get; set; }

        // Agregar otros campos relacionados con el perfil del usuario (ej. foto de perfil, información personal)
        public Usuario Usuario { get; set; }
    }
}
