using MYA_Stayholm.Dtos.HouseDtos;
using MYA_Stayholm.Dtos.ReservationDtos;

namespace MYA_Stayholm.Services.Abstract
{
    public interface IReservationService
    {
        Task<List<ResultReservationDto>> GetAllReservationAsync();
        Task CreateReservationAsync(CreateReservationDto createReservationDto);
        Task UpdateReservationAsync(UpdateReservationDto updateReservationDto);
        Task DeleteReservationAsync(string id);
        Task<GetByIdReservationDto> GetByIdReservationAsync(string id);

    }
}
