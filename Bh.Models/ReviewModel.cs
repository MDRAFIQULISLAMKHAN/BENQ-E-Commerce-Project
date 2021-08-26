using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class ReviewModel
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "Reviewer Name")]
        [Required(ErrorMessage = "Reviewer Name required")]
        public string ReviewerName { get; set; }

        [Display(Name = "Reviewer Star")]
        [Required(ErrorMessage = "Reviewer Star required")]
        public string ReviewerStar { get; set; }

        [Display(Name = "Review Title")]
        [Required(ErrorMessage = "Review Title required")]
        public string ReviewTitle { get; set; }

        [Display(Name = "Review Description")]
        [Required(ErrorMessage = "Review Description required")]
        public string ReviewDescription { get; set; }

        [Display(Name = "ProductID")]
        [Required(ErrorMessage = "ProductID required")]
        public int ProductID { get; set; }

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
        [Required(ErrorMessage = "Added Date required")]
        public DateTime AddedDate { get; set; }


    }
}
