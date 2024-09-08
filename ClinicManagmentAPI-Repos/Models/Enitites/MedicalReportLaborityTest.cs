using ClinicManagmentAPI_Repos.Models.Shared;
using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class MedicalReportLaborityTest : MainEntity
    {
        public int MedicalReportId { get; set; }
        public Servity Servity { get; set; }   
        public string TestResult { get; set; }
        public string SampleType { get; set; }
        public int NumberOfTests { get; set; }
        public string TechnicianName { get; set; }
        public virtual LaborityTest LaborityTest { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }

    }
}
