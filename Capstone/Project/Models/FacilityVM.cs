using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class FacilityVM
    {

        [Required]
        [Display(Name = "Facility ID")]
        public int FacilityId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Facility Name")]
        public string FacilityName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Facility Number")]
        public string FacilityNumber { get; set; }

        [Required]
        [Display(Name = "Facility Type")]
        public int FacilityTypeId { get; set; }        
         
    }
}
