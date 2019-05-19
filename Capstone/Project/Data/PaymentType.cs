using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            BirthRecord = new HashSet<BirthRecord>();
        }

        [Column("PaymentTypeID")]
        public int PaymentTypeId { get; set; }
        [StringLength(50)]
        public string PaymentSource { get; set; }

        [InverseProperty("PaymentType")]
        public virtual ICollection<BirthRecord> BirthRecord { get; set; }
    }
}
