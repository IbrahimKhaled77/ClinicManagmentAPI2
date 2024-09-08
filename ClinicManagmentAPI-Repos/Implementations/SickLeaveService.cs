using ClinicManagementAPI.Context;
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI_Repos.DTO.SickLeaveDTO;
using ClinicManagmentAPI_Repos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class SickLeaveService : ISickLeaveService
    {

        private readonly ClinicManagementDbContext _context;
        public SickLeaveService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task<int> CreateSickLeave(CreateSickLeaveDTO dTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSickLeave(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SickLeaveDTOCard>> GetAllSickLeave()
        {
            throw new NotImplementedException();
        }

        public Task<SickLeave> GetSickLeaveById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSickLeave(UpdateSickLeaveDTO dTO)
        {
            throw new NotImplementedException();
        }
    }
}
