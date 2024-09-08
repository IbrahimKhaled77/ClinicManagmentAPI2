using ClinicManagmentAPI_Repos.DTOs.UserDTO;

namespace ClinicManagmentAPI_Repos.Interface
{
    public interface IUserService
    {
        Task<UserProfileDto> GetUserProfile(int userId);

        Task<IEnumerable<UserProfileDto>> GetAllUsers();

        Task CreateUser(CreateUserDto createUserDto);

        Task UpdateUser(UpdateUserDto updateUserDto);       
    }
}
