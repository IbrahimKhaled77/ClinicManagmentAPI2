﻿using static ClinicManagmentAPI_Repos.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.DTOs.UserDTO
{
    public class UpdateUserDto
    {
        public int Id { get; set; }
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
        public DiesesType DiesesType { get; set; }
        public Role Role { get; set; }
        public Gender Gender { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public int ModifiedUser { get; set; }
        public bool IsDeleted { get; set; }
    }
}
