using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BH.Models
{
    public class AdminViewModel
    {
        public BannerModel Banner { get; set; }
        public List<BannerModel> BannerList { get; set; }
        public BrandModel Brand { get; set; }
        public List<BrandModel> BrandList { get; set; }
        public CompanyDetailsModel CompanyDetails { get; set; }
        public ManufacturersModel Manufacturers { get; set; }
        public List<ManufacturersModel> ManufacturersList { get; set; }
        public ProductModel Product { get; set; }
        public List<ProductModel> ProductList { get; set; }
        public ProductCategoriesModel ProductCategories { get; set; }
        public List<ProductCategoriesModel> ProductCategoriesList { get; set; }
        public ProductSubCategoriesModel ProductSubCategories { get; set; }
        public List<ProductSubCategoriesModel> ProductSubCategoriesList { get; set; }
        public ProductGalleryModel ProductGallery { get; set; }
        public List<ProductGalleryModel> ProductGalleryList { get; set; }
        public SaleModel Sale { get; set; }
        public List<SaleModel> SaleList { get; set; }
        public TaxCategoryModel TaxCategory { get; set; }
        public List<TaxCategoryModel> TaxCategoryList { get; set; }
        public UsersModel Users { get; set; }
        public List<UsersModel> UsersList { get; set; }


    }
}
