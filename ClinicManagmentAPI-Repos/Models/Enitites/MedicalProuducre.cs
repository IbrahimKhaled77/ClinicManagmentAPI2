using ClinicManagmentAPI_Repos.Models.Shared;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class MedicalProuducre : MainEntity
    {
        //lookups
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
    }
}
