using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface IProductCategoriesProvider
    {
        List<ProductCategoriesModel> GetAllProductCategories();
        ProductCategoriesModel GetProductCategoriesById(long Id);
        long InsertProductCategories(ProductCategoriesModel Productcategories);
        bool UpdateProductCategories(ProductCategoriesModel productcategories);
        bool DeleteProductCategories(long Id);
    }
}
