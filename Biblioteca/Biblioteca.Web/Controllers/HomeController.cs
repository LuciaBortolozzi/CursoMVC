using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new Exception("Error!");
            TempData["UsuarioConectado"] = "Ema";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            string usuarioConectado = TempData["UsuarioConectado"].ToString();
            TempData.Keep();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            string usuarioConectado = TempData["UsuarioConectado"].ToString();

            return View();
        }
    }
}