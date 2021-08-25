using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayer
{
    public interface IStoreProvider
    {
        List<StoreModel> GetAllStore();
        StoreModel GetStoreById(long Id);
        long InsertStore(StoreModel Store);
        bool UpdateStore(StoreModel store);
        bool DeleteStore(long Id);
    }
}
