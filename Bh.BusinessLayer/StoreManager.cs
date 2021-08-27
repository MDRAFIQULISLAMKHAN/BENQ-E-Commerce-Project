using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class StoreManager
    {
        public static List<StoreModel> GetAllSale()
        {
            SqlStoreProvider provider = new SqlStoreProvider();
            return provider.GetAllStore();
        }

        public static StoreModel GetStoreById(long Id)
        {
            SqlStoreProvider provider = new SqlStoreProvider();
            return provider.GetStoreById(Id);
        }

        public static long InsertStore(StoreModel Store)
        {
            SqlStoreProvider provider = new SqlStoreProvider();
            return provider.InsertStore(Store);
        }

        public static bool UpdateStore(StoreModel store)
        {
            SqlStoreProvider provider = new SqlStoreProvider();
            return provider.UpdateStore(store);
        }


        public static bool DeleteStore(long Id)
        {
            SqlStoreProvider provider = new SqlStoreProvider();
            return provider.DeleteStore(Id);
        }
    }
}
