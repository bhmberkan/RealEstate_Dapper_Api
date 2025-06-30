using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_Api.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);

        void DeleteTestimonial(int id);

        Task<GetByIdTestimonialDto> GetTestimonial(int id);
    }
}
