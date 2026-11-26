using MYA_Stayholm.Dtos.ReviewDtos;
using MYA_Stayholm.Services.Abstract;

namespace MYA_Stayholm.Services.Concrete
{
    public class ReviewService : IReviewService
    {
        public Task CreateReviewAsync(CreateReviewDto createReviewDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReviewAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultReviewDto>> GetAllReviewAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdReviewDto> GetByIdReviewAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReviewAsync(UpdateReviewDto updateReviewDto)
        {
            throw new NotImplementedException();
        }
    }
}
