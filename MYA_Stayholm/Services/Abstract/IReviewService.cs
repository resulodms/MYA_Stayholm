using MYA_Stayholm.Dtos.ReviewDtos;

namespace MYA_Stayholm.Services.Abstract
{
    public interface IReviewService
    {
        Task<List<ResultReviewDto>> GetAllReviewAsync();
        Task CreateReviewAsync(CreateReviewDto createReviewDto);
        Task UpdateReviewAsync(UpdateReviewDto updateReviewDto);
        Task DeleteReviewAsync(string id);
        Task<GetByIdReviewDto> GetByIdReviewAsync(string id);


    }
}
