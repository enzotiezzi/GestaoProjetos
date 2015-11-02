using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gimeses.Controllers
{
    public class ExecucaoController : Controller
    {
        // GET: Execucao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Qualidade()
        {

            return View();
        }

        public ActionResult Aquisicao()
        {
            return View();
        }
    }
}