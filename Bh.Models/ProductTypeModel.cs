using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class ProductTypeModel
    {
        [Key]
        public int TypeID { get; set; }

        [Display(Name = "Type Name")]
        [Required(ErrorMessage = "Type Name required")]
        public string TypeName { get; set; }

        [Display(Name = "CategorieID")]
        [Required(ErrorMessage = "CategorieID required")]
        public int CategorieID { get; set; }

        [Display(Name = "SubCategoriesID")]
        [Required(ErrorMessage = "SubCategoriesID required")]
        public int SubCategoriesID { get; set; }

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
