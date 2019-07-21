using Data;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PessoaController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pessoa model)
        {
            model.Gravar();
            ModelState.Clear();
            return View();
        }
        public ActionResult List()
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> pessoas = pessoa.Ler();

            return View(pessoas);
        }

        public ActionResult Delete(string nome)
        {
            Pessoa model = new Pessoa();
            model.Deletar(nome);
            return RedirectToAction("List");
        }
    }
}