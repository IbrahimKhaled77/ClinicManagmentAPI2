using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.MedicienRecordDTO;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class MedicienRecordService : IMedicienRecordService
    {

        private readonly ClinicManagementDbContext _context;
        public MedicienRecordService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task CreateNewMedicineList(CreateMedicienRecordDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMedicineList(UpdateMedicienRecordDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicienRecordDetailsDTO>> GetMedicineListDetailsByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicienRecordInformationDTO>> GetMedicineListInfoByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicineList(UpdateMedicienRecordDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
