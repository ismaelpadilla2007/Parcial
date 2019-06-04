using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppVet.Data;

namespace WebAppVet.Controllers
{
    public class PiezaController : Controller
    {
        private PruebaDbContext db = new PruebaDbContext();
        // GET: Pieza
        public ActionResult Index()
        {
            PiezaFacade pieza = new PiezaFacade();
            // db.Piezas.ToList()
            var piezas = pieza;
            return View(piezas);    
           // return View();
        }
    }
}