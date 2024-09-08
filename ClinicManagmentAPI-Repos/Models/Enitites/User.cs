using ClinicManagmentAPI_Repos.Models.Shared;
using System.Diagnostics.Contracts;
using System;
using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.Models.Entities
{
    public class User : MainEntity
    {
        public string NationalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfileImage { get; set; }
        public string Specialization { get; set; }
        public string MedicalStatus { get; set; }
        public bool IsHaveDiseases { get; set; }
        public DiesesType? DiesesType { get; set; }
        public Role Role { get; set; }
        public Gender Gender { get; set; }

    }
    public class Employee : User
    {
        public List<MedicalReport> MedicalReports { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Invoice> Invoices { get; set; } 
    }
    public class Client : User
    {
        public List<MedicalReport> MedicalReports { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
    public class Doctor : User
    {
        public List<MedicalReport> MedicalReports { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
