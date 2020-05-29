using Biblioteca.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Local.Data;

namespace Biblioteca.Local.Controllers
{
    public class LibroController : Controller
    {

        public ActionResult Inicializar()
        {
            BibliotecaModel.Inicializar();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new LibrosIndexViewModel();
                   
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new LibroCreateViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(LibroCreateViewModel model)
        {
            model.Create();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var model = new LibroEditViewModel(ID);

            return View(model);
        }
    }
}