using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Data;
using Project.Helpers;
using Project.Models;
using System;
using System.Linq;


namespace Project.Controllers
{

    [Authorize]
    public class BirthRecordsController : Controller
    {
        private readonly HITProjectDataEntities DB;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private ILogger<PatientsController> logger;

        public BirthRecordsController(
            HITProjectDataEntities context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<PatientsController> log)
        {
            DB = context;
            _userManager = userManager;
            _signInManager = signInManager;
            logger = log;
        }
 
        // GET: birthRecords
        public ActionResult Index()
        {
            return View(DB.BirthRecord.ToList());
        }



        // GET: BirthRecords/Create
        public ActionResult Create(int? id)
        {
            if (User.IsInRole("Disabled"))
            {
                ViewBag.isDisabled = true;
            }

            // Get Patient Info
            Patient Patient = DB.Patient.Include("Person").Where(x => x.PatientId == id).FirstOrDefault();
            // Get Application User Info
            var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User));

            if (Patient == null)
            {
                ViewBag.patientFound = false;
                RedirectToAction("PatientLookup", "patients");
            }
            //To create a dropdown in view with values from Database.
            //Since not over abusing ViewBag yet, will keep should consider a view model if time permits.
            BirthRecordVM Record = new BirthRecordVM
            {
                MotherEduDropDown = UIHelpers.BuildDownDownFromTable(DB, "EducationEarned", "Name", "Name", Patient.Person.EducationEarnedId.ToString()),
                FatherEduDropDown = UIHelpers.BuildDownDownFromTable(DB, "EducationEarned", "Name", "Name"),
                // Patient
                PatientID = Patient.PatientId,
                MedicalRecordNumber = Patient.MedicalRecordNumber,
                DateUpdated = DateTime.Now,
                // Person
                MotherEducationEarnedName = DB.EducationEarned.Where(x => x.EducationEarnedId == Patient.Person.EducationEarnedId).First().Name,
                FirstName = Patient.Person.FirstName,
                MiddleName = Patient.Person.MiddleName,
                LastName = Patient.Person.LastName,
                Suffix = Patient.Person.Suffix,
                Gender = Patient.Person.Gender,
                BirthDate = Patient.Person.BirthDate.Value,
                BirthPlace = Patient.Person.BirthPlace,
                BirthCounty = Patient.Person.BirthCounty,
                ResidentStreetAddress = Patient.Person.ResidentStreetAddress,
                ResidentAptNo = Patient.Person.ResidenceAptNo,
                ResidentCity = Patient.Person.ResidenceCity,
                ResidenceState = Patient.Person.ResidenceState,
                ResidenceZip = Patient.Person.ResidenceZip,
                MailingStreetAddress = Patient.Person.MailingStreetAddress,
                MailingAptNo = Patient.Person.MailingAptNo,
                MailingCity = Patient.Person.MailingCity,
                // mailing state missing //MailingState = Patient.Person.
                MailingZip = Patient.Person.MailingZip,
                Height = Patient.Person.Height ?? 0,
                Weight = Patient.Person.Weight ?? 0,
                IsMarried = Patient.Person.IsMarried,
                PriorFirstName = Patient.Person.PriorFirstName,
                PriorMiddleName = Patient.Person.PriorMiddleName,
                PriorLastName = Patient.Person.PriorLastName,
                PriorSuffix = Patient.Person.PriorSuffix,
                InCity = Patient.Person.InCity,

                BirthTime = DateTime.Now,
                User = UserValues.First().FirstName + " " + UserValues.First().LastName,
                //FatherFirstName = " ",
                //FatherLastName = " ",
            };

