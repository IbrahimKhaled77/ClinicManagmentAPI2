using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class MedicalReportService : IMedicalReportService
    {

        private readonly ClinicManagementDbContext _context;
        public MedicalReportService(ClinicManagementDbContext context)
        {
            _context = context;
        }

        public Task CreateMedicalReport(CreateMedicalReportDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMedicalReport(int id, UpdateMedicalReportDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetMedicalReportDTO>> GetAllMedicalReports()
        {
            throw new NotImplementedException();
        }

        public Task<GetMedicalReportDTO> GetMedicalReportById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicalReport(int id, UpdateMedicalReportDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
