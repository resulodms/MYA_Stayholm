using MYA_Stayholm.Dtos.CategoryDtos;

namespace MYA_Stayholm.Services.Abstract
{
    public interface ICategoryService
    {

        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);

        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);



    }
}
