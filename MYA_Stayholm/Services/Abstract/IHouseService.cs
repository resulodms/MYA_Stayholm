using MYA_Stayholm.Dtos.HouseDtos;

namespace MYA_Stayholm.Services.Abstract
{
    public interface IHouseService
    {

        Task<List<ResultHouseDto>> GetAllHouseAsync();
        Task CreateHouseAsync(CreateHouseDto createHouseDto);
        Task UpdateHouseAsync(UpdateHouseDto updateHouseDto);
        Task DeleteHouseAsync(string id);
        Task<GetByIdHouseDto> GetByIdHouseAsync(string id);



    }
}
