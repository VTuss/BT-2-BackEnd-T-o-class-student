using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<IEnumerable<ClassDto>> GetAllClassesAsync()
        {
            var classes = await _classRepository.GetAllAsync();
            return classes.Select(c => new ClassDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            });
        }

        public async Task<ClassDto?> GetClassByIdAsync(int id)
        {
            var classEntity = await _classRepository.GetByIdAsync(id);
            if (classEntity == null)
                return null;

            return new ClassDto
            {
                Id = classEntity.Id,
                Name = classEntity.Name,
                Description = classEntity.Description
            };
        }

        public async Task<ClassDto> CreateClassAsync(CreateClassDto createClassDto)
        {
            var classEntity = new Class
            {
                Name = createClassDto.Name,
                Description = createClassDto.Description
            };

            var createdClass = await _classRepository.CreateAsync(classEntity);

            return new ClassDto
            {
                Id = createdClass.Id,
                Name = createdClass.Name,
                Description = createdClass.Description
            };
        }
    }
}
