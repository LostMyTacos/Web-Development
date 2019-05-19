using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class BirthRecord
    {
        public BirthRecord()
        {
            NewBorn = new HashSet<NewBorn>();
        }

        [Column("BirthRecordID")]
        public int BirthRecordId { get; set; }
        public bool WasHomeBirth { get; set; }
        public bool WasPlannedHomeBirth { get; set; }
        [StringLength(100)]
        public string OtherBirthLocation { get; set; }
        public bool MaternalTransfusion { get; set; }
        public bool PerinealLaceration { get; set; }
        public bool RupturedUterus { get; set; }
        public bool UnplannedHysterectomy { get; set; }
        [Column("AdmitToICU")]
        public bool AdmitToIcu { get; set; }
        public bool UnplannedOperationPostDelivery { get; set; }
        [Column("PrenatalID")]
        public int PrenatalId { get; set; }
        [Column("FatherPersonID")]
        public int FatherPersonId { get; set; }
        [Column("AttendantID")]
        public int? AttendantId { get; set; }
        [Column("CertifierID")]
        public int? CertifierId { get; set; }
        [Column("FacilityID")]
        public int FacilityId { get; set; }
        [Column("FacilityTransferIDMom")]
        public int FacilityTransferIdmom { get; set; }
        [Column("PaymentTypeID")]
        public int PaymentTypeId { get; set; }
        [Required]
        [StringLength(450)]
        public string User { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EntryDate { get; set; }
        public bool Tocolysis { get; set; }
        public bool ExternalCephalic { get; set; }
        public bool PreRuptureMembrane { get; set; }
        public bool PrecipitousLabor { get; set; }
        public bool ProlongedLabor { get; set; }
        public bool InductionLabor { get; set; }
        public bool AugmentationLabor { get; set; }
        public bool NonVertex { get; set; }
        public bool Steroids { get; set; }
        public bool Antibiotics { get; set; }
        public bool Chorioamnoionitis { get; set; }
        public bool MeconiumStaining { get; set; }
        public bool Epidural { get; set; }

        [ForeignKey("AttendantId")]
        [InverseProperty("BirthRecord")]
        public virtual Attendant Attendant { get; set; }
        [ForeignKey("CertifierId")]
        [InverseProperty("BirthRecord")]
        public virtual Certifier Certifier { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("BirthRecordFacility")]
        public virtual Facility Facility { get; set; }
        [ForeignKey("FacilityTransferIdmom")]
        [InverseProperty("BirthRecordFacilityTransferIdmomNavigation")]
        public virtual Facility FacilityTransferIdmomNavigation { get; set; }
        [ForeignKey("FatherPersonId")]
        [InverseProperty("BirthRecord")]
        public virtual Person FatherPerson { get; set; }
        [ForeignKey("PaymentTypeId")]
        [InverseProperty("BirthRecord")]
        public virtual PaymentType PaymentType { get; set; }
        [ForeignKey("PrenatalId")]
        [InverseProperty("BirthRecord")]
        public virtual Prenatal Prenatal { get; set; }
        [InverseProperty("BirthRecord")]
        public virtual ICollection<NewBorn> NewBorn { get; set; }
    }
}
