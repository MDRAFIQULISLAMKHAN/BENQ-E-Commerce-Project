using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Models
{
    public class BannerModel
    {
        [Key]
        public int BannerID { get; set; }

        [Display(Name = "Banner Image")]
        [Required(ErrorMessage ="Banner Image required")]
        public string BannerImage { get; set; }

        [Display(Name = "Banner Title")]
        [Required(ErrorMessage = "Banner Title required")]
        public string BannerTitle { get; set; }

        [Display(Name = "Banner SubTitle")]
        [Required(ErrorMessage = "Banner SubTitle required")]
        public string BannerSubTitle { get; set; }

        [Display(Name = "Banner Button")]
        [Required(ErrorMessage = "Banner Button required")]
        public string BannerButton { get; set; }

        [Display(Name = "Button Link")]
        [Required(ErrorMessage = "Button Link required")]
        public string ButtonLink { get; set; }

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
        public string AddedDate { get; set; }
    }
}
