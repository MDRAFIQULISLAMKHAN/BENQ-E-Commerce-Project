using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BH.BusinessLayer;
using BH.Models;

namespace BhWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(long id)
        {
            PublicViewModel publicViewModel = new PublicViewModel();

            List<ProductModel> product = publicViewModel.ProductsList;
            publicViewModel.ProductsList = ProductManager.GetProducts();
            
            product = publicViewModel.ProductsList;

            var result = (product.Where(i => i.ProductID == id));
            publicViewModel.Product = result.First();
            publicViewModel.ProductGallery = ProductManager.GetProductGallery(publicViewModel.Product.ProductID);
            return View("~/Views/Product/Benq_Product.cshtml", publicViewModel); 

        }
    }
}