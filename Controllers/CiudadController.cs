using System.Collections.Generic;
using System.Linq;
using Ciudades.Data;
using Ciudades.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ciudades.Controllers
{
    public class CiudadController : Controller
    {
        private CiudadesContext _context;

        public CiudadController(CiudadesContext context){
            _context = context;
        }

        public IActionResult Registro(){
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Ciudad c){
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();

                return RedirectToAction("Lista");
            }
            return View(c);
        }

        public IActionResult Lista(){
            var ciudades = _context.Ciudades.OrderBy(x => x.NombreC).ToList();

            return View(ciudades);
        }
    }
}