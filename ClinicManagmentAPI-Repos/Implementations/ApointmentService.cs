using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.Appointment;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class ApointmentService : IApointmentService
    {
        private readonly ClinicManagementDbContext _context;
        public ApointmentService(ClinicManagementDbContext context)
        {
            _context = context;
        }

        public Task AddNewAppointment(CreateAppointmentDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllAppointmentDTO>> AllAppointment(DateTime? date)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExistedAppointment(UpdateAppoitmentDTO dto, int id)
        {
            throw new NotImplementedException();
        }
    }
}
