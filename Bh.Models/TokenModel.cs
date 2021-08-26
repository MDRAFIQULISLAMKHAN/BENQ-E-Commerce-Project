using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class TokenModel
    {
        [Key]
        public int TokenID { get; set; }

        [Display(Name = "Token Number")]
        [Required(ErrorMessage = "Token Number required")]
        public string TokenNumber { get; set; }

        [Display(Name = "Discount Percentage")]
        [Required(ErrorMessage = "Discount Percentage required")]
        public float DiscountPercentage { get; set; }

        [Display(Name = "Token Active")]
        [Required(ErrorMessage = "Token Active required")]
        public bool TokenActive { get; set; }

        [Display(Name = "ProductID")]
        [Required(ErrorMessage = "ProductID required")]
        public int ProductID { get; set; }

        [Display(Name = "UserID")]
        [Required(ErrorMessage = "UserID required")]
        public int UserID { get; set; }

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
