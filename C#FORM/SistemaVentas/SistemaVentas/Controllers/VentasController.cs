using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Controllers
{
    public class VentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var ventas = await _context.Ventas.Include(v => v.Cliente).ToListAsync();
            return View(ventas);
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.DetallesVentas)
                    .ThenInclude(d => d.Producto)
                .FirstOrDefaultAsync(m => m.VentaID == id);

            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();

            return View();
        }

        // POST: Ventas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Venta venta, List<int> productos)
        {
            if (ModelState.IsValid)
            {
                venta.FechaVenta = DateTime.Now;

                venta.DetallesVentas = productos
                    .Select(productId => new DetalleVenta
                    {
                        ProductoID = productId,
                        PrecioUnitario = _context.Productos.Find(productId)?.Precio ?? 0
                    })
                    .ToList();

                venta.TotalVenta = venta.DetallesVentas.Sum(detalle => detalle.PrecioUnitario);

                // No asignes VentaID aquí, ya que será generada por la base de datos
                _context.Add(venta);
                await _context.SaveChangesAsync();

                // Ahora, después de guardar en la base de datos, VentaID estará disponible
                var historialVenta = new HistorialVentas
                {
                    VentaID = venta.VentaID, // Aquí ahora puedes acceder a VentaID
                    FechaRegistro = DateTime.Now,
                };
                _context.Add(historialVenta);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();

            return View(venta);
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.DetallesVentas)
                .FirstOrDefaultAsync(v => v.VentaID == id);

            if (venta == null)
            {
                return NotFound();
            }

            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();

            return View(venta);
        }

        // POST: Ventas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Venta venta, List<int> productos)
        {
            if (id != venta.VentaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    venta.FechaVenta = DateTime.Now;

                    var detallesAntiguos = await _context.DetallesVentas
                        .Where(d => d.VentaID == id)
                        .ToListAsync();

                    _context.DetallesVentas.RemoveRange(detallesAntiguos);

                    venta.DetallesVentas = productos
                        .Select(productId => new DetalleVenta
                        {
                            ProductoID = productId,
                            PrecioUnitario = _context.Productos.Find(productId)?.Precio ?? 0
                        })
                        .ToList();

                    venta.TotalVenta = venta.DetallesVentas.Sum(detalle => detalle.PrecioUnitario);

                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaExists(venta.VentaID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();

            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.Cliente)
                .FirstOrDefaultAsync(m => m.VentaID == id);

            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(e => e.VentaID == id);
        }
    }
}
