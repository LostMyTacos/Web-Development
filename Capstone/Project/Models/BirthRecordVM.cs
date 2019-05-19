using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class BirthRecordVM
    {
        // BirthRecord Table Properties
        [Display(Name = "Birth Record ID")]
        public int? BirthRecordID { get; set; }
        [Display(Name = "Facility ID")]
        public int? FacilityID { get; set; }
        [Display(Name = "Father ID")]
        public int? FatherPersonID { get; set; }
        [Display(Name = "Facility Transer ID for Mother")]
        public int? FacilityTransferIDMom { get; set; }
        [Display(Name = "Payment Type ID")]
        public int PaymentTypeID { get; set; } = 1;
        [Display(Name = "Was Home Birth")]
        public bool WasHomeBirth { get; set; } = false;
        [Display(Name = "Was Planned Home Birth")]
        public bool WasPlannedHomeBirth { get; set; } = false;
        [StringLength(100)]
        [Display(Name = "Other Birth Location")]
        public string OtherBirthLocation { get; set; } = "";
        [Display(Name = "Maternal Transfusion")]
        public bool MaternalTransfusion { get; set; } = false;
        [Display(Name = "Perineal Laceration")]
        public bool PerinealLaceration { get; set; } = false;
        [Display(Name = "Ruptured Uterus")]
        public bool RupturedUterus { get; set; } = false;
        [Display(Name = "Unplanned Hysterectomy")]
        public bool UnplannedHysterectomy { get; set; } = false;
        [Display(Name = "Admit to ICU")]
        public bool AdmitToICU { get; set; } = false;
        [Display(Name = "Unplanned Operation Post Delivery")]
        public bool UnplannedOperationPostDelivery { get; set; } = false;
        [StringLength(450)]
        [Display(Name = "Created By")]
        public string User { get; set; }
        [Display(Name = "Data Entry Date")]
        public DateTime EntryDate { get; set; } = DateTime.Now;
        [Display(Name = "Tocolysis")]
        public bool Tocolysis { get; set; } = false;
        [Display(Name = "External Cephalic")]
        public bool ExternalCephalic { get; set; } = false;
        [Display(Name = "Prerupture Membrane")]
        public bool PreRuptureMembrane { get; set; } = false;
        [Display(Name = "Precipitous Labor")]
        public bool PrecipitousLabor { get; set; } = false;
        [Display(Name = "Prolonged Labor")]
        public bool ProlongedLabor { get; set; } = false;
        [Display(Name = "Induction Labor")]
        public bool InductionLabor { get; set; } = false;
        [Display(Name = "Augmentation Labor")]
        public bool AugmentationLabor { get; set; } = false;
        [Display(Name = "Non-Vertex")]
        public bool NonVertex { get; set; } = false;
        [Display(Name = "Steroids")]
        public bool Steroids { get; set; } = false;
        [Display(Name = "Antibiotics")]
        public bool Antibotics { get; set; } = false;
        [Display(Name = "Chorioamnionitis")]
        public bool Chorioamnionitis { get; set; } = false;
        [Display(Name = "Meconium Staining")]
        public bool MeconiumStaining { get; set; } = false;
        [Display(Name = "Epidural")]
        public bool Epidural { get; set; } = false;

        // Newborn Person Data
        [Required]
        [StringLength(50)]
        [Display(Name = "Child First Name")]
        public string ChildFirstName { get; set; } = "Temp Child Name";
        [StringLength(50)]
        [Display(Name = "Child Middle Name")]
        public string ChildMiddleName { get; set; } = "";
        [Required]
        [StringLength(50)]
        [Display(Name = "Child Last Name")]
        public string ChildLastName { get; set; } = "Temp Child Name";
        [StringLength(10)]
        [Display(Name = "Child Suffix")]
        public string ChildSuffix { get; set; } = "";
        [StringLength(6)]
        [Display(Name = "Child Gender")]
        public string ChildGender { get; set; } = "";
        [Display(Name = "Child Date of Birth")]
        public DateTime ChildDOB { get; set; } = DateTime.Now;

        // Newborn Table
        [Display(Name = "New Born ID")]
        public int? NewBornID { get; set; }
        [Display(Name = "Baby Person ID")]
        public int? BabyPersonID { get; set; }
        [Display(Name = "Facility Transfer ID for Baby")]
        public int? FacilityTransferIDBaby { get; set; }
        [StringLength(50)]
        [Display(Name = "Infant Living")]
        public string InfantLiving { get; set; } = "";
        [Display(Name = "Breastfed")]
        public bool BreastFed { get; set; } = false;
        [Display(Name = "Birth Weight")]
        public int BirthWeight { get; set; } = 0;
        [StringLength(50)]
        [Display(Name = "Five Minute A.P.G.A.R. Score")]
        public string FiveMinApgarScore { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Ten Minute A.P.G.A.R. Score")]
        public string TenMinApgarScore { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Birth Order")]
        public string BirthOrder { get; set; } = "";
        [Display(Name = "Birth Time")]
        public DateTime BirthTime { get; set; }
        [Display(Name = "Paternity Acknowledgement")]
        public bool PaternityAck { get; set; } = false;
        [Display(Name = "SSN Requested")]
        public bool SsnRequested { get; set; } = false;
        [Display(Name = "Certified Date")]
        public DateTime CertifiedDate { get; set; } = DateTime.Now;
        [Display(Name = "Filed Date")]
        public DateTime FiledDate { get; set; } = DateTime.Now;
        [Display(Name = "Fetal Intolerance")]
        public bool FetalIntolerance { get; set; } = false;
        [Display(Name = "Unsuccessful Forceps")]
        public bool UnsuccessfulForceps { get; set; } = false;
        [Display(Name = "Unsuccessful Vacuum")]
        public bool UnsuccessfulVacuum { get; set; } = false;
        [Display(Name = "Presentation At Birth Cephalic")]
        public bool PresentationAtBirthCephalic { get; set; } = false;
        [Display(Name = "Presentation At Birth Breach")]
        public bool PresentationAtBirthBreach { get; set; } = false;
        [Display(Name = "Other Fetal Presenation")]
        public bool OtherFetalPresentation { get; set; } = false;
        [Display(Name = "Route Spontaneous")]
        public bool RouteSpontaneous { get; set; } = false;
        [Display(Name = "Route Forceps")]
        public bool RouteForcepts { get; set; } = false;
        [Display(Name = "Route Vacuum")]
        public bool RouteVacuum { get; set; } = false;
        [Display(Name = "Cesarean")]
        public bool Cesarean { get; set; } = false;
        [Display(Name = "Final Trial of Labor")]
        public bool FinalTrialOfLabor { get; set; } = false;
        [Display(Name = "Ven Immediate")]
        public bool VenImmediate { get; set; } = false;
        [Display(Name = "Ven Six Hours")]
        public bool VentSixHours { get; set; } = false;
        [Display(Name = "N.I.C.U.")]
        public bool Nicu { get; set; } = false;
        [Display(Name = "Surfactant")]
        public bool Surfactant { get; set; } = false;
        [Display(Name = "Neo-Natal Antibiotics")]
        public bool NeoNatalAntibotics { get; set; } = false;
        [Display(Name = "Seizure Dysfunction")]
        public bool SeizureDysfunction { get; set; } = false;
        [Display(Name = "Birth Injury")]
        public bool BirthInjury { get; set; } = false;
        [Display(Name = "Anencephaly")]
        public bool Anencephaly { get; set; } = false;
        [Display(Name = "Meningomyelocele")]
        public bool Meningomyelocele { get; set; } = false;
        [Display(Name = "Cyanotic")]
        public bool Cyanotic { get; set; } = false;
        [Display(Name = "Cogenital")]
        public bool Cogenital { get; set; } = false;
        [Display(Name = "Omphalocele")]
        public bool Omphalocele { get; set; } = false;
        [Display(Name = "Gastrochisis")]
        public bool Gastroschisis { get; set; } = false;
        [Display(Name = "Limb Reduction")]
        public bool LimbReduction { get; set; } = false;
        [Display(Name = "Cleft Lip")]
        public bool CleftLip { get; set; } = false;
        [Display(Name = "Cleft Palate")]
        public bool CleftPalate { get; set; } = false;
        [Display(Name = "Down Syndrome Confirmed")]
        public bool DownSyndromeConfirmed { get; set; } = false;
        [Display(Name = "Down Syndrome Pending")]
        public bool DownSyndromePending { get; set; } = false;
        [Display(Name = "Chromosomal Disorder Confirmed")]
        public bool ChromosomalDisorderConfirmed { get; set; } = false;
        [Display(Name = "Chromosomal Disorder Pending")]
        public bool ChromosomalDisorderPending { get; set; } = false;
        [Display(Name = "Hypospadias")]
        public bool Hypospadias { get; set; } = false;

        // Prenatal
        [Display(Name = "Prenatal ID")]
        public int? PrenatalID { get; set; }
        [Display(Name = "First Prenatal")]
        public DateTime? FirstPrenatal { get; set; }
        [Display(Name = "Last Prenatal")]
        public DateTime? LastPreNatal { get; set; }
        [StringLength(50)]
        [Display(Name = "Total Prenatal")]
        public string TotalPrenatal { get; set; } = "";
        [Display(Name = "Mother Pre Weight")]
        public int MotherPreWeight { get; set; } = 0;
        [Display(Name = "Mother Delivery Weight")]
        public int MotherDeliveryWeight { get; set; } = 0;
        [Display(Name = "Mother Post Weight")]
        public int MotherPostWeight { get; set; } = 0;
        [Display(Name = "Had W.I.C.")]
        public bool HadWic { get; set; } = false;
        [StringLength(50)]
        [Display(Name = "Estimate Gestation")]
        public string EstimateGestation { get; set; } = "";
        [Display(Name = "Date Last Menstruation")]
        public DateTime? DateLastMenstruation { get; set; }
        [Range(0, 10)]
        [Display(Name = "Previous Birth Living")]
        public int PreviousBirthLiving { get; set; } = 0;
        [Display(Name = "Last Live Birth")]
        public DateTime? LastLiveBirth { get; set; }
        [Display(Name = "Other Birth Outcome")]
        public int OtherBirthOutcome { get; set; } = 0;
        [Display(Name = "Last Other Outcome")]
        public DateTime? LastOtherOutcome { get; set; }
        [Range(0, 100)]
        [Display(Name = "Cigarette 3 Months Before Pregnancy")]
        public int CigThreeMonthsBeforePregnancy { get; set; } = 0;
        [StringLength(50)]
        [Display(Name = "Cigarette First 3 Months of Pregnancy")]
        public string CigFirstThreeMonthsPregnacy { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Cigarette Second 3 Months of Pregnancy")]
        public string CigSecondThreeMonthsPregnancy { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Cigarette Third 3 Months of Pregnancy")]
        public string CigThridTrimesterPregnancy { get; set; } = "";
        [Display(Name = "Diabetes Pre Pregnancy")]
        public bool DiabetesPrePregnancy { get; set; } = false;
        [Display(Name = "Diabetes Gestational")]
        public bool DiabetesGestational { get; set; } = false;
        [Display(Name = "Hypertension Pre Pregnancy")]
        public bool HypertensionPrePregnancy { get; set; } = false;
        [Display(Name = "Hypertension Gestational")]
        public bool HypertensionGestational { get; set; } = false;
        [Display(Name = "Hypertension Eclampsia")]
        public bool HypertensionEclampsia { get; set; } = false;
        [Display(Name = "Previous Pre Term Birth")]
        public bool PreviousPreTermBirth { get; set; } = false;
        [Display(Name = "Previous Poor Birth Outcome")]
        public bool PreviousPoorBirthOutcome { get; set; } = false;
        [Display(Name = "Fertility Drug Used")]
        public bool FertilityDrugUsed { get; set; } = false;
        [Display(Name = "Assisted Tech Used")]
        public bool AssistedTechUsed { get; set; } = false;
        [Display(Name = "Previous Cesarean")]
        public bool PreviousCesarean { get; set; } = false;
        [Display(Name = "Previous Cesarean Amount")]
        public int PreviousCesareanAmount { get; set; } = 0;
        [Display(Name = "Gonorrhea")]
        public bool Gonorrhea { get; set; } = false;
        [Display(Name = "Syphilis")]
        public bool Syphilis { get; set; } = false;
        [Display(Name = "Chlamydia")]
        public bool Chlamydia { get; set; } = false;
        [Display(Name = "Hep B")]
        public bool HepB { get; set; } = false;
        [Display(Name = "Hep C")]
        public bool HepC { get; set; } = false;

        // Patient
        [Key]
        [Display(Name = "Patient ID")]
        public int PatientID { get; set; }
        [StringLength(9)]
        [Display(Name = "Medical Record Number")]
        public string MedicalRecordNumber { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Display(Name = "Date Updated")]
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        // Person
        [Display(Name = "Person ID")]
        public int? PersonID { get; set; }
 
        public string MotherEducationEarnedName { get; set; }
        public string FatherEducationEarnedName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; } = "";
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(10)]
        [Display(Name = "Suffix")]
        public string Suffix { get; set; } = "";
        [StringLength(6)]
        [Display(Name = "Gender")]
        public string Gender { get; set; } = "Female";
        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }
        [StringLength(150)]
        [Display(Name = "Place of Birth")]
        public string BirthPlace { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "County of Birth")]
        public string BirthCounty { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Resident Street Address 1")]
        public string ResidentStreetAddress { get; set; } = "";
        [StringLength(10)]
        [Display(Name = "Resident Street Address 2")]
        public string ResidentAptNo { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Resident City")]
        public string ResidentCity { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Resident State")]
        public string ResidenceState { get; set; } = "";
        [StringLength(10)]
        [Display(Name = "Resident Zip")]
        public string ResidenceZip { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Mailing Street Address 1")]
        public string MailingStreetAddress { get; set; } = "";
        [StringLength(10)]
        [Display(Name = "Mailing Street Address 2")]
        public string MailingAptNo { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Mailing City")]
        public string MailingCity { get; set; } = "";
        [Display(Name = "Mailing State")]
        public string MailingState { get; set; } = "";
        [StringLength(10)]
        [Display(Name = "Mailing Zip")]
        public string MailingZip { get; set; } = "";
        [Display(Name = "Height (Inches)")]
        public int Height { get; set; } = 0;
        [Display(Name = "Weight (Pounds)")]
        public int Weight { get; set; } = 0;
        [Display(Name = "Is Married")]
        public bool IsMarried { get; set; } = false;
        [StringLength(50)]
        [Display(Name = "Prior First Name")]
        public string PriorFirstName { get; set; } = "";
        [Display(Name = "Prior Middle Name")]
        [StringLength(50)]
        public string PriorMiddleName { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Prior Last Name")]
        public string PriorLastName { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Prior Suffix")]
        public string PriorSuffix { get; set; } = "";
        [Display(Name = "In City")]
        public bool InCity { get; set; } = true;

        // Certifier
        [StringLength(50)]
        [Display(Name = "Certifier Name")]
        public string CertifierName { get; set; } = "";

        // Attendant
        [StringLength(50)]
        [Display(Name = "N.P.I.")]
        public string NPI { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; } = "";

        // PaymentType
        [StringLength(50)]
        [Display(Name = "Payment Source")]
        public string PaymentSource { get; set; } = "";

        // Facility
        [StringLength(50)]
        [Display(Name = "Facility Name")]
        public string FacilityName { get; set; } = "";
        [StringLength(50)]
        [Display(Name = "Facility Number")]
        public string FacilityNumber { get; set; } = "";

        // Facility Type
        [StringLength(50)]
        [Display(Name = "Birth Facility")]
        public string BirthFacility { get; set; } = "";

        // Father Person
        [Required]
        [StringLength(50)]
        [Display(Name = "Father First Name")]
        public string FatherFirstName { get; set; } = "Temp Father Name";
        [StringLength(50)]
        [Display(Name = "Father Middle Name")]
        public string FatherMiddleName { get; set; } = "";
        [Required]
        [StringLength(50)]
        [Display(Name = "Father Last Name")]
        public string FatherLastName { get; set; } = "Temp Father Name";
        [StringLength(10)]
        [Display(Name = "Father Suffix")]
        public string FatherSuffix { get; set; } = "";
        [Display(Name = "Father Place of Birth")]
        public string FatherBirthPlace { get; set; } = "";
        [Display(Name = "Father Date of Birth")]
        public DateTime? FatherDOB { get; set; }

        // Education dropdown
        public IEnumerable<SelectListItem> MotherEduDropDown { get; set; }
        public IEnumerable<SelectListItem> FatherEduDropDown { get; set; }

        // Mother Race
        public string motherHispanic { get; set; } = "No, not Spanish/Hispanic/Latina";
        public string motherHispanicOther { get; set; } = "";
        public bool motherWhite { get; set; } = false;
        public bool motherBlack { get; set; } = false;
        public bool motherHasTribe { get; set; } = false;
        public bool motherAsianIndian { get; set; } = false;
        public bool motherChinese { get; set; } = false;
        public bool motherFilipino { get; set; } = false;
        public bool motherJapanese { get; set; } = false;
        public bool motherKorean { get; set; } = false;
        public bool motherVietnamese { get; set; } = false;
        public bool motherIsAsian { get; set; } = false;
        public string motherOtherAsian { get; set; } = "";
        public bool motherHawaiian { get; set; } = false;
        public bool motherGuamanian { get; set; } = false;
        public bool motherSamoan { get; set; } = false;
        public bool motherIsIslander { get; set; } = false;
        public string motherOtherIslander { get; set; } = "";
        public bool motherIsOther { get; set; } = false;
        public string motherOtherRace { get; set; } = "";

        // father Race
        public string fatherHispanic { get; set; } = "No, not Spanish/Hispanic/Latina";
        public string fatherHispanicOther { get; set; } = "";
        public bool fatherWhite { get; set; } = false;
        public bool fatherBlack { get; set; } = false;
        public bool fatherHasTribe { get; set; } = false;
        public bool fatherAsianIndian { get; set; } = false;
        public bool fatherChinese { get; set; } = false;
        public bool fatherFilipino { get; set; } = false;
        public bool fatherJapanese { get; set; } = false;
        public bool fatherKorean { get; set; } = false;
        public bool fatherVietnamese { get; set; } = false;
        public bool fatherIsAsian { get; set; } = false;
        public string fatherOtherAsian { get; set; } = "";
        public bool fatherHawaiian { get; set; } = false;
        public bool fatherGuamanian { get; set; } = false;
        public bool fatherSamoan { get; set; } = false;
        public bool fatherIsIslander { get; set; } = false;
        public string fatherOtherIslander { get; set; } = "";
        public bool fatherIsOther { get; set; } = false;
        public string fatherOtherRace { get; set; } = "";

    }
}
