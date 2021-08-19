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
        // User
        public static string GetUserByUsernamePassword = "sp_GetUserByUsernamePassword";


        //Banner
        public static string GetAllBanner = "sp_GetBanner";
        public static string GetBannerById = "sp_GetBannerDetails";
        public static string InsertBanner = "sp_InsertBanner";
        public static string UpdateBanner = "sp_UpdateBanner";
        public static string DeleteBanner = "sp_DeleteBanner";


        // Company Setting
        public static string GetCompanySetting = "sp_GetCompanySettingDetails";
        public static string UpdateCompanySettings = "sp_UpdateCompanySetting";


        //Brand
        public static string GetAllBrand = "sp_GetBrand";
        public static string GetBrandById = "sp_GetBrandDetails";
        public static string InsertBrand = "sp_InsertBrand";
        public static string UpdateBrand = "sp_UpdateBrand";
        public static string Deletebrand = "sp_DeleteBrand";
        
        
        //Manufacturers
        public static string GetAllManufacturers = "sp_GetManufacturers";
        public static string GetManufacturersById = "sp_GetManufacturerDetails";
        public static string InsertManufacturers = "sp_InsertManufacturer";
        public static string UpdateManufacturers = "sp_UpdateManufacturer";
        public static string DeleteManufacturers = "sp_DeleteManufacturer";
    }
}