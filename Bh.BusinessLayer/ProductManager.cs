using System.Collections.Generic;
using System.Linq;
using BH.DataLayerSql;
using BH.Models;

namespace BH.BusinessLayer
{
    public class ProductManager
    {
        public static List<ProductModel> GetProducts()
        {
            SqlProductProvider provider = new SqlProductProvider();

            return provider.GetAllProduct();
        }
    }
}