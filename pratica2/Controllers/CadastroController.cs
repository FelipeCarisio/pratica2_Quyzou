﻿using System;
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
            ViewBag.Title = "Cadastro";
            return View();
        }
        public ActionResult Cadastrar(usuario u)
        {
            if (u != null)
            {
                u.Pontos = default(int);

                usuario usu = u;

                if (usuarioDAO.BuscaEmail(usu.Email) == null)
                {
                    usuarioDAO.Adicionar(u);
                    Session["usuarioLogado"] = u;
                    return RedirectToAction("Index", "Home");
                }
                else
                { 
                    return RedirectToAction("Index");
                }
            }
            else
                return RedirectToAction("Index");

        }
    }
}