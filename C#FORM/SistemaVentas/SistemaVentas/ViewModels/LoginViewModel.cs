using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Nombre de Usuario o Correo Electrónico")]
        public string NombreUsuarioOEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }

        [Display(Name = "Recordar mi cuenta")]
        public bool Recordarme { get; set; }
    }
}
