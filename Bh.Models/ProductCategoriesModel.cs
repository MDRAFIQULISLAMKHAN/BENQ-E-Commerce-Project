using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class ProductCategoriesModel
    {

        [Key]
        public int CategorieID { get; set; }

        [Display(Name = "Categorie Name")]
        [Required(ErrorMessage = "Categorie Name required")]
        public string CategorieName { get; set; }

        [Display(Name = "Categorie Description")]
        [Required(ErrorMessage = "Categorie Description required")]
        public string CategorieDescription { get; set; }

        [Display(Name = "CreatedBy Name")]
        [Required(ErrorMessage = "CreatedBy Name required")]
        public string CreatedBy { get; set; }

        [Display(Name = "Categorie Description")]
        [Required(ErrorMessage = "Categorie Description required")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "AddedBy Name")]
        [Required(ErrorMessage = "AddedBy required")]
        public string AddedBy { get; set; }

        [Display(Name = "AddedDate")]
        [Required(ErrorMessage = "AddedDate required")]
        public string AddedDate { get; set; }
    }
}
