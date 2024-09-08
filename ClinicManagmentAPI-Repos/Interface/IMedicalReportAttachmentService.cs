using ClinicManagmentAPI_Repos.DTOs.MedicalReportAttachementDTO;

namespace ClinicManagmentAPI_Repos.Interface
{
    public interface IMedicalReportAttachmentService
    {
        public Task CreatrMedicalReportAttachement(CreateMedicalReportAttachementDTO dto);
        public Task UpdateMedicalReportAttachement(UpdateMedicalReportAttachementDTO dto);
        public Task DeletMedicalReportAttachement( DeleteMedicalReportAttachementDTO dto);

    }
}
