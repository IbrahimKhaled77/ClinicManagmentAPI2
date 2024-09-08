using ClinicManagmentAPI_Repos.DTOs.Appointment;

namespace ClinicManagmentAPI_Repos.Interface
{
    public interface IApointmentService
    {
        Task AddNewAppointment(CreateAppointmentDTO dto);

        Task<List<GetAllAppointmentDTO>> AllAppointment(DateTime? date); // DateTime? date To allow filtering on dates  

        Task UpdateExistedAppointment(UpdateAppoitmentDTO dto, int id);

        Task DeleteAppointment(int id);
    }
}
