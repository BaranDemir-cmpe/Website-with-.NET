using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramming_Homework.Models;

namespace WebProgramming_Homework.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        Context db = new Context();
        public ActionResult Index()
        {
            List<Information> informationList = db.Informations.ToList();
            return View(informationList);
        }
    }
}