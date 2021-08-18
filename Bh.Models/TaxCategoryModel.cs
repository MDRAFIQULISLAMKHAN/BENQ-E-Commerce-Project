using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class TaxCategoryModel
    {
        [Key]
        public int TaxCategoryID { get; set; }

        [Display(Name = "Tax Category Name")]
        [Required(ErrorMessage = "Tax Category Name required")]
        public string TaxCategoryName { get; set; }

        [Display(Name = "Tax Percentage")]
        [Required(ErrorMessage = "Tax Percentage required")]
        public int TaxPercentage { get; set; }

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
