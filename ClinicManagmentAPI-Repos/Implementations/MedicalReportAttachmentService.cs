using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.MedicalReportAttachementDTO;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class MedicalReportAttachmentService : IMedicalReportAttachmentService
    {
        private readonly ClinicManagementDbContext _context;
        public MedicalReportAttachmentService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task CreatrMedicalReportAttachement(CreateMedicalReportAttachementDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeletMedicalReportAttachement(DeleteMedicalReportAttachementDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicalReportAttachement(UpdateMedicalReportAttachementDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
