using ClinicManagmentAPI_Repos.Models.Shared;
using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class MedicalReport : MainEntity
    {
        public DateTime Date { get; set; }
        public CaseType CaseType { get; set; }
        public string MainDescription { get; set; }
        public string Diagnosis { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DoctorId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual List<SickLeave> SickLeaves { get; set; }
        public virtual List<MedicienRecord> MedicienRecords { get; set; }
        public virtual List<MedicalReportLaborityTest> MedicalReportLaborityTests { get; set; }
        public virtual List<MedicalProuducre> MedicalProuducres { get; set; }   
        public virtual List<MedicalReportAttachement> MedicalReportAttachements { get; set; }
    }
}
