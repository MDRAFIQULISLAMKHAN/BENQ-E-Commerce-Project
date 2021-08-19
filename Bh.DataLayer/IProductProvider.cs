using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayerSql
{
    public interface IProductProvider
    {
        List<ProductModel> GetAllProduct();
        ProductModel GetProductById(long Id);
        long InsertProduct(ProductModel Product);
        bool UpdateProduct(ProductModel product);
        bool DeleteProduct(long Id);
    }
}
