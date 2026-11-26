using MYA_Stayholm.Dtos.ReservationDtos;
using MYA_Stayholm.Services.Abstract;

namespace MYA_Stayholm.Services.Concrete
{
    public class ReservationService : IReservationService
    {
        public Task CreateReservationAsync(CreateReservationDto createReservationDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReservationAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultReservationDto>> GetAllReservationAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdReservationDto> GetByIdReservationAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservationAsync(UpdateReservationDto updateReservationDto)
        {
            throw new NotImplementedException();
        }
    }
}
