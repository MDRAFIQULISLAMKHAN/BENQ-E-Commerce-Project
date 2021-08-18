using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BH.Models
{
    public class PublicViewModel
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
        public TaxCategoryModel TaxCategory { get; set; }
        public UsersModel Users { get; set; }

        /*public List<Banner> Banners { get; set; }
        public AboutUs AboutUs { get; set; }
        public OurClient Clients { get; set; }
        public OurClientsBanner ClientsBanner { get; set; }
        public List<OurClient> OurClients { get; set; }
        public CompanySetting CompanySetting { get; set; }
        public List<OurMachine> OurMachines { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }
        public List<ProjectSubCategory> ProjectSubCategories { get; set; }
        public List<OurService> OurServices { get; set; }
        public List<Project> Projects { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
        public ProjectSubCategory ProjectSubCategory { get; set; }
        public Project Project { get; set; }
        public List<ProjectGallery> ProjectGalleries { get; set; }
        public Feedback Feedback { get; set; }

        public string EmailStatus { get; set; }*/
    }
}
