using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Certifier
    {
        public Certifier()
        {
            BirthRecord = new HashSet<BirthRecord>();
        }

        [Column("CertifierID")]
        public int CertifierId { get; set; }
        [Column("PersonID")]
        public int PersonId { get; set; }
        [StringLength(50)]
        public string CertifierName { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Certifier")]
        public virtual Person Person { get; set; }
        [InverseProperty("Certifier")]
        public virtual ICollection<BirthRecord> BirthRecord { get; set; }
    }
}
