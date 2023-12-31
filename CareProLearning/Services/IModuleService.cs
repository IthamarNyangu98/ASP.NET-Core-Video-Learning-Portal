﻿using CareProLearning.Models;

namespace CareProLearning.Services
{
    public interface IModuleService
    {
        Task<IEnumerable<Module>> GetModules();
        Task<Module> GetModule(int moduleId);
        Task<Module> AddModule(Module module);
        Task<Module> UpdateModule(Module module);
        Task UpdateProgress(int moduleId, double progressInSeconds, bool isCompleted);
        Task DeleteModule(int moduleId);
    }
}

