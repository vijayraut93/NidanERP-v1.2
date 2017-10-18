﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Nidan.Entity;
using Nidan.Entity.Dto;


namespace Nidan.Data.Interfaces
{
    public interface INidanDataService
    {

        // Create
        Personnel CreatePersonnel(int organisationId, Personnel personnel);
        T Create<T>(int organisationId, T t) where T : class;
        void Create<T>(int organisationId, IEnumerable<T> t) where T : class;

        AbsenceType CreateAbsenceType(int organisationId, AbsenceType absenceType);

        Enquiry CreateEnquiry(int organisationId, Enquiry enquiry);

        Mobilization CreateMobilization(int organisationId, Mobilization mobilization);

        Trainer CreateTrainer(int organisationId, Trainer trainer);

        AreaOfInterest CreateAreaOfInterest(int organisationId, AreaOfInterest areaOfInterest);
        Centre CreateCentre(int organisationId, Centre centre);
        Batch CreateBatch(int organisationId, Batch batch);

        Question CreateQuestion(int organisationId, Question question);
        Event CreateEvent(int organisationId, Event eventplan);
        Brainstorming CreateBrainstorming(int organisationId, Brainstorming brainstorming);
        Planning CreatePlanning(int organisationId, Planning planning);
        Budget CreateBudget(int organisationId, Budget budget);
        Eventday CreateEventday(int organisationId, Eventday eventday);
        PostEvent CreatePostEvent(int organisationId, PostEvent postevent);
        Course CreateCourse(int organisationId, Course course);
        CourseInstallment CreateCourseInstallment(int organisationId, CourseInstallment courseInstallment);
        EventPostEvent CreateEventPostEvent(int organisationId, EventPostEvent eventPostEvent);

        FollowUp CreateFollowUp(int organisationId, FollowUp followUp);
        Subject CreateSubject(int organisationId, Subject subject);
        Session CreateSession(int organisationId, Session session);
        Room CreateRoom(int organisationId, Room room);
        BatchDay CreateBatchDay(int organisationId, BatchDay batchDay);
        Admission CreateAdmission(int organisationId, Admission admission);
        Counselling CreateCounselling(int organisationId, Counselling counselling);
        CandidateFee CreateCandidateFee(int organisationId, CandidateFee candidateFee);
        Module CreateModule(int organisationId, Module module);
        Attendance CreateAttendance(int organisationId, Attendance attendance);
        BatchAttendance CreateBatchAttendance(int organisationId, BatchAttendance batchAttendance);
        bool CreateEventBrainstorming(int organisationId, List<EventBrainstorming> eventBrainstorming);
        EventBudget CreateEventBudget(int organisationId, EventBudget eventBudget);
        EventPlanning CreateEventPlanning(int organisationId, EventPlanning eventPlanning);
        BatchPlanner CreateBatchPlanner(int organisationId, BatchPlanner batchPlanner);
        CentreFixAsset CreateCentreFixAsset(int organisationId, CentreFixAsset centreFixAsset);

