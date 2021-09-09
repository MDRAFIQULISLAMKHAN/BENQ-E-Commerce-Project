using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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


        [HttpPost]
        public JsonResult AddToCart(CartModel cartItem)
        {
            var result = AddDetails(cartItem);
            return Json(new { Success = true, Message = result }, JsonRequestBehavior.AllowGet);
        }

        /*[HttpPost]
        public JsonResult Index(ItemViewModel objItemViewModel)
        {
            string NewImage = Guid.NewGuid() + Path.GetExtension(objItemViewModel.ImagePath.FileName);
            objItemViewModel.ImagePath.SaveAs(Server.MapPath("~/Images/" + NewImage));

            Item objItem = new Item();
            objItem.ImagePath = "~/Images/" + NewImage;
            objItem.CategoryId = objItemViewModel.CategoryId;
            objItem.Description = objItemViewModel.Description;
            objItem.ItemCode = objItemViewModel.ItemCode;
            objItem.ItemId = Guid.NewGuid();
            objItem.ItemName = objItemViewModel.ItemName;
            objItem.ItemPrice = objItemViewModel.ItemPrice;
            objECartDbEntities.Items.Add(objItem);
            objECartDbEntities.SaveChanges();

            return Json(new { Success = true, Message = "Item is added Successfully." }, JsonRequestBehavior.AllowGet);
        }*/
        //To add Records into database     
        private string AddDetails(CartModel cartItem)
        {
            CartManager newCart = new CartManager();
            if (cartItem != null && cartItem.CartID > 0)
            {
                cartItem.CreatedDate = DateTime.Today;
                cartItem.CreatedBy = "Admin";
                CartManager.UpdateCart(cartItem);
                return "Cart Updated Successfully";
            }
            else
            {
                if (cartItem != null)
                {
                        cartItem.CreatedDate = DateTime.Today;
                        cartItem.CreatedBy = "Admin";
                        CartManager.InsertCart(cartItem);
                        return "Added to Cart Successfully";
                }
            }

            return "Added to Cart Faild";
        }

    }
}