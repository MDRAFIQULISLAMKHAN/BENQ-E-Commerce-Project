using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using BH.BusinessLayer;
using Newtonsoft.Json;
using BH.Models;
using Vereyon.Web;

namespace BhWeb.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            PublicViewModel publicViewModel = new PublicViewModel();
            publicViewModel.CompanyDetails = CompanyDetailsManager.GetCompanyDetails(1);
            publicViewModel.BannerList = BannerManager.GetAllBanner();
            publicViewModel.BrandList = BrandManager.GetAllBrand();
            //publicViewModel.Categories = ProductManager.GetAllProductCategories();
            publicViewModel.FeturedProductList = FeaturedProduct();
            publicViewModel.NewArrivalList = Arrival();
            publicViewModel.TrendingList = Trending();
            publicViewModel.DealList = Deals();
            List<ProductModel> productsList = new List<ProductModel>();


            foreach (var deal in publicViewModel.DealList)
            {
                var dealProductById = ProductManager.GetProductById(deal.ProductID);
                productsList.Add(dealProductById);

            }

            publicViewModel.DealsofthedayProductList = productsList;

            return View("~/Views/Home/benq.cshtml", publicViewModel);
        }

        public ActionResult Headertop()
        {
            return PartialView();
        }


        public List<ProductModel> FeaturedProduct()
        {
            PublicViewModel publicViewModel = new PublicViewModel();
            List<ProductModel> product = publicViewModel.ProductsList;
            publicViewModel.ProductsList = ProductManager.GetAllProduct();
            product = publicViewModel.ProductsList;
            List<ProductModel> result = (product.Where(i => i.FeaturedProducts == true).ToList<ProductModel>());
            return result;
        }

        public List<ProductModel> Arrival()
        {
            PublicViewModel publicViewModel = new PublicViewModel();
            List<ProductModel> product = publicViewModel.ProductsList;
            publicViewModel.ProductsList = ProductManager.GetProducts();
            product = publicViewModel.ProductsList;
            List<ProductModel> arrival = product.Where(i => i.NewArrivals == true).ToList();
            List<ProductModel> arrivalDate = arrival.OrderByDescending(i => i.CreatedDate).Take(12).ToList();

            return arrivalDate;
        }

        public List<ProductModel> Trending()
        {
            PublicViewModel publicViewModel = new PublicViewModel();
            List<ProductModel> product = publicViewModel.ProductsList;
            publicViewModel.ProductsList = ProductManager.GetProducts();
            product = publicViewModel.ProductsList;

            List<ProductModel> trending = (product.Where(i => i.Trending == true).ToList<ProductModel>());

            return trending;
        }

    }

    
}