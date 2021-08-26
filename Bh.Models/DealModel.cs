using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class DealModel
    {
        [Key]
        public int DealID { get; set; }

        [Display(Name = "ProductID")]
        [Required(ErrorMessage = "ProductID required")]
        public int ProductID { get; set; }

        [Display(Name = "Starting Time")]
        [Required(ErrorMessage = "Starting Time required")]
        public DateTime StartingTime { get; set; }

        [Display(Name = "Ending Time")]
        [Required(ErrorMessage = "Ending Time required")]
        public DateTime EndingTime { get; set; }

        [Display(Name = "New Price")]
        [Required(ErrorMessage = "New Price required")]
        public string NewPrice { get; set; }

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
