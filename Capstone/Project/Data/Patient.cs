using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Patient
    {
        public Patient()
        {
            Prenatal = new HashSet<Prenatal>();
        }

        [Column("PatientID")]
        public int PatientId { get; set; }
        [Column("PersonID")]
        public int PersonId { get; set; }
        [Required]
        [StringLength(9)]
        public string MedicalRecordNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateUpdated { get; set; }
        [StringLength(450)]
        public string EditedBy { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Patient")]
        public virtual Person Person { get; set; }
        [InverseProperty("Patient")]
        public virtual ICollection<Prenatal> Prenatal { get; set; }
    }
}
