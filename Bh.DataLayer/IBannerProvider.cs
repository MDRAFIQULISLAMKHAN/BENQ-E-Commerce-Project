using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayerSql
{
    public interface IBannerProvider
    {
        List<BannerModel> GetAllBanner();
        BannerModel GetBannerById(long Id);
        long InsertBanner(BannerModel Banner);
        bool UpdateBanner(BannerModel banner);
        bool DeleteBanner(long Id);
    }
}
