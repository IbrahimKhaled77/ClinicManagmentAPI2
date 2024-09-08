using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.MedicienDTO;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class MedicienService : IMedicienService
    {

        private readonly ClinicManagementDbContext _context;
        public MedicienService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task CreateMedicien(CreateMedicienDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMedicien(int Id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllMedicien()
        {
            throw new NotImplementedException();
        }

        public Task GetMedicienById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicien(UpdateMedicienDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
