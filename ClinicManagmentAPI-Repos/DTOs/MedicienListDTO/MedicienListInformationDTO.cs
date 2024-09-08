namespace ClinicManagmentAPI_Repos.DTOs.MedicienRecordDTO
{
    public class MedicienRecordInformationDTO
    {
        public int MedicienRecordId { get; set; }
        public string UserName { get; set; }
        public string MedicienName { get; set; }
        public int QTN { get; set; }
        public int Dose { get; set; }
        public int PerHour { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
