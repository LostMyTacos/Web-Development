using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Facility
    {
        public Facility()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            BirthRecordFacility = new HashSet<BirthRecord>();
            BirthRecordFacilityTransferIdmomNavigation = new HashSet<BirthRecord>();
            NewBorn = new HashSet<NewBorn>();
        }
        public Facility(string name, string number, int type)
        {
            FacilityName = name;
            FacilityNumber = number;
            FacilityTypeId = type;
        }

        [Column("FacilityID")]
        public int FacilityId { get; set; }
        [Required]
        [StringLength(100)]
        public string FacilityName { get; set; }
        [StringLength(50)]
        public string FacilityNumber { get; set; }
        [Column("FacilityTypeID")]
        public int FacilityTypeId { get; set; }

        [ForeignKey("FacilityTypeId")]
        [InverseProperty("Facility")]
        public virtual FacilityType FacilityType { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<BirthRecord> BirthRecordFacility { get; set; }
        [InverseProperty("FacilityTransferIdmomNavigation")]
        public virtual ICollection<BirthRecord> BirthRecordFacilityTransferIdmomNavigation { get; set; }
        [InverseProperty("FacilityTransferIdbabyNavigation")]
        public virtual ICollection<NewBorn> NewBorn { get; set; }
    }
}
