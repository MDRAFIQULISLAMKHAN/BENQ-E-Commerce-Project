using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayer
{
    public interface IDealProvider
    {
        List<DealModel> GetAllDeal();
        DealModel GetDealById(long Id);
        long InsertDeal(DealModel Token);
        bool UpdateDeal(DealModel token);
        bool DeleteDeal(long Id);
    }
}
