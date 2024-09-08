using ClinicManagmentAPI_Repos.Models.Shared;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class Medicien : MainEntity
    {
        //lookups
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