        // Retrieve
        PagedResult<Event> RetrieveEvents(int organisationId, Expression<Func<Event, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Event RetrieveEvent(int organisationId, int eventId, Expression<Func<Event, bool>> predicate);
        AbsenceType RetrieveAbsenceType(int organisationId, int absenceTypeId, Expression<Func<AbsenceType, bool>> predicate);
        PagedResult<AbsenceType> RetrieveAbsenceTypes(int organisationId, Expression<Func<AbsenceType, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        IEnumerable<Colour> RetrieveColours(Expression<Func<Colour, bool>> predicate);
        IEnumerable<Host> RetrieveHosts();
        IEnumerable<Organisation> RetrieveOrganisations();
        Personnel RetrievePersonnel(int organisationId, int personnelId, Expression<Func<Personnel, bool>> predicate);
        IEnumerable<Personnel> RetrievePersonnel(int organisationId, IEnumerable<int> companyIds, IEnumerable<int> departmentIds, IEnumerable<int> divisionIds);
        PagedResult<Personnel> RetrievePersonnel(int organisationId, Expression<Func<Personnel, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        UserAuthorisationFilter RetrieveUserAuthorisation(string aspNetUserId);
        PagedResult<PersonnelSearchField> RetrievePersonnelBySearchKeyword(int organisationId, string searchKeyword, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Question> RetrieveQuestions(int organisationId, Expression<Func<Question, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        List<T> Retrieve<T>(int organisationId, Expression<Func<T, bool>> predicate) where T : class;
        bool PersonnelEmploymentHasAbsences(int organisationId, int personnelId, int employmentId);
        Question RetrieveQuestion(int organisationId, int questionId, Expression<Func<Question, bool>> predicate);
        PagedResult<Enquiry> RetrieveEnquiries(int organisationId, Expression<Func<Enquiry, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Enquiry RetrieveEnquiry(int organisationId, int enquiryId, Expression<Func<Enquiry, bool>> predicate);
        PagedResult<Mobilization> RetrieveMobilizations(int organisationId, Expression<Func<Mobilization, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Mobilization RetrieveMobilization(int organisationId, int mobilizationId, Expression<Func<Mobilization, bool>> predicate);
        AreaOfInterest RetrieveAreaOfInterest(int organisationId, int areaOfInterestId, Expression<Func<AreaOfInterest, bool>> predicate);
        PagedResult<AreaOfInterest> RetrieveAreaOfInterests(int organisationId, Expression<Func<AreaOfInterest, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<FollowUp> RetrieveFollowUps(int organisationId, Expression<Func<FollowUp, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        FollowUp RetrieveFollowUp(int organisationId, int followUpId, Expression<Func<FollowUp, bool>> predicate);
        PagedResult<Mobilization> RetrieveMobilizationBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<Mobilization, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<EnquirySearchField> RetrieveEnquiryBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<EnquirySearchField, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Centre> RetrieveCentres(int organisationId, Expression<Func<Centre, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Centre RetrieveCentre(int organisationId, int centreId, Expression<Func<Centre, bool>> predicate);
        Course RetrieveCourse(int organisationId, int courseId, Expression<Func<Course, bool>> predicate);
        PagedResult<Course> RetrieveCourseBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<Course, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Course> RetrieveCourses(int organisationId, Expression<Func<Course, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Counselling> RetrieveCounsellings(int organisationId, Expression<Func<Counselling, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Counselling RetrieveCounselling(int organisationId, int counsellingId, Expression<Func<Counselling, bool>> predicate);
        PagedResult<Batch> RetrieveBatches(int organisationId, Expression<Func<Batch, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Batch RetrieveBatch(int organisationId, int batchId, Expression<Func<Batch, bool>> predicate);
        PagedResult<Counselling> RetrieveCounsellingBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<Counselling, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Brainstorming RetrieveBrainstorming(int organisationId, int brainstormingId, Expression<Func<Brainstorming, bool>> predicate);
        PagedResult<Brainstorming> RetrieveBrainstormings(int organisationId, Expression<Func<Brainstorming, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Planning RetrievePlanning(int organisationId, int planningId, Expression<Func<Planning, bool>> predicate);
        PagedResult<Planning> RetrievePlannings(int organisationId, Expression<Func<Planning, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Budget RetrieveBudget(int organisationId, int budgetId, Expression<Func<Budget, bool>> predicate);
        PagedResult<Budget> RetrieveBudgets(int organisationId, Expression<Func<Budget, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Eventday RetrieveEventday(int organisationId, int eventdayId, Expression<Func<Eventday, bool>> predicate);
        PagedResult<Eventday> RetrieveEventdays(int organisationId, Expression<Func<Eventday, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PostEvent RetrievePostEvent(int organisationId, int postEventId, Expression<Func<PostEvent, bool>> predicate);
        PagedResult<PostEvent> RetrievePostEvents(int organisationId, Expression<Func<PostEvent, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Template RetrieveTemplateDetails(int organisationId, string name);
        PagedResult<Trainer> RetrieveTrainers(int organisationId, Expression<Func<Trainer, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Trainer RetrieveTrainer(int organisationId, int trainerId, Expression<Func<Trainer, bool>> predicate);
        PagedResult<Trainer> RetrieveTrainerBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<Trainer, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Registration> RetrieveRegistrations(int organisationId, Expression<Func<Registration, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CourseInstallment> RetrieveCourseInstallments(int organisationId, Expression<Func<CourseInstallment, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CourseInstallment RetrieveCourseInstallment(int organisationId, int courseInstallmentId, Expression<Func<CourseInstallment, bool>> predicate);
        PagedResult<CourseInstallment> RetrieveCourseInstallmentBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<CourseInstallment, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Subject> RetrieveSubjects(int organisationId, Expression<Func<Subject, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Subject RetrieveSubject(int organisationId, int subjectId, Expression<Func<Subject, bool>> predicate);
        PagedResult<Holiday> RetrieveHolidays(int organisationId, Expression<Func<Holiday, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Holiday RetrieveHoliday(int organisationId, int holidayId, Expression<Func<Holiday, bool>> predicate);
        PagedResult<Session> RetrieveSessions(int organisationId, Expression<Func<Session, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Session RetrieveSession(int organisationId, int sessionId, Expression<Func<Session, bool>> predicate);
        PagedResult<Room> RetrieveRooms(int organisationId, Expression<Func<Room, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Room RetrieveRoom(int organisationId, int roomId, Expression<Func<Room, bool>> predicate);
        BatchDay RetrieveBatchDay(int organisationId, int batchDayId, Expression<Func<BatchDay, bool>> predicate);
        PagedResult<BatchDay> RetrieveBatchDays(int organisationId, Expression<Func<BatchDay, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        IEnumerable<EnquiryCourse> RetrieveEnquiryCourses(int organisationId, int centreId, int enquiryId);
        IEnumerable<SubjectCourse> RetrieveSubjectCourses(int organisationId, Expression<Func<SubjectCourse, bool>> predicate);
        IEnumerable<SubjectTrainer> RetrieveSubjectTrainers(int organisationId, int subjectId);
        PagedResult<CentreCourse> RetrieveCentreCourses(int organisationId, int centreId, List<OrderBy> orderBy = null, Paging paging = null);
        IEnumerable<BatchTrainer> RetrieveBatchTrainers(int organisationId, int batchId);
        PagedResult<CentreCourseInstallment> RetrieveCentreCourseInstallments(int organisationId, int centreId, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CentreScheme> RetrieveCentreSchemes(int organisationId, int centreId, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CentreSector> RetrieveCentreSectors(int organisationId, int centreId, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Scheme> RetrieveSchemes(int organisationId, Expression<Func<Scheme, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Sector> RetrieveSectors(int organisationId, Expression<Func<Sector, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Admission> RetrieveAdmissions(int organisationId, Expression<Func<Admission, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Admission RetrieveAdmission(int organisationId, int admissionId, Expression<Func<Admission, bool>> predicate);
        PagedResult<CandidateFee> RetrieveCandidateFees(int organisationId, Expression<Func<CandidateFee, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CandidateFee RetrieveCandidateFee(int organisationId, int candidateFeeId, Expression<Func<CandidateFee, bool>> predicate);
        PagedResult<CandidateFeeSearchField> RetrieveCandidateFeeBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<CandidateFeeSearchField, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        IEnumerable<CentreCourse> RetrieveCentreCourses(int organisationId, int centreId, Expression<Func<CentreCourse, bool>> predicate);
        IEnumerable<CentreScheme> RetrieveCentreSchemes(int organisationId, int centreId, Expression<Func<CentreScheme, bool>> predicate);
        IEnumerable<CentreSector> RetrieveCentreSectors(int organisationId, int centreId, Expression<Func<CentreSector, bool>> predicate);
        IEnumerable<RoomAvailable> RetrieveRoomAvailables(int organisationId, int centreId, Expression<Func<RoomAvailable, bool>> predicate);
        IEnumerable<TrainerAvailable> RetrieveTrainerAvailables(int organisationId, int centreId, Expression<Func<TrainerAvailable, bool>> predicate);
        PagedResult<CandidateInstallment> RetrieveCandidateInstallments(int organisationId, Expression<Func<CandidateInstallment, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CandidateInstallment RetrieveCandidateInstallment(int organisationId, int candidateInstallmentId, Expression<Func<CandidateInstallment, bool>> predicate);
        Registration RetrieveRegistration(int organisationId, int registrationId, Expression<Func<Registration, bool>> predicate);
        Registration RetrieveRegistration(int organisationId, int centreId, int registrationId, Expression<Func<Registration, bool>> predicate);
        PagedResult<FollowUpHistory> RetrieveFollowUpHistories(int organisationId, Expression<Func<FollowUpHistory, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        FollowUpHistory RetrieveFollowUpHistory(int organisationId, int followUpHistoryId, Expression<Func<FollowUpHistory, bool>> predicate);
        PagedResult<FollowUp> RetrieveFollowUpBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<FollowUp, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<RegistrationGrid> RetrieveRegistrationBySearchKeyword(int organisationId, Expression<Func<RegistrationGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<AdmissionGrid> RetrieveAdmissionBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<AdmissionGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Module> RetrieveModules(int organisationId, Expression<Func<Module, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Module RetrieveModule(int organisationId, int moduleId, Expression<Func<Module, bool>> predicate);
        PagedResult<CandidateInstallmentSearchField> RetrieveCandidateInstallmentBySearchKeyword(int organisationId, string searchKeyword, Expression<Func<CandidateInstallmentSearchField, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<AdmissionGrid> RetrieveAdmissionGrid(int organisationId, Expression<Func<AdmissionGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CandidateInstallmentGrid> RetrieveCandidateInstallmentGrid(int organisationId, Expression<Func<CandidateInstallmentGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<ExpenseHeader> RetrieveExpenseHeaders(int organisationId, Expression<Func<ExpenseHeader, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        ExpenseHeader RetrieveExpenseHeader(int organisationId, int expenseHeaderId, Expression<Func<ExpenseHeader, bool>> predicate);
        PagedResult<OtherFee> RetrieveOtherFees(int organisationId, int centreId, Expression<Func<OtherFee, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        OtherFee RetrieveOtherFee(int organisationId, int centreId, int otherFeeId, Expression<Func<OtherFee, bool>> predicate);
        PagedResult<Project> RetrieveProjects(int organisationId, Expression<Func<Project, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Project RetrieveProject(int organisationId, int projectId, Expression<Func<Project, bool>> predicate);
        PagedResult<CentrePettyCash> RetrieveCentrePettyCashs(int organisationId, int centreId, Expression<Func<CentrePettyCash, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CentrePettyCash RetrieveCentrePettyCash(int organisationId, int centreId, int centrePettyCashId, Expression<Func<CentrePettyCash, bool>> predicate);
        PagedResult<CandidateFeeGrid> RetrieveCandidateFeeGrid(int organisationId, Expression<Func<CandidateFeeGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<MobilizationDataGrid> RetrieveMobilizationDataGrid(int organisationId, Expression<Func<MobilizationDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<EnquiryDataGrid> RetrieveEnquiryDataGrid(int organisationId, Expression<Func<EnquiryDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<FollowUpDataGrid> RetrieveFollowUpDataGrid(int organisationId, Expression<Func<FollowUpDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Voucher> RetrieveVouchers(int organisationId, int centreId, Expression<Func<Voucher, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Voucher RetrieveVoucher(int organisationId, int centreId, int voucherId, Expression<Func<Voucher, bool>> predicate);
        PagedResult<VoucherGrid> RetrieveVoucherGrids(int organisationId, int centreId, Expression<Func<VoucherGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<RegistrationGrid> RetrieveRegistrationGrid(int organisationId, Expression<Func<RegistrationGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<Expense> RetrieveExpenses(int organisationId, int centreId, Expression<Func<Expense, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Expense RetrieveExpense(int organisationId, int centreId, int expenseId, Expression<Func<Expense, bool>> predicate);
        IEnumerable<ExpenseProject> RetrieveExpenseProjects(int organisationId, int centreId, int expenseId);
        CentreVoucherNumber RetrieveCentreVoucherNumber(int organisationId, int centreId, Expression<Func<CentreVoucherNumber, bool>> predicate);
        PagedResult<Attendance> RetrieveAttendances(int organisationId, Expression<Func<Attendance, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Attendance RetrieveAttendance(int organisationId, int attendanceId, Expression<Func<Attendance, bool>> predicate);
        PagedResult<BatchAttendance> RetrieveBatchAttendances(int organisationId, Expression<Func<BatchAttendance, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        BatchAttendance RetrieveBatchAttendance(int organisationId, int batchattendanceId, Expression<Func<BatchAttendance, bool>> predicate);
        PagedResult<AttendanceGrid> RetrieveAttendanceGrid(int organisationId, Expression<Func<AttendanceGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CounsellingDataGrid> RetrieveCounsellingGrid(int organisationId, Expression<Func<CounsellingDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<ExpenseDataGrid> RetrieveExpenseDataGrid(int organisationId, Expression<Func<ExpenseDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<MobilizationDataGrid> RetrieveMobilizationDataGrid(int organisationId, string searchKeyword, Expression<Func<MobilizationDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<PettyCashExpenseReport> RetrievePettyCashExpenseReports(int organisationId, Expression<Func<PettyCashExpenseReport, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<EventBrainstorming> RetrieveEventBrainstormings(int organisationId, Expression<Func<EventBrainstorming, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        EventBrainstorming RetrieveEventBrainstorming(int organisationId, int eventBrainstormingId, Expression<Func<EventBrainstorming, bool>> predicate);
        PagedResult<MobilizationCentreReportMonthWise> RetriveMobilizationCountReportByMonthAndYear(int organisationId, int centreId, Expression<Func<MobilizationCentreReportMonthWise, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<MobilizationCentreReport> RetriveMobilizationCountReportByDate(int organisationId, int centreId, Expression<Func<MobilizationCentreReport, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<MobilizationCentreReportMonthWise> RetriveMobilizationCountReportByMonthWise(int organisationId, Expression<Func<MobilizationCentreReportMonthWise, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Gst RetrieveGst(int organisationId, Expression<Func<Gst, bool>> predicate);
        PagedResult<Gst> RetrieveGsts(int organisationId, Expression<Func<Gst, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        EventBudget RetrieveEventBudget(int organisationId, int centreId, int eventBudgetId, Expression<Func<EventBudget, bool>> predicate);
        PagedResult<EventBudget> RetrieveEventBudgets(int organisationId, int centreId, Expression<Func<EventBudget, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        EventPlanning RetrieveEventPlanning(int organisationId, int centreId, int eventPlanningId, Expression<Func<EventPlanning, bool>> predicate);
        PagedResult<EventPlanning> RetrieveEventPlannings(int organisationId, int centreId, Expression<Func<EventPlanning, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        EventPostEvent RetrieveEventPostEvent(int organisationId, int centreId, int eventPostEventId, Expression<Func<EventPostEvent, bool>> predicate);
        PagedResult<EventPostEvent> RetrieveEventPostEvents(int organisationId, int centreId, Expression<Func<EventPostEvent, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CentreReceiptSetting RetrieveCentreReceiptSetting(int organisationId, Expression<Func<CentreReceiptSetting, bool>> predicate);
        PagedResult<CentreReceiptSetting> RetrieveCentreReceiptSettings(int organisationId, Expression<Func<CentreReceiptSetting, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CentreEnrollmentReceiptSetting> RetrieveCentreEnrollmentReceiptSettings(int organisationId, Expression<Func<CentreEnrollmentReceiptSetting, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CentreEnrollmentReceiptSetting RetrieveCentreEnrollmentReceiptSetting(int organisationId, Expression<Func<CentreEnrollmentReceiptSetting, bool>> predicate);
        PagedResult<BiometricAttendanceGrid> RetrieveBiometricAttendanceGrid(int organisationId, Expression<Func<BiometricAttendanceGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<EventBrainStormingGrid> RetrieveEventBrainStormingGrid(int organisationId, Expression<Func<EventBrainStormingGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<StockPurchase> RetrieveStockPurchases(int organisationId, int centreId, Expression<Func<StockPurchase, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        StockPurchase RetrieveStockPurchase(int organisationId, int stockPurchaseId, Expression<Func<StockPurchase, bool>> predicate);
        PagedResult<StockIssue> RetrieveStockIssues(int organisationId, int centreId, Expression<Func<StockIssue, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        StockIssue RetrieveStockIssue(int organisationId, int centreId, int stockIssueId, Expression<Func<StockIssue, bool>> predicate);
        PagedResult<StockDataGrid> RetrieveStockDataGrid(int organisationId, Expression<Func<StockDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<StockDataGrid> RetrieveStockDataGrid(int organisationId, string searchKeyword, Expression<Func<StockDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<FixAssetSearchGrid> RetrieveFixAssets(int organisationId, Expression<Func<FixAssetSearchGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        FixAsset RetrieveFixAsset(int organisationId, int fixAssetId, Expression<Func<FixAsset, bool>> predicate);
        PagedResult<FixAssetSearchGrid> RetrieveFixAssets(int organisationId, string searchKeyword, Expression<Func<FixAssetSearchGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CentreFixAsset> RetrieveCentreFixAssets(int organisationId, int fixAssetId, Expression<Func<CentreFixAsset, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<CentreFixAsset> RetrieveCentreFixAsset(int organisationId, Expression<Func<CentreFixAsset, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<StockReportDataGrid> RetrieveStockReportDataGrid(int organisationId, Expression<Func<StockReportDataGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<BatchPlanner> RetrieveBatchPlanners(int organisationId, Expression<Func<BatchPlanner, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        BatchPlanner RetrieveBatchPlanner(int organisationId, int batchPlannerId, Expression<Func<BatchPlanner, bool>> predicate);
        BatchPlannerDay RetrieveBatchPlannerDay(int organisationId, int batchPlannerDayId, Expression<Func<BatchPlannerDay, bool>> predicate);
        PagedResult<BatchPlannerDay> RetrieveBatchPlannerDays(int organisationId, Expression<Func<BatchPlannerDay, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        CentreProductSetting RetrieveCentreProductSetting(int organisationId, Expression<Func<CentreProductSetting, bool>> predicate);
        PagedResult<CentreProductSetting> RetrieveCentreProductSettings(int organisationId, Expression<Func<CentreProductSetting, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<BatchPlannerGrid> RetrieveBatchPlannerGrids(int organisationId, Expression<Func<BatchPlannerGrid, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<SummaryReport> RetrieveSummaryReports(int organisationId, int centreId, Expression<Func<SummaryReport, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);

        // Update
        T UpdateEntityEntry<T>(T t) where T : class;
        T UpdateOrganisationEntityEntry<T>(int organisationId, T t) where T : class;
        // Delete
        void Delete<T>(int organisationId, Expression<Func<T, bool>> predicate) where T : class;
        void DeleteList<T>(int organisationId, Expression<Func<T, bool>> predicate) where T : class;


        //Document
        IEnumerable<DocumentType> RetrieveDocumentTypes(int organisationId);
        IEnumerable<Document> RetrieveDocuments(int organisationId, int centreId, string category, string studentCode);
        PagedResult<Document> RetrieveDocuments(int organisationId, Expression<Func<Document, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        PagedResult<DocumentType> RetrieveDocumentTypes(int organisationId, Expression<Func<DocumentType, bool>> predicate, List<OrderBy> orderBy = null, Paging paging = null);
        Document RetrieveDocument(int organisationId, Guid documentGuid);

    }
}
