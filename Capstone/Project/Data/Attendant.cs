using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Attendant
    {
        public Attendant()
        {
            BirthRecord = new HashSet<BirthRecord>();
        }

        [Column("AttendantID")]
        public int AttendantId { get; set; }
        [Column("PersonID")]
        public int PersonId { get; set; }
        [Column("NPI")]
        [StringLength(50)]
        public string Npi { get; set; }
        [StringLength(50)]
        public string JobTitle { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Attendant")]
        public virtual Person Person { get; set; }
        [InverseProperty("Attendant")]
        public virtual ICollection<BirthRecord> BirthRecord { get; set; }
    }
}
