using pratica2.DAO;
using pratica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pratica2.Controllers
{
    public class JogarController : Controller
    {
        // GET: Jogar
        public ActionResult Index()
        {
            ViewBag.Title = "Jogar";
            return View();
        }

        [Route("Jogar/{pontos}")]
        public ActionResult Pontuar(int pontos)
        {              
            usuario usu = new usuario();

            usu = (usuario)Session["usuarioLogado"];

            usu.Pontos += pontos;

            ((usuario)Session["usuarioLogado"]).Pontos = usu.Pontos;

            usuarioDAO.Alterar(usu);

            return RedirectToAction("Index", "Login");
        }

        public JsonResult ListaRespostas(int id)
        {
            IList<resposta> lista = respostaDAO.Lista();
            return Json(lista);
        }
    }
}