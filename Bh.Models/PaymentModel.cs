using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class PaymentModel
    {
        [Key]
        public int PaymentID { get; set; }

        [Display(Name = "UserID")]
        [Required(ErrorMessage = "UserID required")]
        public int UserID { get; set; }

        [Display(Name = "TokenID")]
        [Required(ErrorMessage = "TokenID required")]
        public int TokenID { get; set; }

        [Display(Name = "Payment Status")]
        [Required(ErrorMessage = "Payment Status required")]
        public bool PaymentStatus { get; set; }

        [Display(Name = "Payment Gateway")]
        [Required(ErrorMessage = "Payment Gateway required")]
        public string PaymentGateway { get; set; }

        [Display(Name = "Payment Type")]
        [Required(ErrorMessage = "Payment Type required")]
        public string PaymentType { get; set; }

        [Display(Name = "Payment Amount")]
        [Required(ErrorMessage = "Payment Amount required")]
        public int PaymentAmount { get; set; }

        [Display(Name = "CreatedBy Name")]
        [Required(ErrorMessage = "CreatedBy Name required")]
        public string CreatedBy { get; set; }

        [Display(Name = "CreatedDate")]
        [Required(ErrorMessage = "CreatedDate required")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "AddedBy Name")]
        [Required(ErrorMessage = "AddedBy Name required")]
        public string AddedBy { get; set; }

        [Display(Name = "Added Date")]
        [Required(ErrorMessage = "Added Date required")]
        public DateTime AddedDate { get; set; }


    }
}
