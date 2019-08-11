using Dominio;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PessoaController : Controller
    {
        PessoaService ps = new PessoaService();

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

            ps.Gravar(model);
            ModelState.Clear();
            return View();
        }
        public ActionResult List()
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> pessoas = ps.Ler();

            return View(pessoas);
        }

        public ActionResult Delete(int id)
        {
            Pessoa model = new Pessoa();
            ps.Deletar(id);
            return RedirectToAction("List");
        }
    }
}