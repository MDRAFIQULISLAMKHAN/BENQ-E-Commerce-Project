using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface ISaleProvider
    {
        List<SaleModel> GetAllSale();
        SaleModel GetSaleById(long Id);
        long InsertSale(SaleModel Sale);
        bool UpdateSale(SaleModel sale);
        bool DeleteSale(long Id);
    }
}
