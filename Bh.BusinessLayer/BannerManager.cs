using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class BannerManager
    {
        public static List<BannerModel> GetAllBanner()
        {
            SqlBannerProvider provider = new SqlBannerProvider();
            return provider.GetAllBanner();
        }

        public static BannerModel GetBannerById(long Id)
        {
            SqlBannerProvider provider = new SqlBannerProvider();
            return provider.GetBannerById(Id);
        }

        public static long InsertBanner(BannerModel Banner)
        {
            SqlBannerProvider provider = new SqlBannerProvider();
            return provider.InsertBanner(Banner);
        }

        public static bool UpdateBanner(BannerModel banner)
        {
            SqlBannerProvider provider = new SqlBannerProvider();
            return provider.UpdateBanner(banner);
        }


        public static bool DeleteBanner(long Id)
        {
            SqlBannerProvider provider = new SqlBannerProvider();
            return provider.DeleteBanner(Id);
        }
    }
}
