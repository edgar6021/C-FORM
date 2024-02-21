namespace SistemaVentas.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string GoogleID { get; set; }

        // Agregar otros campos de perfil según sea necesario
        public List<PerfilUsuario> PerfilesUsuarios { get; set; }
       
    }
}
