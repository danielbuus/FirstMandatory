using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using AarhusDevCoop.ViewModels;

namespace AarhusDevCoop.Controllers
{
    public class ContactFormSurfaceController : ContactFormSurfaceController
    {
        // GET: Default
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }

    }
}