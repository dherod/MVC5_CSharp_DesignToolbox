using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignToolbox.Controllers
{
    public class ToolController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Basics()
        {
            ViewBag.Title = "OO Basics";

            return View();
        }

        public ActionResult Principles()
        {
            ViewBag.Title = "OO Principles";

            return View();
        }

        public ActionResult Patterns()
        {
            ViewBag.Title = "OO Patterns";

            return View();
        }
    }
}