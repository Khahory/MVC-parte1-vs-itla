using MVC_parte1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_parte1.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            //instanciar
            Persona persona = new Persona();

            //asignando valores
                                         
                                         //nombre del input
            persona.Nombre = Request.Form["idnombre"].ToString(); //traera lo que tenga el box con id nombre
            persona.Carrera = Request.Form["idcarrera"].ToString();
            persona.Cuatrimestre = Request.Form["idcuatrimestre"].ToString();
            persona.Edad = Convert.ToInt32(Request.Form["idedad"].ToString());

            //condicion de edad
            if (persona.Edad < 18)
            {
                
                return null;
            }
            else
            {
                return View(persona);
            }

            return View(persona);
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Home()
        {
            return View();
        }


    }
}