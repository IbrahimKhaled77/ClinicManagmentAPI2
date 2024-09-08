using ClinicManagmentAPI_Repos.Models.Shared;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class MedicienRecord : MainEntity
    {
        //corrected 
        public int UserId { get; set; }
        public int MedicienId { get; set; }
        public int QTN { get; set; }
        public int Dose { get; set; }
        public int PerHour { get; set; }
        public virtual Medicien Medicien { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
    }
}
