﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pratica2.DAO;
using pratica2.Models;

namespace pratica2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [Route("Login/Index")]
        public ActionResult Index()
        {
            ViewBag.Title = "Login";
            return View();
        }
        public ActionResult Autentica(usuario u)
        {
            usuarioDAO dao = new usuarioDAO();
            usuario usu = dao.Busca(u.Nome, u.Senha);

            if (usu != null)
            {
                Session["usuarioLogado"] = usu;
                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("Index");
        }

        public ActionResult Desloga()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}