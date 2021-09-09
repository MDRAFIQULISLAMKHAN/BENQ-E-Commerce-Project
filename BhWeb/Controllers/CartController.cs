using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BH.BusinessLayer;
using BH.Models;
using Vereyon.Web;

namespace BhWeb.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult InsertCart()
        {
            PublicViewModel av = new PublicViewModel();
            av.AddtoCart = new CartModel();
            return View("",av);
        }

        /*[HttpPost]
        [ValidateInput(false)]
        public ActionResult InsertCart(PublicViewModel av)
        {
            if (av.AddtoCart != null && av.AddtoCart.CartID > 0)
            {

                av.AddtoCart.CreatedDate = DateTime.Today;
                av.AddtoCart.CreatedBy = "Admin";
                CartManager.UpdateCart(av.AddtoCart);
            }
            else
            {
                if (av.AddtoCart != null)
                {
                   
                        av.ProjectCategory.ImageUrl = _UploadSingleImage(av, image);
                        av.ProjectCategory.IsActive = true;
                        av.ProjectCategory.CreatedDate = DateTime.Today;
                        av.ProjectCategory.CreatedBy = "Admin";
                        CategoryManager.InsertProjectCategory(av.ProjectCategory);
                  
                        FlashMessage.Danger("Image Required");
                        return View(av);
                   
                }
            }

            return RedirectToAction("Categories");
        }*/
    }
}