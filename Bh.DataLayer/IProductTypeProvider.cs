using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface IProductTypeProvider
    {
        List<ProductTypeModel> GetAllProductType();
        ProductTypeModel GetProductTypeById(long Id);
        long InsertProductType(ProductTypeModel Producttype);
        bool UpdateProductType(ProductTypeModel producttype);
        bool DeleteProductType(long Id);
    }
}
