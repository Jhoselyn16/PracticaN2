
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PC2.Data;
using PC2.Models;

namespace PC2.Controllers
{
    public class PirañaController : Controller
    {
        private PirañaContext _context;
        public PirañaController(PirañaContext context)
        {
            _context = context;
        }

        public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Piraña p) {
            if (ModelState.IsValid) {
                // Guardar el objeto Pokemon (p)
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

        public IActionResult Lista() {
            var pirañas = _context.pirañas.OrderBy(x => x.Nombre).ToList();
            return View(pirañas);
        }
    }
}