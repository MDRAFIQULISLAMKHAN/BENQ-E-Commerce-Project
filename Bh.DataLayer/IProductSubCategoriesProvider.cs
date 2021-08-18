using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface IProductSubCategoriesProvider
    {
        List<ProductSubCategoriesModel> GetAllProductSubCategories();
        ProductSubCategoriesModel GetProductSubCategoriesById(long Id);
        long InsertProjectSubCategory(ProductSubCategoriesModel Productsubcategories);
        bool UpdateProjectSubCategory(ProductSubCategoriesModel productsubcategories);
        bool DeleteProjectSubCategory(long Id);
    }
}
