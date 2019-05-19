using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class FacilityType
    {
        public FacilityType()
        {
            Facility = new HashSet<Facility>();
        }

        public FacilityType(string type)
        {
            TypeDescription = type;
        }

        [Column("FacilityTypeID")]
        public int FacilityTypeId { get; set; }
        [StringLength(50)]
        public string TypeDescription { get; set; }

        [InverseProperty("FacilityType")]
        public virtual ICollection<Facility> Facility { get; set; }
    }
}
