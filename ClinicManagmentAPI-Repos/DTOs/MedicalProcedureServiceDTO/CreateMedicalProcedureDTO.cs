using ClinicManagmentAPI_Repos.Models.Entities;

namespace ClinicManagmentAPI_Repos.DTOs.MedicalProcedureServiceDTO
{
    public class CreateMedicalProcedureDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

    }
}
