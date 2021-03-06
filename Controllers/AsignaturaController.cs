using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectAsp.Models;

namespace ProjectAsp.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", Id=Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física",Id=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano",Id=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales",Id=Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Programacion",Id=Guid.NewGuid().ToString()}
                };
            ViewBag.Fecha = DateTime.Now;
            return View(listaAsignaturas);
        }
        public IActionResult Index()
        {
            return View(new Asignatura { Nombre = "Programacion", Id = Guid.NewGuid().ToString() });
        }

    }
}