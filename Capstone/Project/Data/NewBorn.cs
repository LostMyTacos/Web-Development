using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data
{
    public partial class NewBorn
    {
        [Column("NewBornID")]
        public int NewBornId { get; set; }
        [Column("PersonID")]
        public int PersonId { get; set; }
        [Column("BirthRecordID")]
        public int BirthRecordId { get; set; }
        [Column("FacilityTransferIDBaby")]
        public int FacilityTransferIdbaby { get; set; }
        [StringLength(50)]
        public string InfantLiving { get; set; }
        public bool BreastFed { get; set; }
        public int? BirthWeight { get; set; }
        [StringLength(50)]
        public string FiveMinApgarScore { get; set; }
        [StringLength(50)]
        public string TenMinApgarScore { get; set; }
        [StringLength(50)]
        public string BirthOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BirthTime { get; set; }
        public bool PaternityAck { get; set; }
        public bool SsnRequested { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CertifiedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FiledDate { get; set; }
        public bool FetalIntolerance { get; set; }
        public bool UnsuccessfulForceps { get; set; }
        public bool UnsuccessfulVacuum { get; set; }
        public bool PresentationAtBirthCephalic { get; set; }
        public bool PresentationAtBirthBreach { get; set; }
        public bool OtherFetalPresentation { get; set; }
        public bool RouteSpontaneous { get; set; }
        public bool RouteForceps { get; set; }
        public bool RouteVacuum { get; set; }
        public bool Cesarean { get; set; }
        public bool FinalTrialOfLabor { get; set; }
        public bool VenImmediate { get; set; }
        public bool VentSixHours { get; set; }
        public bool Nicu { get; set; }
        public bool Surfactant { get; set; }
        public bool NeoNatalAntibotics { get; set; }
        public bool SeizureDysfunction { get; set; }
        public bool BirthInjury { get; set; }
        public bool Anencephaly { get; set; }
        public bool Meningomyelocele { get; set; }
        public bool Cyanotic { get; set; }
        public bool Congenital { get; set; }
        public bool Omphalocele { get; set; }
        public bool Gastoschisis { get; set; }
        public bool LimbReductin { get; set; }
        public bool CleftLip { get; set; }
        public bool CleftPalate { get; set; }
        public bool DownSyndromeConfirmed { get; set; }
        public bool DownSyndromePending { get; set; }
        public bool ChromosomalDisorderConfirmed { get; set; }
        public bool ChromosomalDisorderPending { get; set; }
        public bool Hypospadias { get; set; }

        [ForeignKey("BirthRecordId")]
        [InverseProperty("NewBorn")]
        public virtual BirthRecord BirthRecord { get; set; }
        [ForeignKey("FacilityTransferIdbaby")]
        [InverseProperty("NewBorn")]
        public virtual Facility FacilityTransferIdbabyNavigation { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("NewBorn")]
        public virtual Person Person { get; set; }
    }
}
