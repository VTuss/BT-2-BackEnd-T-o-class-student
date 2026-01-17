using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllAsync();
            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                FullName = s.FullName,
                Email = s.Email,
                DateOfBirth = s.DateOfBirth,
                ClassId = s.ClassId
            });
        }

        public async Task<StudentDto?> GetStudentByIdAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
                return null;

            return new StudentDto
            {
                Id = student.Id,
                FullName = student.FullName,
                Email = student.Email,
                DateOfBirth = student.DateOfBirth,
                ClassId = student.ClassId
            };
        }

        public async Task<StudentDto> CreateStudentAsync(CreateStudentDto createStudentDto)
        {
            var student = new Student
            {
                FullName = createStudentDto.FullName,
                Email = createStudentDto.Email,
                DateOfBirth = createStudentDto.DateOfBirth,
                ClassId = createStudentDto.ClassId
            };

            var createdStudent = await _studentRepository.CreateAsync(student);

            return new StudentDto
            {
                Id = createdStudent.Id,
                FullName = createdStudent.FullName,
                Email = createdStudent.Email,
                DateOfBirth = createdStudent.DateOfBirth,
                ClassId = createdStudent.ClassId
            };
        }

        public async Task<StudentDto?> UpdateStudentAsync(int id, UpdateStudentDto updateStudentDto)
        {
            var student = new Student
            {
                Id = id,
                FullName = updateStudentDto.FullName,
                Email = updateStudentDto.Email,
                DateOfBirth = updateStudentDto.DateOfBirth,
                ClassId = updateStudentDto.ClassId
            };

            var updatedStudent = await _studentRepository.UpdateAsync(student);
            if (updatedStudent == null)
                return null;

            return new StudentDto
            {
                Id = updatedStudent.Id,
                FullName = updatedStudent.FullName,
                Email = updatedStudent.Email,
                DateOfBirth = updatedStudent.DateOfBirth,
                ClassId = updatedStudent.ClassId
            };
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            return await _studentRepository.DeleteAsync(id);
        }
    }
}
