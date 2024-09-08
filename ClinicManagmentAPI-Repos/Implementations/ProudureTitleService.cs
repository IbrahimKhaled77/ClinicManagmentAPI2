using ClinicManagementAPI.Context;
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI_Repos.DTOs.ProudureTitleDTO;


namespace ClinicManagmentAPI_Repos.Implementations
{
    public class ProudureTitleService : IProudureTitleService
    {
        private readonly ClinicManagementDbContext _context;
        public ProudureTitleService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task CreateIProudureTitle(ProudureTitleCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIProudureTitle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProudureTitleCard>> GetAllIProudureTitle()
        {
            throw new NotImplementedException();
        }

        public Task<ProudureTitleCard> GetIProudureTitle(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIProudureTitle(ProudureTitleUpdate dto)
        {
            throw new NotImplementedException();
        }
    }
}
