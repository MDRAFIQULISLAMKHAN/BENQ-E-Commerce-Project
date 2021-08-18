using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class ManufacturersModel
    {
        [Key]
        public int ManufacturersID { get; set; }

        [Display(Name = "Manufacturers Name")]
        [Required(ErrorMessage = "Manufacturers Name required")]
        public string ManufacturersName { get; set; }

        [Display(Name = "Manufacturers Description")]
        [Required(ErrorMessage = "Manufacturers Description required")]
        public string ManufacturersDescription { get; set; }

        [Display(Name = "CreateBy Name")]
        [Required(ErrorMessage = "CreateBy Name required")]
        public string CreateBy { get; set; }

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
