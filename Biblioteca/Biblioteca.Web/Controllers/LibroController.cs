using Biblioteca.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Web.Controllers
{
    public class LibroController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //throw new Exception("Error!");
            var model = new LibroIndexModel();
            model.Fill();
            //ViewData["libros"] = model.ListLibro;

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new LibroCreateModel();
            model.FillGeneros();

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new LibroEditModel(id);
            //model.Fill(id); //tambien se puede hacer de esta manera
            //model.FillGeneros();
            ViewData["obj"] = model;

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = new LibroDeleteModel();
            model.Fill(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(LibroCreateModel model)
        {
            if (model.Create())
            {
                return RedirectToAction("Index", "Libro");
            }

            ModelState.AddModelError("error", "Este libro ya existe");
            model.FillGeneros();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(LibroEditModel model)
        {
            if (model.Edit())
            {
                return RedirectToAction("Index", "Libro");
            }

            model.FillGeneros();
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(LibroDeleteModel model)
        {
            if (model.Delete())
            {
                return RedirectToAction("Index", "Libro");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult VerDisponibilidad(int id)
        {
            var json = new JsonResult();
            if (id == 1)
            {
                json.Data = false;
                return json;
            }
            json.Data = true;
            return json;
        }
    }
}