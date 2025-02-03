using CapaEnttidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace PracticalQuiz.Controllers
{
    public class RegistrosController : Controller
    {
        // GET: Registros
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListarRegistros()
        {
            List<SEVECLIE> olista = new List<SEVECLIE> ();
            olista = new CN_SVECLIE().list();
            return Json(olista, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult ListarEstadoCivil()
        {
            List<EstadoCivil> olista = new List<EstadoCivil>();
            olista = new CN_EstadoCivil().list();
            return Json(olista, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Add(SEVECLIE nuevoCliente)
        {
            var result = new CN_SVECLIE().Add(nuevoCliente);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}