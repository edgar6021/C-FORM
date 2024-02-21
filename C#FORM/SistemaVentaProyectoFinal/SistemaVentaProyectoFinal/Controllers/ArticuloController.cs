using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaProyectoFinal.Controllers
{
    public class ArticuloController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Articulo
        public ActionResult Index()
        {
            var articulos = db.Articulos.Include(a => a.Categoria).Include(a => a.Presentacion);
            return View(articulos.ToList());
        }
    }
