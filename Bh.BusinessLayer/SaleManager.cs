using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class SaleManager
    {
        public static List<SaleModel> GetAllSale()
        {
            SqlSaleProvider provider = new SqlSaleProvider();
            return provider.GetAllSale();
        }

        public static SaleModel GetSaleById(long Id)
        {
            SqlSaleProvider provider = new SqlSaleProvider();
            return provider.GetSaleById(Id);
        }

        public static long InsertSale(SaleModel Sale)
        {
            SqlSaleProvider provider = new SqlSaleProvider();
            return provider.InsertSale(Sale);
        }

        public static bool UpdateSale(SaleModel sale)
        {
            SqlSaleProvider provider = new SqlSaleProvider();
            return provider.UpdateSale(sale);
        }


        public static bool DeleteSale(long Id)
        {
            SqlSaleProvider provider = new SqlSaleProvider();
            return provider.DeleteSale(Id);
        }
    }
}
