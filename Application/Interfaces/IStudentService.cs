using Application.DTOs;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto?> GetStudentByIdAsync(int id);
        Task<StudentDto> CreateStudentAsync(CreateStudentDto createStudentDto);
        Task<StudentDto?> UpdateStudentAsync(int id, UpdateStudentDto updateStudentDto);
        Task<bool> DeleteStudentAsync(int id);
    }
}
