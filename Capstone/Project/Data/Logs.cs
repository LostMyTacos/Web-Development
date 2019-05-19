using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Logs
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EventDateTime { get; set; }
        [Required]
        [StringLength(100)]
        public string EventLevel { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string MachineName { get; set; }
        [Required]
        public string EventMessage { get; set; }
        [StringLength(100)]
        public string ErrorSource { get; set; }
        [StringLength(500)]
        public string ErrorClass { get; set; }
        public string ErrorMethod { get; set; }
        public string ErrorMessage { get; set; }
        public string InnerErrorMessage { get; set; }
    }
}
