using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class StoreModel
    {
        [Key]
        public int StoreID { get; set; }

        [Display(Name = "Store Image")]
        [Required(ErrorMessage = "Store Image required")]
        public string StoreImage { get; set; }

        [Display(Name = "Store Name")]
        [Required(ErrorMessage = "Store Name required")]
        public string StoreName { get; set; }

        [Display(Name = "Store Address")]
        [Required(ErrorMessage = "Store Address required")]
        public string StoreAddress { get; set; }

        [Display(Name = "Store PhoneNo")]
        [Required(ErrorMessage = "Store PhoneNo required")]
        public string StorePhoneNo { get; set; }

        [Display(Name = "Store Working Title")]
        [Required(ErrorMessage = "Store Working Title required")]
        public string StoreWorkingTitle { get; set; }

        [Display(Name = "Store Work Day Hour")]
        [Required(ErrorMessage = "Store Work Day Hour required")]
        public string StoreWorkDayHour { get; set; }

        [Display(Name = "Store Off Day Hour")]
        [Required(ErrorMessage = "Store Off Day Hour required")]
        public string StoreOffDayHour { get; set; }

        [Display(Name = "Store Button")]
        [Required(ErrorMessage = "Store Button required")]
        public string StoreButton { get; set; }

        [Display(Name = "Store Link")]
        [Required(ErrorMessage = "Store Link required")]
        public string StoreLink { get; set; }

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
