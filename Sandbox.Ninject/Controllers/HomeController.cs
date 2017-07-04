using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Sandbox.Ninject.Service;

namespace Sandbox.Ninject.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IMyService Service { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            this.Service.DoNothing();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}