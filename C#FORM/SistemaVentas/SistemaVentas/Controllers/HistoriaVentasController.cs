using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Controllers
{
    

    public class HistorialVentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistorialVentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HistorialVentas
        public async Task<IActionResult> Index()
        {
            var historialVentas = await _context.HistorialVentas
                .Include(h => h.Venta)
                .ToListAsync();
            return View(historialVentas);
        }

        // GET: HistorialVentas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialVenta = await _context.HistorialVentas
                .Include(h => h.Venta)
                .FirstOrDefaultAsync(m => m.HistorialVentaID == id);

            if (historialVenta == null)
            {
                return NotFound();
            }

            return View(historialVenta);
        }

        // Otras acciones (Create, Edit, Delete, etc.) aquí...

        private bool HistorialVentaExists(int id)
        {
            return _context.HistorialVentas.Any(e => e.HistorialVentaID == id);
        }
    }

}
