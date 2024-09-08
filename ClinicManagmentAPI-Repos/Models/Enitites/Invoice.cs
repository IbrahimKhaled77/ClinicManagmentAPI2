using ClinicManagmentAPI_Repos.Models.Shared;
using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class Invoice : MainEntity
    {
        public double Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public DiscountType DiscountType { get; set; }
        public double? DiscountAmount { get; set; }
        public double? PriceAfterDiscount { get; set; }
        public string DiscountReason { get; set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
    }
}
