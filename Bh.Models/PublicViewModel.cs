using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BH.Models
{
    public class PublicViewModel
    {

        public CompanyDetailsModel CompanyDetails { get; set; }
        public List<BannerModel> BannerList { get; set;  }
        public List<ProductModel> ProductsList { get; set; }
        public List<ProductModel> FeturedProductList { get; set; }
        public List<ProductModel> NewArrivalList { get; set; }
        public List<ProductModel> TrendingList { get; set; }
        public ProductModel Product { get; set; }
        public List<ProductGalleryModel> ProductGallery { get; set; }
        public List<BrandModel> BrandList { get; set; }
        public List<ProductModel> ProductsListbyCategoryId { get; set; }

    }
}
