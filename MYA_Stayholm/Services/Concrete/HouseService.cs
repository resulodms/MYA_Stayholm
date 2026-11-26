using MYA_Stayholm.Dtos.HouseDtos;
using MYA_Stayholm.Services.Abstract;

namespace MYA_Stayholm.Services.Concrete
{
    public class HouseService : IHouseService
    {
        public Task CreateHouseAsync(CreateHouseDto createHouseDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHouseAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultHouseDto>> GetAllHouseAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdHouseDto> GetByIdHouseAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateHouseAsync(UpdateHouseDto updateHouseDto)
        {
            throw new NotImplementedException();
        }
    }
}
