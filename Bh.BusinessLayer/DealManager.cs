using BH.DataLayerSql;
using BH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.BusinessLayer
{
    public class DealManager
    {
        public static List<DealModel> GetAllDeal()
        {
            SqlDealProvider provider = new SqlDealProvider();
            return provider.GetAllDeal();
        }

        public static DealModel GetDealById(long Id)
        {
            SqlDealProvider provider = new SqlDealProvider();
            return provider.GetDealById(Id);
        }

        public static long InsertDeal(DealModel Deal)
        {
            SqlDealProvider provider = new SqlDealProvider();
            return provider.InsertDeal(Deal);
        }

        public static bool UpdateDeal(DealModel deal)
        {
            SqlDealProvider provider = new SqlDealProvider();
            return provider.UpdateDeal(deal);
        }

        public static bool DeleteDeal(long Id)
        {
            SqlDealProvider provider = new SqlDealProvider();
            return provider.DeleteDeal(Id);
        }
    }
}
