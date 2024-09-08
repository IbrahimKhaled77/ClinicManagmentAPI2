using ClinicManagmentAPI_Repos.Models.Shared;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class Appointment : MainEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? DoctorId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
