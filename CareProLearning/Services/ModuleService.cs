using CareProLearning.Data;
using CareProLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace CareProLearning.Services
{
    public class ModuleService : IModuleService
    {
        private readonly ApplicationDbContext _context;

        public ModuleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Module>> GetModules()
        {
            return await _context.Modules.ToListAsync();
        }

        public async Task<Module> GetModule(int moduleId)
        {
            return await _context.Modules
                .FirstOrDefaultAsync(m => m.ModuleId == moduleId);
        }

        public async Task<Module> AddModule(Module module)
        {
            var result = await _context.Modules.AddAsync(module);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Module> UpdateModule(Module module)
        {

            _context.Modules.Update(module);
            await _context.SaveChangesAsync();
            return module;
        }

        public async Task DeleteModule(int moduleId)
        {
            var result = await _context.Modules
               .FirstOrDefaultAsync(m => m.ModuleId == moduleId);

            if (result != null)
            {
                _context.Modules.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateProgress(int moduleId, double progressInSeconds, bool isCompleted)
        {
            var module = await _context.Modules.FindAsync(moduleId);
            if (module != null)
            {
                module.ProgressInSeconds = progressInSeconds;
                module.IsCompleted = isCompleted;
                await _context.SaveChangesAsync();
            }
        }
    }
}
