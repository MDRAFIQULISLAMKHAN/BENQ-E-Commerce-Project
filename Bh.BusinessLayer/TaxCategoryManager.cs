using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class TaxCategoryManager
    {
        public static List<TaxCategoryModel> GetAllTaxCategory()
        {
            SqlTaxCategoryProvider provider = new SqlTaxCategoryProvider();
            return provider.GetAllTaxCategory();
        }

        public static TaxCategoryModel GetTaxCategoryById(long Id)
        {
            SqlTaxCategoryProvider provider = new SqlTaxCategoryProvider();
            return provider.GetTaxCategoryById(Id);
        }

        public static long InsertTaxCategory(TaxCategoryModel Taxcategory)
        {
            SqlTaxCategoryProvider provider = new SqlTaxCategoryProvider();
            return provider.InsertTaxCategory(Taxcategory);
        }

        public static bool UpdateTaxCategory(TaxCategoryModel taxcategory)
        {
            SqlTaxCategoryProvider provider = new SqlTaxCategoryProvider();
            return provider.UpdateTaxCategory(taxcategory);
        }


        public static bool DeleteTaxCategory(long Id)
        {
            SqlTaxCategoryProvider provider = new SqlTaxCategoryProvider();
            return provider.DeleteTaxCategory(Id);
        }
    }
}
