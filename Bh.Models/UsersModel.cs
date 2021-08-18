using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class UsersModel
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name = "User Email")]
        [Required(ErrorMessage = "User Email required")]
        public string UserEmail { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name required")]
        public string UserName { get; set; }

        [Display(Name = "User MobileNo")]
        [Required(ErrorMessage = "User MobileNo required")]
        public int UserMobileNo { get; set; }

        [Display(Name = "User Address")]
        [Required(ErrorMessage = "User Address required")]
        public string UserAddress { get; set; }

        [Display(Name = "User Shipping Address")]
        [Required(ErrorMessage = "User Shipping Address required")]
        public string UserShippingAddress { get; set; }

    }
}
