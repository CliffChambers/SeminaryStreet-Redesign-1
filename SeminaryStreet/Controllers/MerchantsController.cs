using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminaryStreet.Controllers
{
    public class MerchantsController : Controller
    {
        // GET: Merchants
        public ActionResult Index()
        {
            return View();
        }
    }
}