            return View("Create", Record);
        }

        // POST: BirthRecords/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BirthRecordVM bRecord)
        {
            var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User));
            Patient Patient = DB.Patient.Include("Person").Where(x => x.PatientId == bRecord.PatientID).FirstOrDefault();
            if (ModelState.IsValid)
            {
                //Patient Patient = DB.Patient.Include("Person").Where(x => x.PatientId == bRecord.PatientID).FirstOrDefault();
                if (Patient != null)
                {
                    try
                    {
                        // Update Patient Table with changes from form
                        Patient.DateUpdated = DateTime.Now;
                        Patient.MedicalRecordNumber = bRecord.MedicalRecordNumber;

                        // Update Person Table with changes from form
                        Patient.Person.EducationEarnedId = DB.EducationEarned.Where(x => x.Name == bRecord.MotherEducationEarnedName).First().EducationEarnedId;
                        Patient.Person.FirstName = bRecord.FirstName;
                        Patient.Person.MiddleName = bRecord.MiddleName;
                        Patient.Person.LastName = bRecord.LastName;
                        Patient.Person.Suffix = bRecord.Suffix;
                        Patient.Person.Gender = bRecord.Gender;
                        Patient.Person.BirthDate = bRecord.BirthDate;
                        Patient.Person.BirthPlace = bRecord.BirthPlace;
                        Patient.Person.BirthCounty = bRecord.BirthCounty;
                        Patient.Person.ResidentStreetAddress = bRecord.ResidentStreetAddress;
                        Patient.Person.ResidenceAptNo = bRecord.ResidentAptNo;
                        Patient.Person.ResidenceCity = bRecord.ResidentCity;
                        Patient.Person.ResidenceState = bRecord.ResidenceState;
                        Patient.Person.ResidenceZip = bRecord.ResidenceZip;
                        Patient.Person.MailingStreetAddress = bRecord.MailingStreetAddress;
                        Patient.Person.MailingAptNo = bRecord.MailingAptNo;
                        Patient.Person.MailingCity = bRecord.MailingCity;
                        // mailing state missing?
                        Patient.Person.MailingZip = bRecord.MailingZip;
                        Patient.Person.Height = bRecord.Height;
                        Patient.Person.Weight = bRecord.Weight;
                        Patient.Person.IsMarried = bRecord.IsMarried;
                        Patient.Person.PriorFirstName = bRecord.PriorFirstName;
                        Patient.Person.PriorMiddleName = bRecord.PriorMiddleName;
                        Patient.Person.PriorLastName = bRecord.PriorLastName;
                        Patient.Person.PriorSuffix = bRecord.PriorSuffix;
                        Patient.Person.InCity = bRecord.InCity;

                        DB.SaveChanges();

                        // Father Person
                        var fatherPerson = new Person
                        {
                            EducationEarnedId = DB.EducationEarned.Where(x => x.Name == bRecord.FatherEducationEarnedName).First().EducationEarnedId,
                            FirstName = bRecord.FatherFirstName,
                            MiddleName = bRecord.FatherMiddleName,
                            LastName = bRecord.FatherLastName,
                            Suffix = bRecord.FatherSuffix,
                            Gender = "Male",
                            BirthDate = bRecord.FatherDOB,
                            BirthPlace = bRecord.FatherBirthPlace
                        };
                        DB.Person.Add(fatherPerson);
                        DB.SaveChanges();

                        var fatherRace = new Race
                        {
                            PersonId = fatherPerson.PersonId,
                            White = bRecord.fatherWhite,
                            Black = bRecord.fatherBlack,
                            Indian = bRecord.fatherHasTribe,
                            AsianIndian = bRecord.fatherAsianIndian,
                            Chinese = bRecord.fatherChinese,
                            Filipino = bRecord.fatherFilipino,
                            Japanese = bRecord.fatherJapanese,
                            Korean = bRecord.fatherKorean,
                            Vietnamese = bRecord.fatherVietnamese,
                            OtherAsian = bRecord.fatherOtherAsian,
                            Hawaiian = bRecord.fatherHawaiian,
                            Guamarian = bRecord.fatherGuamanian,
                            Samoan = bRecord.fatherSamoan,
                            Other = bRecord.fatherOtherRace
                        };
                        DB.Race.Add(fatherRace);
                        DB.SaveChanges();

                        // Create Prenatal
                        var prenatal = new Prenatal
                        {
                            PatientId = bRecord.PatientID,
                            FirstPrenatal = bRecord.FirstPrenatal,
                            LastPrenatal = bRecord.LastPreNatal,
                            TotalPrenatal = bRecord.TotalPrenatal,
                            MotherPreWeight = bRecord.MotherPreWeight,
                            MotherDeliveryWeight = bRecord.MotherDeliveryWeight,
                            MotherPostWeight = bRecord.MotherPostWeight,
                            HadWic = bRecord.HadWic,
                            EstimateGestation = bRecord.EstimateGestation,
                            DateLastMenstruation = bRecord.DateLastMenstruation,
                            PreviousBirthLiving = (byte)bRecord.PreviousBirthLiving,
                            LastLiveBirth = bRecord.LastLiveBirth,
                            OtherBirthOutcome = bRecord.OtherBirthOutcome,
                            LastOtherOutcome = bRecord.LastOtherOutcome,
                            CigThreeMonthsBeforePregnancy = (short)bRecord.CigThreeMonthsBeforePregnancy,
                            CigFirstThreeMonthsPregnancy = bRecord.CigFirstThreeMonthsPregnacy,
                            CigSecondThreeMonthsPregnancy = bRecord.CigSecondThreeMonthsPregnancy,
                            CigThirdTrimesterPregnancy = bRecord.CigThridTrimesterPregnancy,
                            DiabetesPrePregnancy = bRecord.DiabetesPrePregnancy,
                            DiabetesGestational = bRecord.DiabetesGestational,
                            HypertensionPrePregnancy = bRecord.HypertensionPrePregnancy,
                            HypertensionGestational = bRecord.HypertensionGestational,
                            HypertensionEclampsia = bRecord.HypertensionEclampsia,
                            PreviousPreTermBirth = bRecord.PreviousPreTermBirth,
                            PreviousPoorBirthOutcome = bRecord.PreviousPoorBirthOutcome,
                            FertilityDrugUsed = bRecord.FertilityDrugUsed,
                            AssistedTechUsed = bRecord.AssistedTechUsed,
                            PreviousCesarean = bRecord.PreviousCesarean,
                            PreviousCesareanAmount = (byte)bRecord.PreviousCesareanAmount,
                            Gonorrhea = bRecord.Gonorrhea,
                            Syphilis = bRecord.Syphilis,
                            Chlamydia = bRecord.Chlamydia,
                            HepB = bRecord.HepB,
                            HepC = bRecord.HepC,
                        };

                        DB.Prenatal.Add(prenatal);                  
                        DB.SaveChanges();

                        // Create BirthRecord
                        var birthRecord = new BirthRecord
                        {
                            WasHomeBirth = bRecord.WasHomeBirth,
                            WasPlannedHomeBirth = bRecord.WasPlannedHomeBirth,
                            OtherBirthLocation = bRecord.OtherBirthLocation,
                            MaternalTransfusion = bRecord.MaternalTransfusion,
                            PerinealLaceration = bRecord.PerinealLaceration,
                            RupturedUterus = bRecord.RupturedUterus,
                            UnplannedHysterectomy = bRecord.UnplannedHysterectomy,
                            AdmitToIcu = bRecord.AdmitToICU,
                            UnplannedOperationPostDelivery = bRecord.UnplannedOperationPostDelivery,
                            PrenatalId = prenatal.PrenatalId,
                            // Facility Hardcoded right now
                            FacilityId = 11,
                            // Father HardCoded right now
                            FatherPersonId = fatherPerson.PersonId,
                            // FacilityTransferIDMOM What does that even mean?
                            FacilityTransferIdmom = 11, // Can I set it to the Facility ID?
                            User = UserValues.First().FirstName + " " + UserValues.First().LastName,
                            PaymentTypeId = 1,
                            EntryDate = DateTime.Now,
                            Tocolysis = bRecord.Tocolysis,
                            ExternalCephalic = bRecord.ExternalCephalic,
                            PreRuptureMembrane = bRecord.PreRuptureMembrane,
                            PrecipitousLabor = bRecord.PrecipitousLabor,
                            ProlongedLabor = bRecord.ProlongedLabor,
                            InductionLabor = bRecord.InductionLabor,
                            AugmentationLabor = bRecord.AugmentationLabor,
                            NonVertex = bRecord.NonVertex,
                            Steroids = bRecord.Steroids,
                            Antibiotics = bRecord.Antibotics,
                            Chorioamnoionitis = bRecord.Chorioamnionitis,
                            MeconiumStaining = bRecord.MeconiumStaining,
                            Epidural = bRecord.Epidural,

                        };
                        DB.BirthRecord.Add(birthRecord);
                        DB.SaveChanges();

                        // Baby - Person
                        var newBornPerson = new Person
                        {
                            EducationEarnedId = 1,
                            FirstName = bRecord.ChildFirstName,
                            MiddleName = bRecord.ChildMiddleName,
                            LastName = bRecord.ChildLastName,
                            Suffix = bRecord.ChildSuffix,
                            BirthDate = bRecord.ChildDOB,
                            IsMarried = false,
                            InCity = true,
                            Gender = bRecord.ChildGender,

                        };
                        DB.Person.Add(newBornPerson);
                        DB.SaveChanges();

                        var babyRace = new Race
                        {
                            PersonId = newBornPerson.PersonId,
                            Hispanic = null,
                            White = false,
                            Black = false,
                            Indian = false,
                            AsianIndian = false,
                            Chinese = false,
                            Filipino = false,
                            Japanese = false,
                            Korean = false,
                            Vietnamese = false,
                            Hawaiian = false,
                            Guamarian = false,
                            Samoan = false
                        };
                        DB.Race.Add(babyRace);
                        DB.SaveChanges();

                        // NewBorn
                        var newBorn = new NewBorn
                        {
                            PersonId = newBornPerson.PersonId,
                            BirthRecordId = birthRecord.BirthRecordId,
                            FacilityTransferIdbaby = 11,
                            InfantLiving = bRecord.InfantLiving,
                            BreastFed = bRecord.BreastFed,
                            BirthWeight = bRecord.BirthWeight,
                            FiveMinApgarScore = bRecord.FiveMinApgarScore,
                            TenMinApgarScore = bRecord.TenMinApgarScore,
                            BirthOrder = bRecord.BirthOrder,
                            BirthTime = bRecord.ChildDOB,
                            PaternityAck = bRecord.PaternityAck,
                            SsnRequested = bRecord.SsnRequested,
                            CertifiedDate = bRecord.CertifiedDate,
                            FiledDate = bRecord.FiledDate,
                            FetalIntolerance = bRecord.FetalIntolerance,
                            UnsuccessfulForceps = bRecord.UnsuccessfulForceps,
                            UnsuccessfulVacuum = bRecord.UnsuccessfulVacuum,
                            PresentationAtBirthCephalic = bRecord.PresentationAtBirthCephalic,
                            PresentationAtBirthBreach = bRecord.PresentationAtBirthBreach,
                            OtherFetalPresentation = bRecord.OtherFetalPresentation,
                            RouteSpontaneous = bRecord.RouteSpontaneous,
                            RouteForceps = bRecord.RouteForcepts,
                            RouteVacuum = bRecord.RouteVacuum,
                            Cesarean = bRecord.Cesarean,
                            FinalTrialOfLabor = bRecord.FinalTrialOfLabor,
                            VenImmediate = bRecord.VenImmediate,
                            Nicu = bRecord.Nicu,
                            Surfactant = bRecord.Surfactant,
                            NeoNatalAntibotics = bRecord.NeoNatalAntibotics,
                            SeizureDysfunction = bRecord.SeizureDysfunction,
                            BirthInjury = bRecord.BirthInjury,
                            Anencephaly = bRecord.Anencephaly,
                            Meningomyelocele = bRecord.Meningomyelocele,
                            Cyanotic = bRecord.Cyanotic,
                            Congenital = bRecord.Cogenital,
                            Omphalocele = bRecord.Omphalocele,
                            Gastoschisis = bRecord.Gastroschisis,
                            LimbReductin = bRecord.LimbReduction,
                            CleftLip = bRecord.CleftLip,
                            CleftPalate = bRecord.CleftPalate,
                            DownSyndromeConfirmed = bRecord.DownSyndromeConfirmed,
                            DownSyndromePending = bRecord.DownSyndromePending,
                            ChromosomalDisorderConfirmed = bRecord.ChromosomalDisorderConfirmed,
                            ChromosomalDisorderPending = bRecord.ChromosomalDisorderPending,
                            Hypospadias = bRecord.Hypospadias,
                        };

                        DB.NewBorn.Add(newBorn);
                        DB.SaveChanges();                       
                    }
                    catch
                    {
                        return View("Create", bRecord); ;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Patients");
                }
            }
            return RedirectToAction("Details","Patients",new { id=Patient.PatientId});
        }

        // GET: birthRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User));
            var theBirthRecord = DB.BirthRecord.Where(x => x.BirthRecordId == id).FirstOrDefault();
            var theNewBorn = DB.NewBorn.Where(x => x.BirthRecordId == theBirthRecord.BirthRecordId).FirstOrDefault();
            var theNewBornPerson = DB.Person.Where(x => x.PersonId == theNewBorn.PersonId).FirstOrDefault();
            var thePrenatal = DB.Prenatal.Where(x => x.PrenatalId == theBirthRecord.PrenatalId).FirstOrDefault();
            var thePatient = DB.Patient.Where(x => x.PatientId == thePrenatal.PatientId).FirstOrDefault();
            var theMother = DB.Person.Where(x => x.PersonId == thePatient.PersonId).FirstOrDefault();
            var theFather = DB.Person.Where(x => x.PersonId == theBirthRecord.FatherPersonId).FirstOrDefault();
            var motherRace = DB.Race.Where(x => x.PersonId == theMother.PersonId).FirstOrDefault();

            var bRecord = new BirthRecordVM
            {
                MotherEduDropDown = UIHelpers.BuildDownDownFromTable(DB, "EducationEarned", "Name", "Name", theMother.EducationEarnedId.ToString()),
                FatherEduDropDown = UIHelpers.BuildDownDownFromTable(DB, "EducationEarned", "Name", "Name", theFather.EducationEarnedId.ToString()),
                // Update Patient Table with changes from form
                PatientID = thePrenatal.PatientId,
                DateUpdated = DateTime.Now,
                MedicalRecordNumber = thePatient.MedicalRecordNumber,

                // Update Person Table with changes from form
                PersonID = thePatient.PersonId,
                MotherEducationEarnedName = DB.EducationEarned.Where(x => x.EducationEarnedId == theBirthRecord.Prenatal.Patient.Person.EducationEarnedId).First().Name,
                FirstName = theMother.FirstName,
                MiddleName = theMother.MiddleName,
                LastName = theMother.LastName,
                Suffix = theMother.Suffix,
                Gender = theMother.Gender,
                BirthDate = theMother.BirthDate,
                BirthPlace = theMother.BirthPlace,
                BirthCounty = theMother.BirthCounty,
                ResidentStreetAddress = theMother.ResidentStreetAddress,
                ResidentAptNo = theMother.ResidenceAptNo,
                ResidentCity = theMother.ResidenceCity,
                ResidenceState = theMother.ResidenceState,
                ResidenceZip = theMother.ResidenceZip,
                MailingStreetAddress = theMother.MailingStreetAddress,
                MailingAptNo = theMother.MailingAptNo,
                MailingCity = theMother.MailingCity,
                // mailing state missing?
                MailingZip = theMother.MailingZip,
                Height = (int)theMother.Height,
                Weight = (int)theMother.Weight,
                IsMarried = theMother.IsMarried,
                PriorFirstName = theMother.PriorFirstName,
                PriorMiddleName = theMother.PriorMiddleName,
                PriorLastName = theMother.PriorLastName,
                PriorSuffix = theMother.PriorSuffix,
                InCity = theMother.InCity,
            // Mother Race
                motherWhite = motherRace.White,
                motherBlack = motherRace.Black,
                motherHasTribe = motherRace.Indian,
                motherAsianIndian = motherRace.AsianIndian,
                motherChinese = motherRace.Chinese,
                motherFilipino = motherRace.Filipino,
                motherJapanese = motherRace.Japanese,
                motherKorean = motherRace.Korean,
                motherVietnamese = motherRace.Vietnamese,
                motherOtherAsian = motherRace.OtherAsian,
                motherHawaiian = motherRace.Hawaiian,
                motherGuamanian = motherRace.Guamarian,
                motherSamoan = motherRace.Samoan,
                motherOtherRace = motherRace.Other,



            // Update Prenatal
                PrenatalID = thePrenatal.PrenatalId,
                FirstPrenatal = thePrenatal.FirstPrenatal,
                LastPreNatal = thePrenatal.LastPrenatal,
                TotalPrenatal = thePrenatal.TotalPrenatal,
                MotherPreWeight = (int)thePrenatal.MotherPreWeight,
                MotherDeliveryWeight = (int)thePrenatal.MotherDeliveryWeight,
                MotherPostWeight = (int)thePrenatal.MotherPostWeight,
                HadWic = thePrenatal.HadWic,
                EstimateGestation = thePrenatal.EstimateGestation,
                DateLastMenstruation = thePrenatal.DateLastMenstruation,
                PreviousBirthLiving = (byte)thePrenatal.PreviousBirthLiving,
                LastLiveBirth = thePrenatal.LastLiveBirth,
                OtherBirthOutcome = (int)thePrenatal.OtherBirthOutcome,
                LastOtherOutcome = thePrenatal.LastOtherOutcome,
                CigThreeMonthsBeforePregnancy = (short)thePrenatal.CigThreeMonthsBeforePregnancy,
                CigFirstThreeMonthsPregnacy = thePrenatal.CigFirstThreeMonthsPregnancy,
                CigSecondThreeMonthsPregnancy = thePrenatal.CigSecondThreeMonthsPregnancy,
                CigThridTrimesterPregnancy = thePrenatal.CigThirdTrimesterPregnancy,
                DiabetesPrePregnancy = thePrenatal.DiabetesPrePregnancy,
                DiabetesGestational = thePrenatal.DiabetesGestational,
                HypertensionPrePregnancy = thePrenatal.HypertensionPrePregnancy,
                HypertensionGestational = thePrenatal.HypertensionGestational,
                HypertensionEclampsia = thePrenatal.HypertensionEclampsia,
                PreviousPreTermBirth = thePrenatal.PreviousPreTermBirth,
                PreviousPoorBirthOutcome = thePrenatal.PreviousPoorBirthOutcome,
                FertilityDrugUsed = thePrenatal.FertilityDrugUsed,
                AssistedTechUsed = thePrenatal.AssistedTechUsed,
                PreviousCesarean = thePrenatal.PreviousCesarean,
                PreviousCesareanAmount = thePrenatal.PreviousCesareanAmount,
                Gonorrhea = thePrenatal.Gonorrhea,
                Syphilis = thePrenatal.Syphilis,
                Chlamydia = thePrenatal.Chlamydia,
                HepB = thePrenatal.HepB,
                HepC = thePrenatal.HepC,


            // BirthRecord
                WasHomeBirth = theBirthRecord.WasHomeBirth,
                WasPlannedHomeBirth = theBirthRecord.WasPlannedHomeBirth,
                OtherBirthLocation = theBirthRecord.OtherBirthLocation,
                MaternalTransfusion = theBirthRecord.MaternalTransfusion,
                PerinealLaceration = theBirthRecord.PerinealLaceration,
                RupturedUterus = theBirthRecord.RupturedUterus,
                UnplannedHysterectomy = theBirthRecord.UnplannedHysterectomy,
                AdmitToICU = theBirthRecord.AdmitToIcu,
                UnplannedOperationPostDelivery = theBirthRecord.UnplannedOperationPostDelivery,
                // Facility Hardcoded right now
                FacilityID = 11,
                // Father HardCoded right now
                FatherPersonID = theBirthRecord.FatherPersonId,
                // FacilityTransferIDMOM What does that even mean?
                FacilityTransferIDMom = 11, // Can I set it to the Facility ID?
                User = UserValues.First().FirstName + " " + UserValues.First().LastName,
                PaymentTypeID = 1,
                EntryDate = DateTime.Now,
                Tocolysis = theBirthRecord.Tocolysis,
                ExternalCephalic = theBirthRecord.ExternalCephalic,
                PreRuptureMembrane = theBirthRecord.PreRuptureMembrane,
                PrecipitousLabor = theBirthRecord.PrecipitousLabor,
                ProlongedLabor = theBirthRecord.ProlongedLabor,
                InductionLabor = theBirthRecord.InductionLabor,
                AugmentationLabor = theBirthRecord.AugmentationLabor,
                NonVertex = theBirthRecord.NonVertex,
                Steroids = theBirthRecord.Steroids,
                Antibotics = theBirthRecord.Antibiotics,
                Chorioamnionitis = theBirthRecord.Chorioamnoionitis,
                MeconiumStaining = theBirthRecord.MeconiumStaining,
                Epidural = theBirthRecord.Epidural,

            // Father
                FatherFirstName = theFather.FirstName,
                FatherMiddleName = theFather.MiddleName,
                FatherLastName = theFather.LastName,
                FatherSuffix = theFather.Suffix,
                FatherDOB = theFather.BirthDate,
                FatherBirthPlace = theFather.BirthPlace,
            
            // NewBornPerson
                ChildFirstName = theNewBornPerson.FirstName,
                ChildMiddleName = theNewBornPerson.MiddleName,
                ChildLastName = theNewBornPerson.LastName,
                ChildSuffix = theNewBornPerson.Suffix,
                ChildDOB = (DateTime)theNewBornPerson.BirthDate,
                ChildGender = theNewBornPerson.Gender,
                BabyPersonID = theNewBornPerson.PersonId,

            // NewBorn
                FacilityTransferIDBaby = 11, 
                InfantLiving = theNewBorn.InfantLiving,
                BreastFed = theNewBorn.BreastFed,
                BirthWeight = (int)theNewBorn.BirthWeight,
                FiveMinApgarScore = theNewBorn.FiveMinApgarScore,
                TenMinApgarScore = theNewBorn.TenMinApgarScore,
                BirthOrder = theNewBorn.BirthOrder,
                BirthTime = theNewBorn.BirthTime,
                PaternityAck = theNewBorn.PaternityAck,
                SsnRequested = theNewBorn.SsnRequested,
                CertifiedDate = (DateTime)theNewBorn.CertifiedDate,
                FiledDate = (DateTime)theNewBorn.FiledDate,
                FetalIntolerance = theNewBorn.FetalIntolerance,
                UnsuccessfulForceps = theNewBorn.UnsuccessfulForceps,
                UnsuccessfulVacuum = theNewBorn.UnsuccessfulVacuum,
                PresentationAtBirthCephalic = theNewBorn.PresentationAtBirthCephalic,
                PresentationAtBirthBreach = theNewBorn.PresentationAtBirthBreach,
                OtherFetalPresentation = theNewBorn.OtherFetalPresentation,
                RouteSpontaneous = theNewBorn.RouteSpontaneous,
                RouteForcepts = theNewBorn.RouteForceps,
                RouteVacuum = theNewBorn.RouteVacuum,
                Cesarean = theNewBorn.Cesarean,
                FinalTrialOfLabor = theNewBorn.FinalTrialOfLabor,
                VenImmediate = theNewBorn.VenImmediate,
                Nicu = theNewBorn.Nicu,
                Surfactant = theNewBorn.Surfactant,
                NeoNatalAntibotics = theNewBorn.NeoNatalAntibotics,
                SeizureDysfunction = theNewBorn.SeizureDysfunction,
                BirthInjury = theNewBorn.BirthInjury,
                Anencephaly = theNewBorn.Anencephaly,
                Meningomyelocele = theNewBorn.Meningomyelocele,
                Cyanotic = theNewBorn.Cyanotic,
                Cogenital = theNewBorn.Congenital,
                Omphalocele = theNewBorn.Omphalocele,
                Gastroschisis = theNewBorn.Gastoschisis,
                LimbReduction = theNewBorn.LimbReductin,
                CleftLip = theNewBorn.CleftLip,
                CleftPalate = theNewBorn.CleftPalate,
                DownSyndromeConfirmed = theNewBorn.DownSyndromeConfirmed,
                DownSyndromePending = theNewBorn.DownSyndromePending,
                ChromosomalDisorderConfirmed = theNewBorn.ChromosomalDisorderConfirmed,
                ChromosomalDisorderPending = theNewBorn.ChromosomalDisorderPending,
                Hypospadias = theNewBorn.Hypospadias,
        };
            return View("Edit", bRecord);
        }

        // POST: BirthRecords/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, BirthRecordVM bRecord)
        {
            var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User));
            Patient Patient = DB.Patient.Include("Person").Where(x => x.PatientId == bRecord.PatientID).FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (Patient != null)
                {
                    try
                    {
                        // Update Patient Table with changes from form
                        Patient.DateUpdated = DateTime.Now;
                        Patient.MedicalRecordNumber = bRecord.MedicalRecordNumber;

                        // Update Person Table with changes from form
                        Patient.Person.EducationEarnedId = DB.EducationEarned.Where(x => x.Name == bRecord.MotherEducationEarnedName).First().EducationEarnedId;
                        Patient.Person.FirstName = bRecord.FirstName;
                        Patient.Person.MiddleName = bRecord.MiddleName;
                        Patient.Person.LastName = bRecord.LastName;
                        Patient.Person.Suffix = bRecord.Suffix;
                        Patient.Person.Gender = bRecord.Gender;
                        Patient.Person.BirthDate = bRecord.BirthDate;
                        Patient.Person.BirthPlace = bRecord.BirthPlace;
                        Patient.Person.BirthCounty = bRecord.BirthCounty;
                        Patient.Person.ResidentStreetAddress = bRecord.ResidentStreetAddress;
                        Patient.Person.ResidenceAptNo = bRecord.ResidentAptNo;
                        Patient.Person.ResidenceCity = bRecord.ResidentCity;
                        Patient.Person.ResidenceState = bRecord.ResidenceState;
                        Patient.Person.ResidenceZip = bRecord.ResidenceZip;
                        Patient.Person.MailingStreetAddress = bRecord.MailingStreetAddress;
                        Patient.Person.MailingAptNo = bRecord.MailingAptNo;
                        Patient.Person.MailingCity = bRecord.MailingCity;
                        // mailing state missing?
                        Patient.Person.MailingZip = bRecord.MailingZip;
                        Patient.Person.Height = bRecord.Height;
                        Patient.Person.Weight = bRecord.Weight;
                        Patient.Person.IsMarried = bRecord.IsMarried;
                        Patient.Person.PriorFirstName = bRecord.PriorFirstName;
                        Patient.Person.PriorMiddleName = bRecord.PriorMiddleName;
                        Patient.Person.PriorLastName = bRecord.PriorLastName;
                        Patient.Person.PriorSuffix = bRecord.PriorSuffix;
                        Patient.Person.InCity = bRecord.InCity;

                        DB.SaveChanges();

                        // Update Mother's Race
                        var motherRace = DB.Race.Where(x => x.PersonId == Patient.PersonId).FirstOrDefault();
                        motherRace.White = bRecord.motherWhite;
                        motherRace.Black = bRecord.motherBlack;
                        motherRace.Indian = bRecord.motherHasTribe;
                        motherRace.AsianIndian = bRecord.motherAsianIndian;
                        motherRace.Chinese = bRecord.motherChinese;
                        motherRace.Filipino = bRecord.motherFilipino;
                        motherRace.Japanese = bRecord.motherJapanese;
                        motherRace.Korean = bRecord.motherKorean;
                        motherRace.Vietnamese = bRecord.motherVietnamese;
                        motherRace.OtherAsian = bRecord.motherOtherAsian;
                        motherRace.Hawaiian = bRecord.motherHawaiian;
                        motherRace.Guamarian = bRecord.motherGuamanian;
                        motherRace.Samoan = bRecord.motherSamoan;
                        motherRace.Other = bRecord.motherOtherRace;

                        DB.SaveChanges();

                        // Update Prenatal
                        var prenatal = DB.Prenatal.Where(x => x.PatientId == bRecord.PatientID).FirstOrDefault();
                        prenatal.PatientId = bRecord.PatientID;
                        prenatal.FirstPrenatal = bRecord.FirstPrenatal;
                        prenatal.LastPrenatal = bRecord.LastPreNatal;
                        prenatal.TotalPrenatal = bRecord.TotalPrenatal;
                        prenatal.MotherPreWeight = bRecord.MotherPreWeight;
                        prenatal.MotherDeliveryWeight = bRecord.MotherDeliveryWeight;
                        prenatal.MotherPostWeight = bRecord.MotherPostWeight;
                        prenatal.HadWic = bRecord.HadWic;
                        prenatal.EstimateGestation = bRecord.EstimateGestation;
                        prenatal.DateLastMenstruation = bRecord.DateLastMenstruation;
                        prenatal.PreviousBirthLiving = (byte)bRecord.PreviousBirthLiving;
                        prenatal.LastLiveBirth = bRecord.LastLiveBirth;
                        prenatal.OtherBirthOutcome = bRecord.OtherBirthOutcome;
                        prenatal.LastOtherOutcome = bRecord.LastOtherOutcome;
                        prenatal.CigThreeMonthsBeforePregnancy = (short)bRecord.CigThreeMonthsBeforePregnancy;
                        prenatal.CigFirstThreeMonthsPregnancy = bRecord.CigFirstThreeMonthsPregnacy;
                        prenatal.CigSecondThreeMonthsPregnancy = bRecord.CigSecondThreeMonthsPregnancy;
                        prenatal.CigThirdTrimesterPregnancy = bRecord.CigThridTrimesterPregnancy;
                        prenatal.DiabetesPrePregnancy = bRecord.DiabetesPrePregnancy;
                        prenatal.DiabetesGestational = bRecord.DiabetesGestational;
                        prenatal.HypertensionPrePregnancy = bRecord.HypertensionPrePregnancy;
                        prenatal.HypertensionGestational = bRecord.HypertensionGestational;
                        prenatal.HypertensionEclampsia = bRecord.HypertensionEclampsia;
                        prenatal.PreviousPreTermBirth = bRecord.PreviousPreTermBirth;
                        prenatal.PreviousPoorBirthOutcome = bRecord.PreviousPoorBirthOutcome;
                        prenatal.FertilityDrugUsed = bRecord.FertilityDrugUsed;
                        prenatal.AssistedTechUsed = bRecord.AssistedTechUsed;
                        prenatal.PreviousCesarean = bRecord.PreviousCesarean;
                        prenatal.PreviousCesareanAmount = (byte)bRecord.PreviousCesareanAmount;
                        prenatal.Gonorrhea = bRecord.Gonorrhea;
                        prenatal.Syphilis = bRecord.Syphilis;
                        prenatal.Chlamydia = bRecord.Chlamydia;
                        prenatal.HepB = bRecord.HepB;
                        prenatal.HepC = bRecord.HepC;
                        DB.SaveChanges();

                        // Create BirthRecord
                        var birthRecord = DB.BirthRecord.Where(x => x.BirthRecordId == id).FirstOrDefault();
                        birthRecord.WasHomeBirth = bRecord.WasHomeBirth;
                        birthRecord.WasPlannedHomeBirth = bRecord.WasPlannedHomeBirth;
                        birthRecord.OtherBirthLocation = bRecord.OtherBirthLocation;
                        birthRecord.MaternalTransfusion = bRecord.MaternalTransfusion;
                        birthRecord.PerinealLaceration = bRecord.PerinealLaceration;
                        birthRecord.RupturedUterus = bRecord.RupturedUterus;
                        birthRecord.UnplannedHysterectomy = bRecord.UnplannedHysterectomy;
                        birthRecord.AdmitToIcu = bRecord.AdmitToICU;
                        birthRecord.UnplannedOperationPostDelivery = bRecord.UnplannedOperationPostDelivery;
                        //birthRecord.PrenatalId = prenatal.PrenatalId;
                        // Facility Hardcoded right now
                        birthRecord.FacilityId = 11;
                        birthRecord.FatherPersonId = (int)bRecord.FatherPersonID;
                        // FacilityTransferIDMOM What does that even mean?
                        birthRecord.FacilityTransferIdmom = 11; // Can I set it to the Facility ID?
                        birthRecord.User = UserValues.First().FirstName + " " + UserValues.First().LastName;
                        birthRecord.PaymentTypeId = 1;
                        birthRecord.EntryDate = DateTime.Now;
                        birthRecord.Tocolysis = bRecord.Tocolysis;
                        birthRecord.ExternalCephalic = bRecord.ExternalCephalic;
                        birthRecord.PreRuptureMembrane = bRecord.PreRuptureMembrane;
                        birthRecord.PrecipitousLabor = bRecord.PrecipitousLabor;
                        birthRecord.ProlongedLabor = bRecord.ProlongedLabor;
                        birthRecord.InductionLabor = bRecord.InductionLabor;
                        birthRecord.AugmentationLabor = bRecord.AugmentationLabor;
                        birthRecord.NonVertex = bRecord.NonVertex;
                        birthRecord.Steroids = bRecord.Steroids;
                        birthRecord.Antibiotics = bRecord.Antibotics;
                        birthRecord.Chorioamnoionitis = bRecord.Chorioamnionitis;
                        birthRecord.MeconiumStaining = bRecord.MeconiumStaining;
                        birthRecord.Epidural = bRecord.Epidural;
                        DB.SaveChanges();

                        var father = DB.Person.Where(x => x.PersonId == bRecord.FatherPersonID).FirstOrDefault();
                        father.FirstName = bRecord.FatherFirstName;
                        father.MiddleName = bRecord.FatherMiddleName;
                        father.LastName = bRecord.FatherLastName;
                        father.Suffix = bRecord.FatherSuffix;
                        father.EducationEarnedId = DB.EducationEarned.Where(x => x.Name == bRecord.FatherEducationEarnedName).First().EducationEarnedId;

                        // Baby - Person
                        var newBornPerson = DB.Person.Where(x => x.PersonId == bRecord.BabyPersonID).FirstOrDefault();
                        newBornPerson.EducationEarnedId = 1;
                        newBornPerson.FirstName = bRecord.ChildFirstName;
                        newBornPerson.MiddleName = bRecord.ChildMiddleName;
                        newBornPerson.LastName = bRecord.ChildLastName;
                        newBornPerson.Suffix = bRecord.ChildSuffix;
                        newBornPerson.BirthDate = bRecord.ChildDOB;
                        newBornPerson.IsMarried = false;
                        newBornPerson.InCity = true;
                        newBornPerson.Gender = bRecord.ChildGender;
                        DB.SaveChanges();

                        // NewBorn
                        var newBorn = DB.NewBorn.Where(x => x.BirthRecordId == id).FirstOrDefault();
                        newBorn.PersonId = newBornPerson.PersonId;
                        newBorn.BirthRecordId = birthRecord.BirthRecordId;
                        newBorn.FacilityTransferIdbaby = 11;
                        newBorn.InfantLiving = bRecord.InfantLiving;
                        newBorn.BreastFed = bRecord.BreastFed;
                        newBorn.BirthWeight = bRecord.BirthWeight;
                        newBorn.FiveMinApgarScore = bRecord.FiveMinApgarScore;
                        newBorn.TenMinApgarScore = bRecord.TenMinApgarScore;
                        newBorn.BirthOrder = bRecord.BirthOrder;
                        newBorn.BirthTime = bRecord.ChildDOB;
                        newBorn.PaternityAck = bRecord.PaternityAck;
                        newBorn.SsnRequested = bRecord.SsnRequested;
                        newBorn.CertifiedDate = bRecord.CertifiedDate;
                        newBorn.FiledDate = bRecord.FiledDate;
                        newBorn.FetalIntolerance = bRecord.FetalIntolerance;
                        newBorn.UnsuccessfulForceps = bRecord.UnsuccessfulForceps;
                        newBorn.UnsuccessfulVacuum = bRecord.UnsuccessfulVacuum;
                        newBorn.PresentationAtBirthCephalic = bRecord.PresentationAtBirthCephalic;
                        newBorn.PresentationAtBirthBreach = bRecord.PresentationAtBirthBreach;
                        newBorn.OtherFetalPresentation = bRecord.OtherFetalPresentation;
                        newBorn.RouteSpontaneous = bRecord.RouteSpontaneous;
                        newBorn.RouteForceps = bRecord.RouteForcepts;
                        newBorn.RouteVacuum = bRecord.RouteVacuum;
                        newBorn.Cesarean = bRecord.Cesarean;
                        newBorn.FinalTrialOfLabor = bRecord.FinalTrialOfLabor;
                        newBorn.VenImmediate = bRecord.VenImmediate;
                        newBorn.Nicu = bRecord.Nicu;
                        newBorn.Surfactant = bRecord.Surfactant;
                        newBorn.NeoNatalAntibotics = bRecord.NeoNatalAntibotics;
                        newBorn.SeizureDysfunction = bRecord.SeizureDysfunction;
                        newBorn.BirthInjury = bRecord.BirthInjury;
                        newBorn.Anencephaly = bRecord.Anencephaly;
                        newBorn.Meningomyelocele = bRecord.Meningomyelocele;
                        newBorn.Cyanotic = bRecord.Cyanotic;
                        newBorn.Congenital = bRecord.Cogenital;
                        newBorn.Omphalocele = bRecord.Omphalocele;
                        newBorn.Gastoschisis = bRecord.Gastroschisis;
                        newBorn.LimbReductin = bRecord.LimbReduction;
                        newBorn.CleftLip = bRecord.CleftLip;
                        newBorn.CleftPalate = bRecord.CleftPalate;
                        newBorn.DownSyndromeConfirmed = bRecord.DownSyndromeConfirmed;
                        newBorn.DownSyndromePending = bRecord.DownSyndromePending;
                        newBorn.ChromosomalDisorderConfirmed = bRecord.ChromosomalDisorderConfirmed;
                        newBorn.ChromosomalDisorderPending = bRecord.ChromosomalDisorderPending;
                        newBorn.Hypospadias = bRecord.Hypospadias;
                        DB.SaveChanges();
                    }
                    catch
                    {
                        return View("Edit", bRecord); ;
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Patients");
                }
            }
            return RedirectToAction("Details", "Patients", new { id = Patient.PatientId });
        }


        // GET: BirthRecords/1
        public IActionResult Details(int? id)
        {
            //BirthRecord
            BirthRecord bRecord = DB.BirthRecord.Find(id);
            //Newborn
            NewBorn nRecord = DB.NewBorn.FirstOrDefault(r => r.BirthRecordId == id);
            //Prenatal
            Prenatal preRecord = DB.Prenatal.FirstOrDefault(r => r.PrenatalId == bRecord.PrenatalId);
            //Patient
            Patient patRecord = DB.Patient.FirstOrDefault(r => r.PatientId == preRecord.PatientId);
            //Person
            Person perRecord = DB.Person.FirstOrDefault(r => r.PersonId == patRecord.PersonId);
            //Certifier
            Certifier cRecord = DB.Certifier.FirstOrDefault(r => r.PersonId == patRecord.PersonId);
            //Attendant
            Attendant aRecord = DB.Attendant.FirstOrDefault(r => r.PersonId == patRecord.PersonId);
            //PaymentType
            PaymentType payRecord = DB.PaymentType.FirstOrDefault(r => r.PaymentTypeId == 1);//this table doesnt appear to be linked to any other table
            //Facility
            Facility fRecord = DB.Facility.FirstOrDefault(r => r.FacilityId == bRecord.FacilityId);
            //FacilityType
            FacilityType ftRecord = DB.FacilityType.FirstOrDefault(r => r.FacilityTypeId == fRecord.FacilityTypeId);


            BirthRecordVM birthRecordVM = new BirthRecordVM();

            if (bRecord != null)
            {
                birthRecordVM.BirthRecordID = bRecord.BirthRecordId;
                birthRecordVM.WasHomeBirth = bRecord.WasHomeBirth;
                birthRecordVM.WasPlannedHomeBirth = bRecord.WasPlannedHomeBirth;
                birthRecordVM.OtherBirthLocation = bRecord.OtherBirthLocation;
                birthRecordVM.MaternalTransfusion = bRecord.MaternalTransfusion;
                birthRecordVM.PerinealLaceration = bRecord.PerinealLaceration;
                birthRecordVM.RupturedUterus = bRecord.RupturedUterus;
                birthRecordVM.UnplannedHysterectomy = bRecord.UnplannedHysterectomy;
                birthRecordVM.AdmitToICU = bRecord.AdmitToIcu;
                birthRecordVM.UnplannedOperationPostDelivery = bRecord.UnplannedOperationPostDelivery;
                birthRecordVM.User = bRecord.User;
                birthRecordVM.EntryDate = bRecord.EntryDate;
                birthRecordVM.Tocolysis = bRecord.Tocolysis;
                birthRecordVM.ExternalCephalic = bRecord.ExternalCephalic;
                birthRecordVM.PreRuptureMembrane = bRecord.PreRuptureMembrane;
                birthRecordVM.PrecipitousLabor = bRecord.PrecipitousLabor;
                birthRecordVM.ProlongedLabor = bRecord.ProlongedLabor;
                birthRecordVM.InductionLabor = bRecord.InductionLabor;
                birthRecordVM.AugmentationLabor = bRecord.AugmentationLabor;
                birthRecordVM.NonVertex = bRecord.NonVertex;
                birthRecordVM.Steroids = bRecord.Steroids;
                birthRecordVM.Antibotics = bRecord.Antibiotics;
                birthRecordVM.Chorioamnionitis = bRecord.Chorioamnoionitis;
                birthRecordVM.MeconiumStaining = bRecord.MeconiumStaining;
                birthRecordVM.Epidural = bRecord.Epidural;
            }
            else
            {
                ModelState.AddModelError("", "Birth Record Not Found");
            }

            if (nRecord != null)
            {
                birthRecordVM.NewBornID = nRecord.NewBornId;
                birthRecordVM.InfantLiving = nRecord.InfantLiving;
                birthRecordVM.BreastFed = nRecord.BreastFed;
                birthRecordVM.BirthWeight = (int)nRecord.BirthWeight;
                birthRecordVM.FiveMinApgarScore = nRecord.FiveMinApgarScore;
                birthRecordVM.TenMinApgarScore = nRecord.TenMinApgarScore;
                birthRecordVM.BirthOrder = nRecord.BirthOrder;
                birthRecordVM.BirthTime = nRecord.BirthTime;
                birthRecordVM.PaternityAck = nRecord.PaternityAck;
                birthRecordVM.SsnRequested = nRecord.SsnRequested;
                birthRecordVM.CertifiedDate = (DateTime)nRecord.CertifiedDate;
                birthRecordVM.FiledDate = (DateTime)nRecord.FiledDate;
                birthRecordVM.FetalIntolerance = nRecord.FetalIntolerance;
                birthRecordVM.UnsuccessfulForceps = nRecord.UnsuccessfulForceps;
                birthRecordVM.UnsuccessfulVacuum = nRecord.UnsuccessfulVacuum;
                birthRecordVM.PresentationAtBirthCephalic = nRecord.PresentationAtBirthCephalic;
                birthRecordVM.PresentationAtBirthBreach = nRecord.PresentationAtBirthBreach;
                birthRecordVM.OtherFetalPresentation = nRecord.OtherFetalPresentation;
                birthRecordVM.RouteSpontaneous = nRecord.RouteSpontaneous;
                birthRecordVM.RouteForcepts = nRecord.RouteForceps;
                birthRecordVM.RouteVacuum = nRecord.RouteVacuum;
                birthRecordVM.Cesarean = nRecord.Cesarean;
                birthRecordVM.FinalTrialOfLabor = nRecord.FinalTrialOfLabor;
                birthRecordVM.VenImmediate = nRecord.VenImmediate;
                birthRecordVM.VentSixHours = nRecord.VentSixHours;
                birthRecordVM.Nicu = nRecord.Nicu;
                birthRecordVM.Surfactant = nRecord.Surfactant;
                birthRecordVM.NeoNatalAntibotics = nRecord.NeoNatalAntibotics;
                birthRecordVM.SeizureDysfunction = nRecord.SeizureDysfunction;
                birthRecordVM.BirthInjury = nRecord.BirthInjury;
                birthRecordVM.Anencephaly = nRecord.Anencephaly;
                birthRecordVM.Meningomyelocele = nRecord.Meningomyelocele;
                birthRecordVM.Cyanotic = nRecord.Cyanotic;
                birthRecordVM.Cogenital = nRecord.Congenital;
                birthRecordVM.Omphalocele = nRecord.Omphalocele;
                birthRecordVM.Gastroschisis = nRecord.Gastoschisis;
                birthRecordVM.LimbReduction = nRecord.LimbReductin;
                birthRecordVM.CleftLip = nRecord.CleftLip;
                birthRecordVM.CleftPalate = nRecord.CleftPalate;
                birthRecordVM.DownSyndromeConfirmed = nRecord.DownSyndromeConfirmed;
                birthRecordVM.DownSyndromePending = nRecord.DownSyndromePending;
                birthRecordVM.ChromosomalDisorderConfirmed = nRecord.ChromosomalDisorderConfirmed;
                birthRecordVM.ChromosomalDisorderPending = nRecord.ChromosomalDisorderPending;
                birthRecordVM.Hypospadias = nRecord.Hypospadias;
            }
            else
            {
                ModelState.AddModelError("", "New born Record Not Found");
            }

            if (preRecord != null)
            {
                birthRecordVM.PrenatalID = preRecord.PrenatalId;
                birthRecordVM.FirstPrenatal = preRecord.FirstPrenatal;
                birthRecordVM.LastPreNatal = preRecord.LastPrenatal;
                birthRecordVM.TotalPrenatal = preRecord.TotalPrenatal;
                birthRecordVM.MotherPreWeight = (int)preRecord.MotherPreWeight;
                birthRecordVM.MotherDeliveryWeight = (int)preRecord.MotherDeliveryWeight;
                birthRecordVM.MotherPostWeight = (int)preRecord.MotherPostWeight;
                birthRecordVM.HadWic = preRecord.HadWic;
                birthRecordVM.EstimateGestation = preRecord.EstimateGestation;
                birthRecordVM.DateLastMenstruation = preRecord.DateLastMenstruation;
                birthRecordVM.PreviousBirthLiving = (int)preRecord.PreviousBirthLiving;
                birthRecordVM.LastLiveBirth = preRecord.LastLiveBirth;
                birthRecordVM.OtherBirthOutcome = (int)preRecord.OtherBirthOutcome;
                birthRecordVM.LastOtherOutcome = preRecord.LastOtherOutcome;
                birthRecordVM.CigThreeMonthsBeforePregnancy = (int)preRecord.CigThreeMonthsBeforePregnancy;
                birthRecordVM.CigFirstThreeMonthsPregnacy = preRecord.CigFirstThreeMonthsPregnancy;
                birthRecordVM.CigSecondThreeMonthsPregnancy = preRecord.CigSecondThreeMonthsPregnancy;
                birthRecordVM.CigThridTrimesterPregnancy = preRecord.CigThirdTrimesterPregnancy;
                birthRecordVM.DiabetesPrePregnancy = preRecord.DiabetesPrePregnancy;
                birthRecordVM.DiabetesGestational = preRecord.DiabetesGestational;
                birthRecordVM.HypertensionPrePregnancy = preRecord.HypertensionPrePregnancy;
                birthRecordVM.HypertensionGestational = preRecord.HypertensionGestational;
                birthRecordVM.HypertensionEclampsia = preRecord.HypertensionEclampsia;
                birthRecordVM.PreviousPreTermBirth = preRecord.PreviousPreTermBirth;
                birthRecordVM.PreviousPoorBirthOutcome = preRecord.PreviousPoorBirthOutcome;
                birthRecordVM.FertilityDrugUsed = preRecord.FertilityDrugUsed;
                birthRecordVM.AssistedTechUsed = preRecord.AssistedTechUsed;
                birthRecordVM.PreviousCesarean = preRecord.PreviousCesarean;
                birthRecordVM.PreviousCesareanAmount = preRecord.PreviousCesareanAmount;
                birthRecordVM.Gonorrhea = preRecord.Gonorrhea;
                birthRecordVM.Syphilis = preRecord.Syphilis;
                birthRecordVM.Chlamydia = preRecord.Chlamydia;
                birthRecordVM.HepB = preRecord.HepB;
                birthRecordVM.HepC = preRecord.HepC;
            }
            else
            {
                ModelState.AddModelError("", "Prenatal Record Not Found");
            }

            if (patRecord != null)
            {
                birthRecordVM.PatientID = patRecord.PatientId;
                birthRecordVM.MedicalRecordNumber = patRecord.MedicalRecordNumber;
                birthRecordVM.DateCreated = patRecord.DateCreated;
                birthRecordVM.DateUpdated = patRecord.DateUpdated;
            }
            else
            {
                ModelState.AddModelError("", "Patient Record Not Found");
            }

            if (perRecord != null)
            {
                birthRecordVM.MotherEducationEarnedName = DB.EducationEarned.Where(x => x.EducationEarnedId == bRecord.Prenatal.Patient.Person.EducationEarnedId).First().Name;
                birthRecordVM.FirstName = perRecord.FirstName;
                birthRecordVM.MiddleName = perRecord.MiddleName;
                birthRecordVM.LastName = perRecord.LastName;
                birthRecordVM.Suffix = perRecord.Suffix;
                birthRecordVM.Gender = perRecord.Gender;
                birthRecordVM.BirthDate = perRecord.BirthDate;
                birthRecordVM.BirthPlace = perRecord.BirthPlace;
                birthRecordVM.BirthCounty = perRecord.BirthCounty;
                birthRecordVM.ResidentStreetAddress = perRecord.ResidentStreetAddress;
                birthRecordVM.ResidentAptNo = perRecord.ResidenceAptNo;
                birthRecordVM.ResidentCity = perRecord.ResidenceCity;
                birthRecordVM.ResidenceState = perRecord.ResidenceState;
                birthRecordVM.ResidenceZip = perRecord.ResidenceZip;
                birthRecordVM.MailingStreetAddress = perRecord.MailingStreetAddress;
                birthRecordVM.MailingAptNo = perRecord.MailingAptNo;
                birthRecordVM.MailingCity = perRecord.MailingCity;
                //MailingState = perRecord.ma; person is missing a mailing state
                birthRecordVM.MailingZip = perRecord.MailingZip;
                birthRecordVM.Height = (int)perRecord.Height;
                birthRecordVM.Weight = (int)perRecord.Weight;
                birthRecordVM.IsMarried = perRecord.IsMarried;
                birthRecordVM.PriorFirstName = perRecord.PriorFirstName;
                birthRecordVM.PriorMiddleName = perRecord.PriorMiddleName;
                birthRecordVM.PriorLastName = perRecord.PriorLastName;
                birthRecordVM.PriorSuffix = perRecord.PriorSuffix;
                birthRecordVM.InCity = perRecord.InCity;
            }
            else
            {
                ModelState.AddModelError("", "Person Record Not Found");
            }

            if (cRecord != null)
            {
                birthRecordVM.CertifierName = cRecord.CertifierName;
            }
            else
            {
                ModelState.AddModelError("", "Certifier Record Not Found");
            }

            if (aRecord != null)
            {
                birthRecordVM.NPI = aRecord.Npi;
                birthRecordVM.JobTitle = aRecord.JobTitle;
            }
            else
            {
                ModelState.AddModelError("", "Attendant Record Not Found");
            }

            if (payRecord != null)
            {
                birthRecordVM.PaymentSource = payRecord.PaymentSource;
            }
            else
            {
                ModelState.AddModelError("", "Payment Record Not Found");
            }

            if (fRecord != null)
            {
                birthRecordVM.FacilityName = fRecord.FacilityName;
                birthRecordVM.FacilityNumber = fRecord.FacilityNumber;
            }
            else
            {
                ModelState.AddModelError("", "Facility Record Not Found");
            }

            if (ftRecord != null)
            {
                birthRecordVM.BirthFacility = ftRecord.Facility.ToString();
            }
            else
            {
                ModelState.AddModelError("", "Facility Type Record Not Found");
            }

            return View(birthRecordVM);
        }


        /*
            public ActionResult FormPdf(int? Id)
            {
                if (Id == null)
                {
                    return RedirectToAction("tempError", "Home");
                }
                BirthRecordFormModel Brfm = new BirthRecordFormModel();
                Brfm.BirthRecord = DB.BirthRecord.Find(Id);
                Brfm.MotherPatient = DB.Patient.Find(DB.Record.Where(r => r.BirthRecordId == Id).FirstOrDefault());
                if (DB.Record.Where(r => r.BirthRecordId == Id).Count() > 2)
                {
                    Brfm.FatherPatient = DB.Patient.Find(DB.Record.Where(r => r.BirthRecordId == Id).ElementAtOrDefault(1));
                    Brfm.ChildPatient = DB.Patient.Find(DB.Record.Where(r => r.BirthRecordId == Id).ElementAtOrDefault(2));
                }
                else
                    Brfm.ChildPatient = DB.Patient.Find(DB.Record.Where(r => r.BirthRecordId == Id).ElementAtOrDefault(1));

                return View("FormPdf", Brfm);
            }
        */
    }
}
