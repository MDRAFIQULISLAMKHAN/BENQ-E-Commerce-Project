using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class BrandManager
    {
        public static List<BrandModel> GetAllBrand()
        {
            SqlBrandProvider provider = new SqlBrandProvider();
            return provider.GetAllBrand();
        }

        public static BrandModel GetBrandById(long Id)
        {
            SqlBrandProvider provider = new SqlBrandProvider();
            return provider.GetBrandById(Id);
        }

        public static long InsertBrand(BrandModel Brand)
        {
            SqlBrandProvider provider = new SqlBrandProvider();
            return provider.InsertBrand(Brand);
        }

        public static bool UpdateBrand(BrandModel brand)
        {
            SqlBrandProvider provider = new SqlBrandProvider();
            return provider.UpdateBrand(brand);
        }


        public static bool DeleteBrand(long Id)
        {
            SqlBrandProvider provider = new SqlBrandProvider();
            return provider.DeleteBrand(Id);
        }
    }
}
