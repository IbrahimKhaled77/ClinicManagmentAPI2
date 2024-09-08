using ClinicManagmentAPI_Repos.DTOs.MedicalProcedureServiceDTO;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI_Repos.Interface
{
    public interface IMedicalProcedureService
    {
        Task AddMedicalProcedure(CreateMedicalProcedureDTO dto);
        Task  UpdateMedicalProcedure(UpdateMedicalProcedureDTO dto);
        Task  GetMedicalProcedureById(int id);
        Task  GetAllMedicalProcedure();
        Task  DeleteMedicalProcedure(int id);
    }
}
