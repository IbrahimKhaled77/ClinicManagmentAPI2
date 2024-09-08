using ClinicManagementAPI.Context;
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI_Repos.DTOs.MedicalReprtLaborityTesst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class MedicalReportLaborityTestService : IMedicalReportLaborityTestService
    {
        private readonly ClinicManagementDbContext _context;
        public MedicalReportLaborityTestService(ClinicManagementDbContext context)
        {
            _context = context;
        }

        public Task GetAllMedicalReportLaborityTest()
        {
            throw new NotImplementedException();
        }

        public Task GetMedicalReportLaborityTestById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task CreateMedicalReportLaborityTest(MedicalReportLaborityTestCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
