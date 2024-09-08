using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.UserDTO;
using ClinicManagmentAPI_Repos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class UserService : IUserService
    {
        private readonly ClinicManagementDbContext _context;
        public UserService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task CreateUser(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserProfileDto>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfileDto> GetUserProfile(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
