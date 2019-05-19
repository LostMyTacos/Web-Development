using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class PatientVM
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        [StringLength(9)]
        [Display(Name = "Medical Record Number")]
        public string MedicalRecordNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Suffix { get; set; }


        [StringLength(50)]
        [Display(Name = "Prior First Name")]
        public string PriorFirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Prior Middle Name")]
        public string PriorMiddleName { get; set; }

        [StringLength(50)]
        [Display(Name = "Prior Last Name")]
        public string PriorLastName { get; set; }

        [StringLength(50)]
        [Display(Name = "Prior Suffix")]
        public string PriorSuffix { get; set; }

        [StringLength(6)]
        public string Gender { get; set; }

        [StringLength(50)]
        [Display(Name = "Resident Street Address 1")]
        public string ResidentStreetAddress { get; set; }

        [StringLength(10)]
        [Display(Name = "Resident Street Address 2")]
        public string ResidenceAptNo { get; set; }

        [StringLength(50)]
        [Display(Name = "Resident City")]
        public string ResidenceCity { get; set; }

        [StringLength(50)]
        [Display(Name = "Resident State")]
        public string ResidenceState { get; set; }

        [StringLength(10)]
        [Display(Name = "Resident Zip")]
        public string ResidenceZip { get; set; }

        [StringLength(11)]
        [Display(Name = "Social Security Number")]
        public string Ssn { get; set; }

        [Display(Name = "Date of Birth")]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? BirthDate { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        [Display(Name = "Married?")]
        public bool IsMarried { get; set; }

        [StringLength(150)]
        [Display(Name = "Place of Birth")]
        public string BirthPlace { get; set; }

        [Display(Name = "Lives in Resident City?")]
        public bool InCity { get; set; }

        [Display(Name = "Date Patient Created")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }

    }
}
