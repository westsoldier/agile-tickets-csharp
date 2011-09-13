﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgileTickets.Web.Repositorios;
using AgileTickets.Web.Models;
using AgileTickets.Web.Infra.Database;

namespace AgileTickets.Web.Controllers
{
    public class EstabelecimentosController : Controller
    {
        private DiretorioDeEstabelecimentos estabelecimentos;

        public EstabelecimentosController(DiretorioDeEstabelecimentos estabelecimentos)
        {
            this.estabelecimentos = estabelecimentos;
        }

        public ActionResult Index()
        {
            return View(estabelecimentos.Todos());
        }

        [RequiresTransaction]
        public ActionResult Novo(Estabelecimento estabelecimento)
        {
            estabelecimentos.Salva(estabelecimento);

            return RedirectToAction("Index");
        }
    }
}
