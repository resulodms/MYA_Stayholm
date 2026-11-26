using MYA_Stayholm.Dtos.AppUserDtos;

namespace MYA_Stayholm.Services.Abstract
{
    public interface IAppUserService
    {
        Task<List<ResultAppUser>> GetAllResultsAsync();
        Task CreateAppUserAsync(CreateAppUser createAppUserDto);
        Task UpdateAppUserAsync(UpdateAppUser updateAppUserDto);
        Task DeleteAppUserAsync(string id);

        Task<GetByIdAppUser> GetByIdAppUserAsync(string id);
    }
}
