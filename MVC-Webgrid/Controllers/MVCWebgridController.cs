using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Webgrid.Controllers
{
    public class MVCWebgridController : Controller
    {
        // GET: MVCWebgrid
        public ActionResult Index()
        {
            SampleDBEntities sd = new SampleDBEntities();
            return View(sd.users.ToList());
        }
    }
}