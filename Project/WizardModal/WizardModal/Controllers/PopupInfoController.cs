using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WizardModal.Controllers
{
    public class PopupInfoController : Controller
    {
        // GET: PopupInfo
        public ActionResult Popup1()
        {
            return PartialView("_Popup1");
        }
        public ActionResult Popup2()
        {
            return PartialView("_Popup2");
        }
        public ActionResult Popup3()
        {
            return PartialView("_Popup3");
        }
        public ActionResult Popup4()
        {
            return PartialView("_Popup4");
        }
    }
}