using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using OperasWebSite.Models;

namespace OperasWebSite.Controllers
{
    public class OperaController : Controller
    {

        private OperaDB _operaDb = new OperaDB(); 

        // GET: Opera
        public ActionResult Index()
        {
            return View( "Index", _operaDb.Operas.ToList() );
        }

        public ActionResult Details(int id)
        {
            Opera opera = _operaDb.Operas.Find(id);
            if(opera == null )
            {
                return HttpNotFound();
            }

            return View("Details", opera);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Opera newOpera = new Opera();

            return View("Create", newOpera);
        }

        [HttpPost]
        public ActionResult Create(Opera newOpera)
        {
            if (ModelState.IsValid)
            {
                _operaDb.Operas.Add(newOpera);
                _operaDb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", newOpera);
        }
    }
}