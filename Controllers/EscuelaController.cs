using System;
using Microsoft.AspNetCore.Mvc;
using ProjectAsp.Models;

namespace ProjectAsp.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "ITI";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Calle 14 # 14 - 04";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}