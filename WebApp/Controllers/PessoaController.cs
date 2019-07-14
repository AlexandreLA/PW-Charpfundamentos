using Data;
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
        public ActionResult List()
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> pessoas = pessoa.Ler();

            return View(pessoas);
        }
    }
}