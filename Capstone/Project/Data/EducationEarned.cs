using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class EducationEarned
    {
        public EducationEarned()
        {
            Person = new HashSet<Person>();
        }

        [Column("EducationEarnedID")]
        public int EducationEarnedId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("EducationEarned")]
        public virtual ICollection<Person> Person { get; set; }
    }
}
