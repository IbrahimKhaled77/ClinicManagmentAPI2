using ClinicManagmentAPI_Repos.DTOs.MedicienRecordDTO;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagmentAPI_Repos.Interface
{
    public interface IMedicienRecordService
    {
        //Create New Medicine List
        Task CreateNewMedicineList(CreateMedicienRecordDTO dto);
        //Get Medicine List Details by UserID
        Task<List<MedicienRecordDetailsDTO>> GetMedicineListDetailsByUserID(int userID);
        //Get Medicine List Info by UserID
        Task<List<MedicienRecordInformationDTO>> GetMedicineListInfoByUserID(int userID);
        //Update Medicine List
        Task UpdateMedicineList(UpdateMedicienRecordDTO dto);
        //Delete Medicine List
        Task DeleteMedicineList(UpdateMedicienRecordDTO dto);
        
    }
}
