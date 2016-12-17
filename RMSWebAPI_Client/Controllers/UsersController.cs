using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RMSWebAPI_Client.Models;

namespace RMSWebAPI_Client.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
    }
}