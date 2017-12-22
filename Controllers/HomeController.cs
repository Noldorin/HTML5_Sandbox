using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML5_Sandbox.Models;

namespace HTML5_Sandbox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Grid()
        {
            List<REI> myREIs = new List<REI>();

            Models.REI tempREI = new REI();
            tempREI.name = "REI1";
            tempREI.chassis = 123;
            myREIs.Add(tempREI);

            tempREI.name = "REI2";
            tempREI.chassis = 124;
            myREIs.Add(tempREI);

            tempREI.name = "REI3";
            tempREI.chassis = 125;
            myREIs.Add(tempREI);

            tempREI.name = "REI4";
            tempREI.chassis = 126;
            myREIs.Add(tempREI);

            return View(myREIs);
        }

        public ActionResult REI_Grid()
        {
            List<REI> myREIs = new List<REI>();

            Models.REI tempREI = new REI();
            tempREI.name = "REI1";
            tempREI.chassis = 123;
            myREIs.Add(tempREI);

            tempREI.name = "REI2";
            tempREI.chassis = 124;
            myREIs.Add(tempREI);

            tempREI.name = "REI3";
            tempREI.chassis = 125;
            myREIs.Add(tempREI);

            tempREI.name = "REI4";
            tempREI.chassis = 126;
            myREIs.Add(tempREI);

            return View(myREIs);
        }

    }
}