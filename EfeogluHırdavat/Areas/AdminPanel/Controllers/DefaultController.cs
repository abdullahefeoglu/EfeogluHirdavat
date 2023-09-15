using EfeogluHırdavat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfeogluHırdavat.Areas.AdminPanel.Controllers
{
    public class DefaultController : Controller
    {
        EfeogluHırdavatDBModel db = new EfeogluHırdavatDBModel();
        // GET: AdminPanel/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}