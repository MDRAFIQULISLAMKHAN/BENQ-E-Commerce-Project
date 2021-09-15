using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using BH.BusinessLayer;
using BH.Models;

namespace BhWeb.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart    
        /*public ActionResult Index(string id)
        {

            return View("~/Views/Cart/Index.cshtml",publicViewModel);
        }*/

        [HttpPost]
        public ActionResult ProductInCart(PublicViewModel pc)
        {
            CartManager.InsertCart(pc.InsertCart);

            return View(pc);
        }
    }
}