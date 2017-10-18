


namespace Nidan.Data.Models
{
    using System.Data.Entity;
    using Entity;

    public partial class NidanDatabase : OrganisationDbContext
    {
        public NidanDatabase() : base("name=NidanDatabase")
        {
        }

        public virtual DbSet<AbsenceType> AbsenceTypes { get; set; }
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AspNetUsersAlertSchedule> AspNetUsersAlertSchedules { get; set; }
        public virtual DbSet<Colour> Colours { get; set; }
        public virtual DbSet<Host> Hosts { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<UserAuthorisationFilter> UserAuthorisationFilters { get; set; }
        public virtual DbSet<Enquiry> Enquiries { get; set; }
        public virtual DbSet<Centre> Centres { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Mobilization> Mobilizations { get; set; }

        public virtual DbSet<EventActivityType> EventActivityTypes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<EventQuestion> EventQuestions { get; set; }
        public virtual DbSet<AreaOfInterest> AreaOfInterests { get; set; }
        public virtual DbSet<CasteCategory> CasteCategories { get; set; }
        public virtual DbSet<FollowUp> FollowUps { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<HowDidYouKnowAbout> HowDidYouKnowAbouts { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<EnquirySearchField> EnquirySearchFields { get; set; }
        public virtual DbSet<MobilizationType> MobilizationTypes { get; set; }
        public virtual DbSet<Scheme> Schemes { get; set; }
        public virtual DbSet<BatchTimePrefer> BatchTimePrefers { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<EnquiryType> EnquiryTypes { get; set; }
        public virtual DbSet<StudentType> StudentTypes { get; set; }
        public virtual DbSet<Counselling> Counsellings { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Taluka> Talukas { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<CounsellingSearchField> CounsellingSearchFields { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<EventFunctionType> EventFunctionTypes { get; set; }
        public virtual DbSet<Brainstorming> Brainstormings { get; set; }
        public virtual DbSet<Eventday> Eventdays { get; set; }
        public virtual DbSet<Planning> Plannings { get; set; }
        public virtual DbSet<PostEvent> PostEvents { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<TrainerSearchField> TrainerSearchFields { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<PaymentMode> PaymentModes { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<CourseInstallment> CourseInstallments { get; set; }
        public virtual DbSet<CourseSubject> CourseSubjects { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectTrainer> SubjectTrainers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<BatchDay> BatchDays { get; set; }
        public virtual DbSet<CourseSearchField> CourseSearchFields { get; set; }
        public virtual DbSet<EnquiryCourse> EnquiryCourses { get; set; }
        public virtual DbSet<CentreCourse> CentreCourses { get; set; }
        public virtual DbSet<SubjectCourse> SubjectCourses { get; set; }
        public virtual DbSet<BatchTrainer> BatchTrainers { get; set; }
        public virtual DbSet<CentreCourseInstallment> CentreCourseInstallments { get; set; }
        public virtual DbSet<CentreScheme> CentreSchemes { get; set; }
        public virtual DbSet<CentreSector> CentreSectors { get; set; }
        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<CandidateInstallment> CandidateInstallments { get; set; }
        public virtual DbSet<CandidateFee> CandidateFees { get; set; }
        public virtual DbSet<MobilizationSearchField> MobilizationSearchFields { get; set; }
        public virtual DbSet<CourseInstallmentSearchField> CourseInstallmentSearchFields { get; set; }
        public virtual DbSet<FollowUpHistory> FollowUpHistories { get; set; }
        public virtual DbSet<FollowUpSearchField> FollowUpSearchFields { get; set; }
        public virtual DbSet<RegistrationSearchField> RegistrationSearchFields { get; set; }
        public virtual DbSet<AdmissionSearchField> AdmissionSearchFields { get; set; }
        public virtual DbSet<CandidateFeeSearchField> CandidateFeeSearchFields { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<TrainerAvailable> TrainerAvailables { get; set; }
        public virtual DbSet<RoomAvailable> RoomAvailables { get; set; }
        public virtual DbSet<CandidateInstallmentSearchField> CandidateInstallmentSearchFields { get; set; }
        public virtual DbSet<AdmissionGrid> AdmissionGrids { get; set; }
        public virtual DbSet<CandidateInstallmentGrid> CandidateInstallmentGrids { get; set; }
        public virtual DbSet<ExpenseHeader> ExpenseHeaders { get; set; }
        public virtual DbSet<OtherFee> OtherFees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<CentrePettyCash> CentrePettyCashes { get; set; }
        public virtual DbSet<CandidateFeeGrid> CandidateFeeGrids { get; set; }
        public virtual DbSet<EnquiryDataGrid> EnquiryDataGrids { get; set; }
        public virtual DbSet<FollowUpDataGrid> FollowUpDataGrids { get; set; }
        public virtual DbSet<MobilizationDataGrid> MobilizationDataGrids { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<VoucherGrid> VoucherGrids { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<CentreVoucherNumber> CentreVoucherNumbers { get; set; }
        public virtual DbSet<ExpenseProject> ExpenseProjects { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<BatchAttendance> BatchAttendances { get; set; }
        public virtual DbSet<AttendanceGrid> AttendanceGrids { get; set; }
        public virtual DbSet<CounsellingDataGrid> CounsellingDataGrids { get; set; }
        public virtual DbSet<ExpenseDataGrid> ExpenseDataGrids { get; set; }
        public virtual DbSet<PettyCashExpenseReport> PettyCashExpenseReports { get; set; }
        public virtual DbSet<EventBrainstorming> EventBrainstormings { get; set; }
        public virtual DbSet<MobilizationCentreReport> MobilizationCentreReports { get; set; }
        public virtual DbSet<Gst> Gsts { get; set; }
        public virtual DbSet<MobilizationCentreReportMonthWise> MobilizationCentreReportMonthWises { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<EventBudget> EventBudgets { get; set; }
        public virtual DbSet<EventPlanning> EventPlannings { get; set; }
        public virtual DbSet<EventPostEvent> EventPostEvents { get; set; }
        public virtual DbSet<CentreReceiptSetting> CentreReceiptSettings { get; set; }
        public virtual DbSet<CentreEnrollmentReceiptSetting> CentreEnrollmentReceiptSettings { get; set; }
        public virtual DbSet<BiometricAttendance> BiometricAttendances { get; set; }
        public virtual DbSet<BiometricAttendanceGrid> BiometricAttendanceGrids { get; set; }
        public virtual DbSet<EventBrainStormingGrid> EventBrainStormingGrids { get; set; }
        public virtual DbSet<RegistrationGrid> RegistrationGrids { get; set; }
        public virtual DbSet<StockIssue> StockIssues { get; set; }
        public virtual DbSet<StockPurchase> StockPurchases { get; set; }
        public virtual DbSet<StockDataGrid> StockDataGrids { get; set; }
        public virtual DbSet<FixAsset> FixAssets { get; set; }
        public virtual DbSet<FixAssetSearchGrid> FixAssetSearchGrids { get; set; }
        public virtual DbSet<FixAssetDataGrid> FixAssetDataGrids { get; set; }
        public virtual DbSet<StockType> StockTypes { get; set; }
        public virtual DbSet<StockReportDataGrid> StockReportDataGrids { get; set; }
        public virtual DbSet<BatchPlanner> BatchPlanners { get; set; }
        public virtual DbSet<BatchPlannerDay> BatchPlannerDays { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<CentreProductSetting> CentreProductSettings { get; set; }
        public virtual DbSet<CentreFixAsset> CentreFixAssets { get; set; }
        public virtual DbSet<BatchPlannerGrid> BatchPlannerGrids { get; set; }
        public virtual DbSet<StudentKit> StudentKits { get; set; }
        public virtual DbSet<SummaryReport> SummaryReports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Alert>()
                .HasMany(e => e.AspNetUsersAlertSchedules)
                .WithRequired(e => e.Alert)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colour>()
                .Property(e => e.Hex)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Course>()
               .Property(e => e.Description)
               .IsUnicode(false);

            //modelBuilder.Entity<Course>()
            //    .Property(e => e.CourseType)
            //    .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.FollowUps)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.IntrestedCourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
               .HasMany(e => e.Counsellings)
               .WithRequired(e => e.Course)
               .HasForeignKey(e => e.CourseOfferedId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
             .HasMany(e => e.Courses)
             .WithRequired(e => e.Sector)
             .HasForeignKey(e => e.SectorId)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFee>()
                .Property(e => e.ChequeNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFee>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFee>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFee>()
                .Property(e => e.Particulars)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFee>()
                .Property(e => e.FiscalYear)
                .IsUnicode(false);
           
            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Alerts)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Hosts)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Personnels)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Personnel>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.NINumber)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.BankAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.BankSortCode)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.BankTelephone)
                .IsUnicode(false);



            //modelBuilder.Entity<PublicHoliday>()
            //    .HasMany(e => e.CountryPublicHolidays)
            //    .WithRequired(e => e.PublicHoliday)
            //    .WillCascadeOnDelete(false);


            //modelBuilder.Entity<Site>()
            //    .HasMany(e => e.DivisionSites)
            //    .WithRequired(e => e.Site)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkingPattern>()
            //    .HasMany(e => e.DivisionCountryWorkingPatterns)
            //    .WithRequired(e => e.WorkingPattern)
            //    .WillCascadeOnDelete(false);



            //modelBuilder.Entity<CompanyBuilding>()
            //.HasMany(e => e.Buildings)
            //.WithRequired(e => e.CompanyBuilding)
            //.WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
              .Property(e => e.Name)
              .IsUnicode(false);
           

            modelBuilder.Entity<Event>()
                .Property(e => e.CreatedBy);

           

            modelBuilder.Entity<EventActivityType>()
                .Property(e => e.Name)
                .IsFixedLength();

            //modelBuilder.Entity<Enquiry>()
            //    .Property(e => e.QualificationId);

            modelBuilder.Entity<Centre>()
                  .Property(e => e.CentreCode)
                  .IsUnicode(false);

            modelBuilder.Entity<Centre>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentType>()
                .Property(e => e.BasePath)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentType>()
                .HasMany(e => e.Documents)
                .WithRequired(e => e.DocumentType)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Centre>()
            //    .HasMany(e => e.Events)
            //    .WithRequired(e => e.Centre)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
              .Property(e => e.Name)
              .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.IntrestedCourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Mobilizations)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.InterestedCourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AreaOfInterest>()
                    .Property(e => e.Name)
                    .IsUnicode(false);

            modelBuilder.Entity<CasteCategory>()
                .Property(e => e.Caste)
                .IsUnicode(false);

            modelBuilder.Entity<CasteCategory>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.CasteCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Centre>()
                .Property(e => e.CentreCode)
                .IsUnicode(false);

            modelBuilder.Entity<Centre>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Centre>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.Centre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colour>()
                .Property(e => e.Hex)
                .IsUnicode(false);

           modelBuilder.Entity<HowDidYouKnowAbout>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<HowDidYouKnowAbout>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.HowDidYouKnowAbout)
                .WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Occupation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Occupation>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.Occupation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Qualification>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Qualification>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.Qualification)
                .HasForeignKey(e => e.EducationalQualificationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Religion>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Religion>()
                .HasMany(e => e.Enquiries)
                .WithRequired(e => e.Religion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<MobilizationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Scheme>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BatchTimePrefer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryType>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<StudentType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .HasMany(e => e.Talukas)
                .WithRequired(e => e.District)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.Districts)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.Talukas)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taluka>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EventFunctionType>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<EventFunctionType>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.EventFunctionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Eventday>()
                .Property(e => e.Completed)
                .IsUnicode(false);

            modelBuilder.Entity<Eventday>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMode>()
                 .Property(e => e.Name)
                 .IsUnicode(false);


            modelBuilder.Entity<Holiday>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.WeekDay)
                .IsUnicode(false);

            modelBuilder.Entity<CourseType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CourseType>()
                .HasMany(e => e.Subjects)
                .WithRequired(e => e.CourseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Session>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<Session>()
                .Property(e => e.CourseTypeId);

            modelBuilder.Entity<Session>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
               .Property(e => e.Description)
               .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.OccupiedStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.OccupiedEndTime)
                .IsUnicode(false);


            modelBuilder.Entity<RoomType>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.BatchStartTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.BatchEndTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<CourseInstallment>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Address4)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.GuardianName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.YearOfPassOut)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Marks)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.PreTrainingStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.EmploymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Promotional)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.EnquiryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.EmployerName)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.EmployerContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.EmployerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.AppearingQualification)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.PlacementNeeded)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.OtherInterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<Enquiry>()
                .Property(e => e.RemarkByBranchManager)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.PreferTiming)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.RemarkByBranchManager)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.PsychomatricTest)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Counselling>()
                .Property(e => e.RemarkByBranchManager)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
               .Property(e => e.Title)
               .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.FollowUpType)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.FollowUpUrl)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUp>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
               .Property(e => e.Title)
               .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.MobilizerStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.StudentLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.OtherInterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<Mobilization>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
               .Property(e => e.Title)
               .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Address4)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Certified)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.CertificationNo)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Address4)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.GuardianName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.YearOfPassOut)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Marks)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.PreTrainingStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.EmploymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Promotional)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.EnquiryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.EmployerName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.EmployerContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.EmployerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.AppearingQualification)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.PlacementNeeded)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.OtherInterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.RemarkByBranchManager)
                .IsUnicode(false);

            modelBuilder.Entity<EnquirySearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                 .Property(e => e.Title)
                 .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.MobilizerStatus)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.StudentLocation)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.OtherInterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationSearchField>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.PreferTiming)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.RemarkByBranchManager)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.PsychomatricTest)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.RemarkByBm)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<CourseSearchField>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CourseSearchField>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CourseSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<CourseSearchField>()
                .Property(e => e.CourseType)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Address4)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.Certified)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.CertificationNo)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
               .Property(e => e.Remarks)
               .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallment>()
               .Property(e => e.StudentCode)
               .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallment>()
              .Property(e => e.PaymentMethod)
              .IsUnicode(false);

            modelBuilder.Entity<CourseInstallmentSearchField>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CourseInstallmentSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpHistory>()
                .Property(e => e.FollowUpType)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpHistory>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpHistory>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpHistory>()
                .Property(e => e.ClosingRemarks)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.FollowUpType)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.FollowUpURL)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationSearchField>()
               .Property(e => e.StudentCode)
               .IsUnicode(false);

            modelBuilder.Entity<RegistrationSearchField>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionSearchField>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionSearchField>()
                .Property(e => e.BatchName)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionSearchField>()
                .Property(e => e.PaidAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<AdmissionSearchField>()
                .Property(e => e.PendingAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<AdmissionSearchField>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeSearchField>()
               .Property(e => e.CandidateName)
               .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeSearchField>()
                .Property(e => e.BatchName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeSearchField>()
                .Property(e => e.PaidAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CandidateFeeSearchField>()
                .Property(e => e.PendingAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CandidateFeeSearchField>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<Module>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerAvailable>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerAvailable>()
                .Property(e => e.StartTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<TrainerAvailable>()
                .Property(e => e.EndTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<RoomAvailable>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<RoomAvailable>()
                .Property(e => e.StartTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<RoomAvailable>()
                .Property(e => e.EndTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentSearchField>()
                 .Property(e => e.CandidateName)
                 .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentSearchField>()
                .Property(e => e.BatchName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentSearchField>()
                .Property(e => e.PaidAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CandidateInstallmentSearchField>()
                .Property(e => e.PendingAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CandidateInstallmentSearchField>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentSearchField>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionGrid>()
                .Property(e => e.BatchName)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionGrid>()
                .Property(e => e.PaidAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<AdmissionGrid>()
                .Property(e => e.PendingAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<AdmissionGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<AdmissionGrid>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentGrid>()
                .Property(e => e.BatchName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateInstallmentGrid>()
                .Property(e => e.PaidAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CandidateInstallmentGrid>()
                .Property(e => e.PendingAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<CandidateInstallmentGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseHeader>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OtherFee>()
                .Property(e => e.CashMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OtherFee>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<OtherFee>()
                .Property(e => e.RupeesInWord)
                .IsUnicode(false);

            modelBuilder.Entity<OtherFee>()
                .Property(e => e.PaidTo)
                .IsUnicode(false);

            modelBuilder.Entity<OtherFee>()
                .Property(e => e.Particulars)
                .IsUnicode(false);


            modelBuilder.Entity<Project>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CentrePettyCash>()
                .Property(e => e.Particulars)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                 .Property(e => e.PaymentMode)
                 .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                .Property(e => e.FeeType)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                .Property(e => e.ChequeNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                .Property(e => e.Particulars)
                .IsUnicode(false);

            modelBuilder.Entity<CandidateFeeGrid>()
                .Property(e => e.FiscalYear)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Centre_Name)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Address4)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Taluka)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.District)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.GuardianName)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Religion)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Caste_Category)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.YearOfPassOut)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Marks)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Scheme)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Sector)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.How_Did_You_Know_About_Us)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.PreTrainingStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.EmploymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Promotional)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.EnquiryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Enquiry_Type)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Student_Type)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Batch_Time_Prefer)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.AppearingQualification)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.PlacementNeeded)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.OtherInterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.IsCounsellingDone)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.IsRegistrationDone)
                .IsUnicode(false);

            modelBuilder.Entity<EnquiryDataGrid>()
                .Property(e => e.IsAdmissionDone)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.InterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.StudentLocation)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.OtherInterestedCourse)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationDataGrid>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpDataGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpDataGrid>()
                .Property(e => e.FollowUpType)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpDataGrid>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpDataGrid>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<FollowUpDataGrid>()
                .Property(e => e.ClosingRemarks)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.VoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.CashMemo)
                .IsUnicode(false);

            modelBuilder.Entity<VoucherGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<VoucherGrid>()
                .Property(e => e.VoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VoucherGrid>()
                .Property(e => e.CashMemo)
                .IsUnicode(false);

            modelBuilder.Entity<VoucherGrid>()
                .Property(e => e.TotalDebitAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<VoucherGrid>()
                .Property(e => e.PaidTo)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.VoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.CashMemoNumbers)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.PaidTo)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Particulars)
                .IsUnicode(false);

            modelBuilder.Entity<Attendance>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<Attendance>()
                .Property(e => e.BioMetricLogTime)
                .IsUnicode(false);

            modelBuilder.Entity<Attendance>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.CourseOffered)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.PreferTiming)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.RemarkByBranchManager)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.PsychomatricTest)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.Close)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.ClosingRemark)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.RemarkByBm)
                .IsUnicode(false);

            modelBuilder.Entity<CounsellingDataGrid>()
                .Property(e => e.IsRegistrationDone)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseDataGrid>()
                .Property(e => e.VoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseDataGrid>()
                .Property(e => e.ExpenseHeader)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseDataGrid>()
                .Property(e => e.CashMemoNumbers)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseDataGrid>()
                .Property(e => e.PaidTo)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseDataGrid>()
                .Property(e => e.Particulars)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.PettyCashForCentreName)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.PettyCashParticulars)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.ExpenseParticulars)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.ExpenseCashMemoNumbers)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.ExpenseVoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.ExpensePaidTo)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.ExpenseCentreName)
                .IsUnicode(false);

            modelBuilder.Entity<PettyCashExpenseReport>()
                .Property(e => e.ExpenseHeader)
                .IsUnicode(false);

            modelBuilder.Entity<Brainstorming>()
                .Property(e => e.BeforePlanningAnswerDiscussTheseQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<EventBrainstorming>()
                .Property(e => e.DisscussionCompletedYesNo)
                .IsUnicode(false);

            modelBuilder.Entity<EventBrainstorming>()
                .Property(e => e.ReferenceDetailDocument)
                .IsUnicode(false);
            
            modelBuilder.Entity<MobilizationCentreReport>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationCentreReport>()
                .Property(e => e.CourseBooking)
                .HasPrecision(38, 2);

            modelBuilder.Entity<MobilizationCentreReport>()
                .Property(e => e.FeeCollected)
                .HasPrecision(38, 2);

            modelBuilder.Entity<Gst>()
                .Property(e => e.GstNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Gst>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationCentreReportMonthWise>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<MobilizationCentreReportMonthWise>()
                .Property(e => e.CourseBooking)
                .HasPrecision(38, 2);

            modelBuilder.Entity<MobilizationCentreReportMonthWise>()
                .Property(e => e.FeeCollected)
                .HasPrecision(38, 2);

            modelBuilder.Entity<Budget>()
                .Property(e => e.MajorGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Budget>()
                .HasMany(e => e.EventBudgets)
                .WithRequired(e => e.Budget)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventBudget>()
                .Property(e => e.SpecificHead)
                .IsUnicode(false);

            modelBuilder.Entity<EventBudget>()
                .Property(e => e.EstimatedSubtotal)
                .IsFixedLength();

            modelBuilder.Entity<Planning>()
                .Property(e => e.MajorPoint)
                .IsUnicode(false);

            modelBuilder.Entity<Planning>()
                .Property(e => e.Point)
                .IsUnicode(false);

            modelBuilder.Entity<EventPlanning>()
                .Property(e => e.Input)
                .IsUnicode(false);

            modelBuilder.Entity<EventPlanning>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventPostEvent>()
                .Property(e => e.Completed)
                .IsUnicode(false);

            modelBuilder.Entity<EventPostEvent>()
                .Property(e => e.RefernceDetail)
                .IsUnicode(false);

            modelBuilder.Entity<PostEvent>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<PostEvent>()
                .HasMany(e => e.EventPostEvents)
                .WithRequired(e => e.PostEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CentreReceiptSetting>()
                .Property(e => e.TaxYear)
                .IsUnicode(false);

            modelBuilder.Entity<CentreEnrollmentReceiptSetting>()
                .Property(e => e.TaxYear)
                .IsUnicode(false);

            modelBuilder.Entity<BatchAttendance>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceGrid>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceGrid>()
                .Property(e => e.BioMetricLogTime)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceGrid>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<AttendanceGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<BiometricAttendanceGrid>()
               .Property(e => e.StudentCode)
               .IsUnicode(false);

            modelBuilder.Entity<BiometricAttendanceGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<EventBrainStormingGrid>()
                .Property(e => e.BeforePlanningAnswerDiscussTheseQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<EventBrainStormingGrid>()
                .Property(e => e.DisscussionCompletedYesNo)
                .IsUnicode(false);

            modelBuilder.Entity<EventBrainStormingGrid>()
                .Property(e => e.ReferenceDetailDocument)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationGrid>()
                .Property(e => e.CandidateName)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationGrid>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationGrid>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<StockIssue>()
                .Property(e => e.IssuedToPerson)
                .IsUnicode(false);

            modelBuilder.Entity<StockPurchase>()
                .Property(e => e.InventoryItem)
                .IsUnicode(false);

            modelBuilder.Entity<StockPurchase>()
                .Property(e => e.Supplier)
                .IsUnicode(false);

            modelBuilder.Entity<StockPurchase>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<StudentKit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StockType>()
                .Property(e => e.Name)
                .IsUnicode(false);
            
            modelBuilder.Entity<BatchPlanner>()
                .Property(e => e.SlotType)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlanner>()
                .Property(e => e.CourseType)
                .IsUnicode(false);
            
            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StockDataGrid>()
                .Property(e => e.InventoryItem)
                .IsUnicode(false);

            modelBuilder.Entity<StockDataGrid>()
                .Property(e => e.StockTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<StockDataGrid>()
                .Property(e => e.Supplier)
                .IsUnicode(false);

            modelBuilder.Entity<StockDataGrid>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<StockDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<StockDataGrid>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<StockReportDataGrid>()
                .Property(e => e.InventoryItem)
                .IsUnicode(false);

            modelBuilder.Entity<StockReportDataGrid>()
                .Property(e => e.StockTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<StockReportDataGrid>()
                .Property(e => e.Supplier)
                .IsUnicode(false);

            modelBuilder.Entity<StockReportDataGrid>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<StockReportDataGrid>()
                .Property(e => e.IssuedToPerson)
                .IsUnicode(false);

            modelBuilder.Entity<StockReportDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<CentreFixAsset>()
                .Property(e => e.AssetCode)
                .IsUnicode(false);

            modelBuilder.Entity<CentreFixAsset>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<FixAsset>()
                .Property(e => e.Supplier)
                .IsUnicode(false);

            modelBuilder.Entity<FixAsset>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FixAsset>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<FixAsset>()
                .HasMany(e => e.CentreFixAssets)
                .WithRequired(e => e.FixAsset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FixAssetDataGrid>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetDataGrid>()
                .Property(e => e.Supplier)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetDataGrid>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetDataGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetSearchGrid>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetSearchGrid>()
                .Property(e => e.Supplier)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetSearchGrid>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetSearchGrid>()
                .Property(e => e.CentreName)
                .IsUnicode(false);

            modelBuilder.Entity<FixAssetSearchGrid>()
                .Property(e => e.SearchField)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.ClassRoomName)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.StartTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.EndTimeSpan)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.SlotType)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.CourseType)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.Course)
                .IsUnicode(false);

            modelBuilder.Entity<BatchPlannerGrid>()
                .Property(e => e.Trainer)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.FeeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.ReceiptNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.StudentCode)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.TotalPaidAmount)
                .HasPrecision(38, 2);

            modelBuilder.Entity<SummaryReport>()
                .Property(e => e.BalanceAmount)
                .HasPrecision(38, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
