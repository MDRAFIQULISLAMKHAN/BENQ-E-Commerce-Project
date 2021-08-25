using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name required")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "Product Description required")]
        public string ProductDescription { get; set; }

        [Display(Name = "ProductFull Description")]
        [Required(ErrorMessage = "ProductFull Description required")]
        public string ProductFullDescription { get; set; }

        [Display(Name = "Product Additional Information")]
        [Required(ErrorMessage = "Product Additional Information required")]
        public string ProductAdditionalInformation { get; set; }

        [Display(Name = "ProductShipping")]
        [Required(ErrorMessage = "Product Shipping required")]
        public string ProductShipping { get; set; }

        [Display(Name = "CategoriesID")]
        [Required(ErrorMessage = "CategoriesID required")]
        public int CategoriesID { get; set; }

        [Display(Name = "SubCategoriesID")]
        [Required(ErrorMessage = "SubCategoriesID required")]
        public int SubCategoriesID { get; set; }

        [Display(Name = "ProductTypeID")]
        [Required(ErrorMessage = "ProductTypeID required")]
        public int ProductTypeID { get; set; }

        [Display(Name = "ManufacturersID")]
        [Required(ErrorMessage = "ManufacturersID required")]
        public int ManufacturersID { get; set; }

        [Display(Name = "ReviewID")]
        [Required(ErrorMessage = "ReviewID required")]
        public int ReviewID { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "Product Price required")]
        public int ProductPrice { get; set; }

        [Display(Name = "Discounts")]
        [Required(ErrorMessage = "Discounts required")]
        public int Discounts { get; set; }

        [Display(Name = "TaxCategoryID")]
        [Required(ErrorMessage = "TaxCategoryID required")]
        public int TaxCategoryID { get; set; }

        [Display(Name = "StockQuantity")]
        [Required(ErrorMessage = "StockQuantity required")]
        public int StockQuantity { get; set; }

        [Display(Name = "Display Availability")]
        [Required(ErrorMessage = "Display Availability required")]
        public bool DisplayAvailability { get; set; }

        [Display(Name = "Product Image")]
        [Required(ErrorMessage = "Product Image required")]
        public string ProductImage { get; set; }

        [Display(Name = "Product SKU")]
        [Required(ErrorMessage = "Product SKU required")]
        public string ProductSKU { get; set; }

        [Display(Name = "BrandID")]
        [Required(ErrorMessage = "BrandID required")]
        public int BrandID { get; set; }

        [Display(Name = "Featured Products")]
        [Required(ErrorMessage = "Featured Products required")]
        public bool FeaturedProducts { get; set; }

        [Display(Name = "New Arrivals Product")]
        [Required(ErrorMessage = "New Arrivals Product required")]
        public bool NewArrivals { get; set; }

        [Display(Name = "Trending Products")]
        [Required(ErrorMessage = "Trending Products required")]
        public bool Trending { get; set; }

        [Display(Name = "SaleID")]
        [Required(ErrorMessage = "SaleID required")]
        public int SaleID { get; set; }

        [Display(Name = "UserID")]
        [Required(ErrorMessage = "UserID required")]
        public int UserID { get; set; }

        [Display(Name = "CreatedBy")]
        [Required(ErrorMessage = "CreatedBy required")]
        public string CreatedBy { get; set; }

        [Display(Name = "CreatedDate")]
        [Required(ErrorMessage = "CreatedDate required")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "AddedBy")]
        [Required(ErrorMessage = "AddedBy required")]
        public string AddedBy { get; set; }

        [Display(Name = "AddedDate")]
        [Required(ErrorMessage = "AddedDate required")]
        public DateTime AddedDate { get; set; }







    }
}
