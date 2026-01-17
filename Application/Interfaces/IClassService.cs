using Application.DTOs;

namespace Application.Interfaces
{
    public interface IClassService
    {
        Task<IEnumerable<ClassDto>> GetAllClassesAsync();
        Task<ClassDto?> GetClassByIdAsync(int id);
        Task<ClassDto> CreateClassAsync(CreateClassDto createClassDto);
    }
}
