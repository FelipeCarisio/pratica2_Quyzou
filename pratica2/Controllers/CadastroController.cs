using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pratica2.Models;
using pratica2.DAO;

namespace pratica2.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar(usuario u)
        {
            if (u != null)
            {
                u.Pontos = default(int);

                usuarioDAO.Adicionar(u);
                Session["usuarioLogado"] = u;
                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("Index");

        }
    }
}