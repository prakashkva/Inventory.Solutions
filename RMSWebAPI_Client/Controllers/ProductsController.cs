using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RMSWebAPI_Client.Models;
using RMSWebAPI_Client.ViewModel;

namespace RMSWebAPI_Client.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ProductClient PC = new ProductClient();
            ViewBag.listProducts = PC.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create(long id= 0)
        {
            ProductClient pc = new ProductClient();
            ProductViewModel pvm = new ProductViewModel();
            if (id > 0)
            {
                pvm.Product =  pc.FindProduct(id);
            }
            return View(pvm);
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel pvm)
        {
            pvm.Product.CreatedDate = DateTime.Now;
            ProductClient pc = new ProductClient();

            if (pvm.Product != null)
            {
                if (pvm.Product.Oid > 0)
                {
                    pc.Edit(pvm.Product);
                }
                else
                {
                    pc.Create(pvm.Product);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ProductClient pc = new ProductClient();
            pc.Delete(id);
            return RedirectToAction("Index");
        }
    }
}