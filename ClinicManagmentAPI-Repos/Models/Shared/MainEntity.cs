
using ClinicManagmentAPI_Repos.Models.Entities;

namespace ClinicManagmentAPI_Repos.Models.Shared
{
    public class MainEntity
    {
        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatorUser { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsDeleted { get; set; }


    }
}
