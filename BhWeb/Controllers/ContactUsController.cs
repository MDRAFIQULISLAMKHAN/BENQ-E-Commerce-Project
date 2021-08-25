using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BH.Models;
using BH.BusinessLayer;

namespace BhWeb.Controllers
{
    public class ContactUsController : Controller
    {
        
        public ActionResult Index(long id)
        {
            PublicViewModel publicViewModel = new PublicViewModel();

            publicViewModel.CompanyDetails = CompanyDetailsManager.GetCompanyDetails(1);
            publicViewModel.StoreList = StoreManager.GetAllSale();
            return View("~/Views/ContactUs/Benq_ContactUs.cshtml", publicViewModel);
        }
    }
}