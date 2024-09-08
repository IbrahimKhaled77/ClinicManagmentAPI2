using ClinicManagmentAPI_Repos.Models.Shared;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class SickLeave : MainEntity
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Recommendations { get; set; }
        public string Reason { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
    }
}
