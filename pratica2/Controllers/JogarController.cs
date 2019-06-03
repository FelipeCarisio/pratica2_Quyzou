using pratica2.DAO;
using pratica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Pontuar(int pontos)
        {              
            pratica2.Models.usuario usu = new pratica2.Models.usuario();

            usu = (pratica2.Models.usuario)Session["usuarioLogado"];

            usu.Pontos += pontos;

            ((pratica2.Models.usuario)Session["usuarioLogado"]).Pontos = usu.Pontos;

            pratica2.DAO.usuarioDAO.Alterar(usu);

            return RedirectToAction("Index", "Login");
        }

        public JsonResult ListaRespostas(int id)
        {
            IList<resposta> lista = respostaDAO.Lista();
            return Json(lista);
        }
    }
}