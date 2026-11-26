using MYA_Stayholm.Dtos.AppUserDtos;
using MYA_Stayholm.Services.Abstract;

namespace MYA_Stayholm.Services.Concrete
{
    public class AppUserService : IAppUserService
    {
        public Task CreateAppUserAsync(CreateAppUser createAppUserDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultAppUser>> GetAllResultsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdAppUser> GetByIdAppUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppUserAsync(UpdateAppUser updateAppUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
