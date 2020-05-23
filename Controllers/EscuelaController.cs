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
            escuela.AnioFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "ITI";

            return View(escuela);
        }
    }
}