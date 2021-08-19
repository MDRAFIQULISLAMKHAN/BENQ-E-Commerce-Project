using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface ITaxCategoryProvider
    {
        List<TaxCategoryModel> GetAllTaxCategory();
        TaxCategoryModel GetTaxCategoryById(long Id);
        long InsertTaxCategory(TaxCategoryModel Taxcategory);
        bool UpdateTaxCategory(TaxCategoryModel taxcategory);
        bool DeleteTaxCategory(long Id);
    }
}
