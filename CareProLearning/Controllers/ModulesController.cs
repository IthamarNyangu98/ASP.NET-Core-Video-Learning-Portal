using CareProLearning.Models;
using CareProLearning.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareProLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController : ControllerBase
    {
        private readonly IModuleService moduleService;

        public ModulesController(IModuleService moduleService)
        {
            this.moduleService = moduleService;
        }

        [HttpGet]
        public async Task<ActionResult> GetModules()
        {
            try
            {
                return Ok(await moduleService.GetModules());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Module>> GetModule(int id)
        {
            try
            {
                var result = await moduleService.GetModule(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Module>> CreateModule(Module module)
        {
            try
            {
                if (module == null)
                {
                    return BadRequest();
                }

                var createdModule = await moduleService.AddModule(module);

                return CreatedAtAction(nameof(GetModule), new { id = createdModule.ModuleId },
                    createdModule);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new module");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Module>> UpdateModule(int id, Module module)
        {
            try
            {
                if (id != module.ModuleId)
                {
                    return BadRequest("Module ID mismatch");
                }

                var moduleToUpdate = await moduleService.GetModule(id);

                if (moduleToUpdate == null)
                {
                    return NotFound($"Module with Id = {id} not found");
                }

                return await moduleService.UpdateModule(module);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating module");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Module>> DeleteModule(int id)
        {
            try
            {
                var moduleToDelete = await moduleService.GetModule(id);

                if (moduleToDelete == null)
                {
                    return NotFound($"Module with Id = {id} not found");
                }

                await moduleService.DeleteModule(id);

                return Ok(moduleToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting module");
            }
        }
    }
}
