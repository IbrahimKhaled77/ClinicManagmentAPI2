using ClinicManagmentAPI_Repos.Models.Shared;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class LaborityTest : MainEntity
    {
        //lookups
        public string Name { get; set; }
        public string Purpose { get; set; }
    }
}
