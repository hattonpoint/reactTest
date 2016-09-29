using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ReactTest.Models;

namespace ReactTest.Controllers
{
    public class TicketEditController : Controller
    {
        // GET: TicketEdit
        public ActionResult Index()
        {
            return View();
        }

    }
}