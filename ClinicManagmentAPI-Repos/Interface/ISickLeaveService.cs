using ClinicManagmentAPI_Repos.DTO.SickLeaveDTO;
using ClinicManagmentAPI_Repos.Models.Entities;

namespace ClinicManagmentAPI.Interface
{
    public interface ISickLeaveService
    {
        Task<int> CreateSickLeave(CreateSickLeaveDTO dTO);
        Task<SickLeave> GetSickLeaveById(int id);
        Task<List<SickLeaveDTOCard>> GetAllSickLeave();
        Task UpdateSickLeave(UpdateSickLeaveDTO dTO);
        Task DeleteSickLeave(int id);

    }
}
