using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.MedicalProcedureServiceDTO;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class MedicalProcedureService : IMedicalProcedureService
    {
        private readonly ClinicManagementDbContext _context;
        public MedicalProcedureService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task AddMedicalProcedure(CreateMedicalProcedureDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMedicalProcedure(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllMedicalProcedure()
        {
            throw new NotImplementedException();
        }

        public Task GetMedicalProcedureById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicalProcedure(UpdateMedicalProcedureDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
