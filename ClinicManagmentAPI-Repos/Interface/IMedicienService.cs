using ClinicManagmentAPI_Repos.DTOs.MedicienDTO;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI_Repos.Interface
{
    public interface IMedicienService
    {
        Task GetMedicienById(int Id);
        Task GetAllMedicien();
        Task CreateMedicien(CreateMedicienDTO dto);
        Task UpdateMedicien(UpdateMedicienDTO dto);
        Task DeleteMedicien(int Id);
    }
}
