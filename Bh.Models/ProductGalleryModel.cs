using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
     public class ProductGalleryModel
    {
        [Key]
        public int ProductGalleryID { get; set; }

        [Display(Name = "ProductID")]
        [Required(ErrorMessage = "ProductID required")]
        public int ProductID { get; set; }

        [Display(Name = "Product Image")]
        [Required(ErrorMessage = "Product Image required")]
        public string ProductImage { get; set; }

        [Display(Name = "Is Active")]
        [Required(ErrorMessage = "Is Active required")]
        public bool IsActive { get; set; }

        [Display(Name = "CreatedBy Name")]
        [Required(ErrorMessage = "CreatedBy Name required")]
        public string CreatedBy { get; set; }

        [Display(Name = "CreatedDate")]
        [Required(ErrorMessage = "CreatedDate required")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "AddedBy Name")]
        [Required(ErrorMessage = "AddedBy Name required")]
        public string AddedBy { get; set; }

        [Display(Name = "AddedDate")]
        [Required(ErrorMessage = "AddedDate required")]
        public DateTime AddedDate { get; set; }
    }
}
