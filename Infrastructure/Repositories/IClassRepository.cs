using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> GetAllAsync();
        Task<Class?> GetByIdAsync(int id);
        Task<Class> CreateAsync(Class classEntity);
    }
}
