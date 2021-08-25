using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class CompanyDetailsModel
    {
        [Key]
        public int CompanyDetailsID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name required")]
        public string CompanyName {get; set;}

        [Display(Name = "Company Logo")]
        [Required(ErrorMessage = "Company Logo required")]
        public string CompanyLogo { get; set;}

        [Display(Name = "Company Image")]
        [Required(ErrorMessage = "Company Image required")]
        public string CompanyImage { get; set;}

        [Display(Name = "Company Moto")]
        [Required(ErrorMessage = "Company Moto required")]
        public string CompanyMoto { get; set;}

        [Display(Name = "Company Email")]
        [Required(ErrorMessage = "Company Email required")]
        public string CompanyEmail { get; set;}

        [Display(Name = "Company MobileNo")]
        [Required(ErrorMessage = "Company MobileNo required")]
        public string CompanyMobileNo { get; set;}

        [Display(Name = "Company Address")]
        [Required(ErrorMessage = "Company Address required")]
        public string CompanyAddress { get; set;}

        [Display(Name = "Copyright Text")]
        [Required(ErrorMessage = "Copyright Text required")]
        public string CopyrightText { get; set;}

        [Display(Name = "CustomerSupport")]
        [Required(ErrorMessage = "CustomerSupport required")]
        public string CustomerSupport { get; set;}

        [Display(Name = "Facebook Link")]
        [Required(ErrorMessage = "Facebook Link required")]
        public string FacebookLink { get; set;}

        [Display(Name = "WhatsApp Link")]
        [Required(ErrorMessage = "WhatsApp Link required")]
        public string WhatsAppLink { get; set;}

        [Display(Name = "Instagram Link")]
        [Required(ErrorMessage = "Instagram Link required")]
        public string InstagramLink { get; set;}

        [Display(Name = "Linkdin Link")]
        [Required(ErrorMessage = "Linkdin Link required")]
        public string LinkdinLink { get; set;}

        [Display(Name = "Youtube Link")]
        [Required(ErrorMessage = "Youtube Link required")]
        public string YoutubeLink { get; set;}

        [Display(Name = "Working Day")]
        [Required(ErrorMessage = "Working Day required")]
        public string WorkingDay { get; set; }

        [Display(Name = "Working Hour")]
        [Required(ErrorMessage = "Working Hour required")]
        public string WorkingHour { get; set; }

        [Display(Name = "Off Day")]
        [Required(ErrorMessage = "Off Day required")]
        public string OffDay { get; set; }

        [Display(Name = "Off Hours")]
        [Required(ErrorMessage = "Off Hours required")]
        public string OffHours { get; set; }

        [Display(Name = "CreatedBy Name")]
        [Required(ErrorMessage = "CreatedBy Name required")]
        public string CreatedBy { get; set;}

        [Display(Name = "CreatedDate")]
        [Required(ErrorMessage = "CreatedDate required")]
        public DateTime CreatedDate { get; set;}

        [Display(Name = "AddedBy Name")]
        [Required(ErrorMessage = "AddedBy Name required")]
        public string AddedBy { get; set;}

        [Display(Name = "AddedDate")]
        [Required(ErrorMessage = "AddedDate required")]
        public DateTime AddedDate { get; set;} 
    }
}
