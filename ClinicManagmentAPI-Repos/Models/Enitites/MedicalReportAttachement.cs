using ClinicManagmentAPI_Repos.Models.Shared;
using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class MedicalReportAttachement : MainEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public AttachementType AttachementType { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
    }
}
