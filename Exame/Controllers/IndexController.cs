using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovimentosManuais.Model;
using MovimentosManuais.BLL;

namespace Exame.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Index(MovimentoManual movimento)
        {
            MovimentosManuaisComponents mc = new MovimentosManuaisComponents();

            bool result = mc.IncluirProdutos(movimento);

            if (result)
            {
                ViewBag.result = "Dados Salvos com sucesso!";
                return View();
            }
            else
            {
                return View();
            }
        }
        
    }
}