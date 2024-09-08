namespace ClinicManagmentAPI_Repos.DTOs.MedicienRecordDTO
{
    public class UpdateMedicienRecordDTO
    {
        public int MedicienRecordId { get; set; }
        public int UserId { get; set; }
        public int MedicienId { get; set; }
        public int QTN { get; set; }
        public int Dose { get; set; }
        public int PerHour { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
