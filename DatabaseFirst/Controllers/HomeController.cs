using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstEntities db =new DatabaseFirstEntities();

        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
    }
}