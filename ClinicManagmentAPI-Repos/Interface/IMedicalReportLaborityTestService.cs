using ClinicManagmentAPI_Repos.DTOs.MedicalReprtLaborityTesst;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI.Interface
{
    public interface IMedicalReportLaborityTestService
    {
        Task GetAllMedicalReportLaborityTest();
        Task GetMedicalReportLaborityTestById(int Id);
        Task CreateMedicalReportLaborityTest(MedicalReportLaborityTestCreateDTO dto);
        Task UpdateMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto);
        Task DeleteMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto);
    }
}
