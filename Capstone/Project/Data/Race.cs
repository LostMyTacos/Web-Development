using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Race
    {
        [Column("RaceID")]
        public int RaceId { get; set; }
        [Column("PersonID")]
        public int PersonId { get; set; }
        [StringLength(255)]
        public string Hispanic { get; set; }
        public bool White { get; set; }
        public bool Black { get; set; }
        public bool Indian { get; set; }
        [StringLength(50)]
        public string Tribe { get; set; }
        public bool AsianIndian { get; set; }
        public bool Chinese { get; set; }
        public bool Filipino { get; set; }
        public bool Japanese { get; set; }
        public bool Korean { get; set; }
        public bool Vietnamese { get; set; }
        [StringLength(50)]
        public string OtherAsian { get; set; }
        public bool Hawaiian { get; set; }
        public bool Guamarian { get; set; }
        public bool Samoan { get; set; }
        [StringLength(50)]
        public string PacificIslander { get; set; }
        [StringLength(50)]
        public string Other { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Race")]
        public virtual Person Person { get; set; }
    }
}
