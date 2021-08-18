using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class SaleModel
    {
        [Key]
        public int SaleID { get; set; }

        [Display(Name = "Invoice No")]
        [Required(ErrorMessage = "Invoice No required")]
        public int InvoiceNo { get; set; }

        [Display(Name = "ProductID")]
        [Required(ErrorMessage = "ProductID required")]
        public int ProductID { get; set; }

        [Display(Name = "Total Price")]
        [Required(ErrorMessage = "Total Price required")]
        public int TotalPrice { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "Product Price required")]
        public int ProductPrice { get; set; }

        [Display(Name = "Discount Amount")]
        [Required(ErrorMessage = "Discount Amount required")]
        public int DiscountAmount { get; set; }

        [Display(Name = "SaleDate")]
        [Required(ErrorMessage = "SaleDate required")]
        public DateTime SaleDate { get; set; }

        [Display(Name = "UserId")]
        [Required(ErrorMessage = "UserId required")]
        public int UserId { get; set; }

        [Display(Name = "CreatedBy Name")]
        [Required(ErrorMessage = "CreatedBy Name required")]
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
