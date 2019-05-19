using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class Prenatal
    {
        public Prenatal()
        {
            BirthRecord = new HashSet<BirthRecord>();
        }

        [Column("PrenatalID")]
        public int PrenatalId { get; set; }
        [Column("PatientID")]
        public int PatientId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstPrenatal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastPrenatal { get; set; }
        [StringLength(50)]
        public string TotalPrenatal { get; set; }
        public int? MotherPreWeight { get; set; }
        public int? MotherDeliveryWeight { get; set; }
        public int? MotherPostWeight { get; set; }
        public bool HadWic { get; set; }
        [StringLength(50)]
        public string EstimateGestation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastMenstruation { get; set; }
        public byte? PreviousBirthLiving { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLiveBirth { get; set; }
        public int? OtherBirthOutcome { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastOtherOutcome { get; set; }
        public short? CigThreeMonthsBeforePregnancy { get; set; }
        [StringLength(50)]
        public string CigFirstThreeMonthsPregnancy { get; set; }
        [StringLength(50)]
        public string CigSecondThreeMonthsPregnancy { get; set; }
        [StringLength(50)]
        public string CigThirdTrimesterPregnancy { get; set; }
        public bool DiabetesPrePregnancy { get; set; }
        public bool DiabetesGestational { get; set; }
        public bool HypertensionPrePregnancy { get; set; }
        public bool HypertensionGestational { get; set; }
        public bool HypertensionEclampsia { get; set; }
        public bool PreviousPreTermBirth { get; set; }
        public bool PreviousPoorBirthOutcome { get; set; }
        public bool FertilityDrugUsed { get; set; }
        public bool AssistedTechUsed { get; set; }
        public bool PreviousCesarean { get; set; }
        public byte PreviousCesareanAmount { get; set; }
        public bool Gonorrhea { get; set; }
        public bool Syphilis { get; set; }
        public bool Chlamydia { get; set; }
        public bool HepB { get; set; }
        public bool HepC { get; set; }

        [ForeignKey("PatientId")]
        [InverseProperty("Prenatal")]
        public virtual Patient Patient { get; set; }
        [InverseProperty("Prenatal")]
        public virtual ICollection<BirthRecord> BirthRecord { get; set; }
    }
}
