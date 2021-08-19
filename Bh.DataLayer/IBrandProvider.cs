using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayerSql
{
    public interface IBrandProvider
    {
        List<BrandModel> GetAllBrand();
        BrandModel GetBrandById(long Id);
        long InsertBrand(BrandModel Brand);
        bool UpdateBrand(BrandModel brand);
        bool DeleteBrand(long Id);
    }
}
