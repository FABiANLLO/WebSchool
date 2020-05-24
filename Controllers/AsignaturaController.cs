using System;
using Microsoft.AspNetCore.Mvc;
using ProjectAsp.Models;

namespace ProjectAsp.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programacion"
            };
            ViewBag.Fecha = DateTime.Now;
            return View(asignatura);
        }

    }
}