using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext _context;

        public ClassRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Class>> GetAllAsync()
        {
            return await _context.Classes.ToListAsync();
        }

        public async Task<Class?> GetByIdAsync(int id)
        {
            return await _context.Classes.FindAsync(id);
        }

        public async Task<Class> CreateAsync(Class classEntity)
        {
            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();
            return classEntity;
        }
    }
}
