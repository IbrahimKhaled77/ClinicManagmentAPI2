using ClinicManagmentAPI_Repos.Models.Entities;
using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.DTOs.MedicalReportAttachementDTO
{
    public class CreateMedicalReportAttachementDTO
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public AttachementType AttachementType { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
        public virtual User Employee { get; set; }
        public virtual User Doctor { get; set; }
    }
}
