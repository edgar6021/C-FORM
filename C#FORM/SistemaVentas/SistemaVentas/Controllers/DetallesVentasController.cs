using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Controllers
{
    
    public class DetallesVentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DetallesVentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DetallesVentas
        public async Task<IActionResult> Index()
        {
            var detallesVentas = await _context.DetallesVentas
                .Include(d => d.Venta)
                .Include(d => d.Producto)
                .ToListAsync();
            return View(detallesVentas);
        }

        // GET: DetallesVentas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetallesVentas
                .Include(d => d.Venta)
                .Include(d => d.Producto)
                .FirstOrDefaultAsync(m => m.DetalleVentaID == id);

            if (detalleVenta == null)
            {
                return NotFound();
            }

            return View(detalleVenta);
        }

        // GET: DetallesVentas/Create
        public IActionResult Create()
        {
            // Lógica para cargar Venta y Producto en el formulario de creación
            return View();
        }

        // POST: DetallesVentas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetalleVentaID,VentaID,ProductoID,Cantidad,PrecioUnitario,Subtotal")] DetalleVenta detalleVenta)
        {
            if (ModelState.IsValid)
            {
                // Lógica para calcular Subtotal y guardar el detalleVenta en la base de datos
                _context.Add(detalleVenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Lógica para recargar Venta y Producto en caso de error
            return View(detalleVenta);
        }

        // Otras acciones (Edit, Delete, etc.) aquí...

        private bool DetalleVentaExists(int id)
        {
            return _context.DetallesVentas.Any(e => e.DetalleVentaID == id);
        }
    }

}
