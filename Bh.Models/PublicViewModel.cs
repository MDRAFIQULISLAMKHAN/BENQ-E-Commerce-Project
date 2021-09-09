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
        public List<StoreModel> StoreList { get; set; }
        public List<DealModel> DealList { get; set; }
        public DealModel Deal { get; set; }
        public List<DealModel> dealsofTheday { get; set; }
        public List<ProductModel> DealsofthedayProductList { get; set; }
        public ProductModel Product { get; set; }
        public List<ProductGalleryModel> ProductGallery { get; set; }
        public List<ProductCategoriesModel> Categories { get; set; }
        public List<BrandModel> BrandList { get; set; }
        public List<ProductModel> ProductsListbyCategoryId { get; set; }
        public List<ProductModel> ProductsListbySubCategoryId { get; set; }
        public CartModel AddtoCart { get; set; }
    }
}
