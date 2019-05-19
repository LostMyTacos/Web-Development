using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Person
    {
        public Person()
        {
            Attendant = new HashSet<Attendant>();
            BirthRecord = new HashSet<BirthRecord>();
            Certifier = new HashSet<Certifier>();
            NewBorn = new HashSet<NewBorn>();
            Patient = new HashSet<Patient>();
            Race = new HashSet<Race>();
        }

        [Column("PersonID")]
        public int PersonId { get; set; }
        [Column("EducationEarnedID")]
        public int EducationEarnedId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("MiddleName ")]
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Suffix { get; set; }
        [StringLength(6)]
        public string Gender { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(150)]
        public string BirthPlace { get; set; }
        [StringLength(50)]
        public string BirthCounty { get; set; }
        [StringLength(50)]
        public string ResidentStreetAddress { get; set; }
        [StringLength(10)]
        public string ResidenceAptNo { get; set; }
        [StringLength(50)]
        public string ResidenceCity { get; set; }
        [StringLength(50)]
        public string ResidenceState { get; set; }
        [Column("ResidenceZIP")]
        [StringLength(10)]
        public string ResidenceZip { get; set; }
        [StringLength(50)]
        public string MailingStreetAddress { get; set; }
        [StringLength(10)]
        public string MailingAptNo { get; set; }
        [StringLength(50)]
        public string MailingCity { get; set; }
        [StringLength(10)]
        public string MailingZip { get; set; }
        [Column("SSN")]
        [StringLength(11)]
        public string Ssn { get; set; }
        [Column("MotherSSn")]
        [StringLength(11)]
        public string MotherSsn { get; set; }
        [Column("FatherSSN")]
        [StringLength(11)]
        public string FatherSsn { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public bool IsMarried { get; set; }
        [StringLength(50)]
        public string PriorFirstName { get; set; }
        [StringLength(50)]
        public string PriorMiddleName { get; set; }
        [StringLength(50)]
        public string PriorLastName { get; set; }
        [StringLength(50)]
        public string PriorSuffix { get; set; }
        public bool InCity { get; set; }
        [StringLength(50)]
        public string ResidenceCountry { get; set; }

        [ForeignKey("EducationEarnedId")]
        [InverseProperty("Person")]
        public virtual EducationEarned EducationEarned { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Attendant> Attendant { get; set; }
        [InverseProperty("FatherPerson")]
        public virtual ICollection<BirthRecord> BirthRecord { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Certifier> Certifier { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<NewBorn> NewBorn { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Patient> Patient { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Race> Race { get; set; }
    }
}
