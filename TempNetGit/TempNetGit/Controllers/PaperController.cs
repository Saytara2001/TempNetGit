using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchGateWeb.Controllers
{
    public class PaperController : Controller
    {
        // GET: Paper
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShowPaper(id)
        public ActionResult ShowPaper()
        {
            return View();
        }
    }
}