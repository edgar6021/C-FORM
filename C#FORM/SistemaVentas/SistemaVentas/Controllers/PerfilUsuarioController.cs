using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Controllers
{
  
    public class PerfilUsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PerfilUsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PerfilUsuario
        public async Task<IActionResult> Index()
        {
            var perfilesUsuarios = await _context.PerfilUsuarios
                .Include(p => p.Usuario)
                .ToListAsync();
            return View(perfilesUsuarios);
        }

        // GET: PerfilUsuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.PerfilUsuarioID == id);

            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return View(perfilUsuario);
        }

        // Otras acciones (Create, Edit, Delete, etc.) aquí...

        private bool PerfilUsuarioExists(int id)
        {
            return _context.PerfilUsuarios.Any(e => e.PerfilUsuarioID == id);
        }
    }

}
