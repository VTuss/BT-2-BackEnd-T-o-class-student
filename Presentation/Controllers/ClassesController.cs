using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        // GET: api/classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassDto>>> GetClasses()
        {
            var classes = await _classService.GetAllClassesAsync();
            return Ok(classes);
        }

        // GET: api/classes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassDto>> GetClass(int id)
        {
            var classDto = await _classService.GetClassByIdAsync(id);
            if (classDto == null)
            {
                return NotFound();
            }
            return Ok(classDto);
        }

        // POST: api/classes
        [HttpPost]
        public async Task<ActionResult<ClassDto>> CreateClass(CreateClassDto createClassDto)
        {
            var classDto = await _classService.CreateClassAsync(createClassDto);
            return CreatedAtAction(nameof(GetClass), new { id = classDto.Id }, classDto);
        }
    }
}
