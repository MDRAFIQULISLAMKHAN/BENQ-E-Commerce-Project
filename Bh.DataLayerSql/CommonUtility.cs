using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.DataLayerSql
{
    public class CommonUtility
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["connectionString"].ToString();
    }

    public static class StoreProcedure
    {
        // Users
        public static string GetUserByUsernamePassword = "sp_GetUserByUsernamePassword";


        // Company Details
        public static string GetCompanyDetails = "sp_GetCompanyDetailDetails";


        //Banner
        public static string GetAllBanner = "sp_GetBanner";
        public static string GetBannerById = "sp_GetBannerDetails";
        public static string InsertBanner = "sp_InsertBanner";
        public static string UpdateBanner = "sp_UpdateBanner";
        public static string DeleteBanner = "sp_DeleteBanner";

        
        //Brand
        public static string GetAllBrand = "sp_GetBrand";
        public static string GetBrandById = "sp_GetBrandDetails";
        public static string InsertBrand = "sp_InsertBrand";
        public static string UpdateBrand = "sp_UpdateBrand";
        public static string DeleteBrand = "sp_DeleteBrand";

        
        //Cart
        public static string GetAllCart = "sp_GetCart";
        public static string GetCartById = "sp_GetCartDetails";
        public static string InsertCart = "sp_InsertCart";
        public static string UpdateCart = "sp_UpdateCart";
        public static string DeleteCart = "sp_DeleteCart";
        
        
        //Deal
        public static string GetAllDeal = "sp_GetDeal";
        public static string GetDealById = "sp_GetDealDetails";
        public static string InsertDeal = "sp_InsertDeal";
        public static string UpdateDeal = "sp_UpdateDeal";
        public static string DeleteDeal = "sp_DeleteDeal";

        
        //Manufactureres
        public static string GetAllManufacturers = "sp_GetManufacturers";
        public static string GetManufacturersById = "sp_GetManufacturerDetails";
        public static string InsertManufacturers = "sp_InsertManufacturer";
        public static string UpdateManufacturers = "sp_UpdateManufacturer";
        public static string DeleteManufacturers = "sp_DeleteManufacturer";


        //Payment
        public static string GetAllPayment = "sp_GetPayment";
        public static string GetPaymentById = "sp_GetPaymentDetails";
        public static string InsertPayment = "sp_InsertPayment";
        public static string UpdatePayment = "sp_UpdatePayment";
        public static string DeletePayment = "sp_DeletePayment";
        

        //Product Categories
        public static string GetAllProductCategories = "sp_GetProductCategories";
        public static string GetProductCategoriesById = "sp_GetProductCategorieDetails";
        public static string InsertProductCategories = "sp_InsertProductCategorie";
        public static string UpdateProductCategories = "sp_UpdateProductCategorie";
        public static string DeleteProductCategories = "sp_DeleteProductCategorie";
        
        
        //Product Gallery
        public static string GetAllProductGallery = "sp_GetProductGallery";
        public static string GetProductGalleryById = "sp_GetProductGalleryDetails";
        public static string InsertProductGallery = "sp_InsertProductGallery";
        public static string UpdateProductGallery = "sp_UpdateProductGallery";
        public static string DeleteProductGallery = "sp_DeleteProductGallery";
        
        
        //Product
        public static string GetAllProduct = "sp_GetProduct";
        public static string GetProductById = "sp_GetProductDetails";
        public static string InsertProduct = "sp_InsertProduct";
        public static string UpdateProduct = "sp_UpdateProduct";
        public static string DeleteProduct = "sp_DeleteProduct";
        
        
        //Product Sub Categories
        public static string GetAllProductSubCategories = "sp_GetProductSubCategories";
        public static string GetProductSubCategoriesById = "sp_GetProductSubCategorieDetails";
        public static string InsertProjectSubCategory = "sp_InsertProductSubCategorie";
        public static string UpdateProjectSubCategory = "sp_UpdateProductSubCategorie";
        public static string DeleteProjectSubCategory = "sp_DeleteProductSubCategorie";
        
        
        //Product Type
        public static string GetAllProductType = "sp_GetProductType";
        public static string GetProductTypeById = "sp_GetProductTypeDetails";
        public static string InsertProductType = "sp_InsertProductType";
        public static string UpdateProductType = "sp_UpdateProductType";
        public static string DeleteProductType = "sp_DeleteProductType";


        //Review
        public static string GetAllReview = "sp_GetReview";
        public static string GetReviewById = "sp_GetReviewDetails";
        public static string InsertReview = "sp_InsertReview";
        public static string UpdateReview = "sp_UpdateReview";
        public static string DeleteReview = "sp_DeleteReview";


        //Sale
        public static string GetAllSale = "sp_GetSale";
        public static string GetSaleById = "sp_GetSaleDetails";
        public static string InsertSale = "sp_InsertSale";
        public static string UpdateSale = "sp_UpdateSale";
        public static string DeleteSale = "sp_DeleteSale";


        //Store
        public static string GetAllStore = "sp_GetStore";
        public static string GetStoreById = "sp_GetStoreDetails";
        public static string InsertStore = "sp_InsertStore";
        public static string UpdateStore = "sp_UpdateStore";
        public static string DeleteStore = "sp_DeleteStore";


        //Token
        public static string GetAllToken = "sp_GetToken";
        public static string GetTokenById = "sp_GetTokenDetails";
        public static string InsertToken = "sp_InsertToken";
        public static string UpdateToken = "sp_UpdateToken";
        public static string DeleteToken = "sp_DeleteToken";


        //Tax Category
        public static string GetAllTaxCategory = "sp_GetTaxCategory";
        public static string GetTaxCategoryById = "sp_GetTaxCategoryDetails";
        public static string InsertTaxCategory = "sp_InsertTaxCategory";
        public static string UpdateTaxCategory = "sp_UpdateTaxCategory";
        public static string DeleteTaxCategory = "sp_DeleteTaxCategory";

    }
}