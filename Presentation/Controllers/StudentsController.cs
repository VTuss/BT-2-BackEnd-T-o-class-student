using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();
            return Ok(students);
        }

        // GET: api/students/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudent(int id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        // POST: api/students
        [HttpPost]
        public async Task<ActionResult<StudentDto>> CreateStudent(CreateStudentDto createStudentDto)
        {
            var student = await _studentService.CreateStudentAsync(createStudentDto);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        // PUT: api/students/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<StudentDto>> UpdateStudent(int id, UpdateStudentDto updateStudentDto)
        {
            var student = await _studentService.UpdateStudentAsync(id, updateStudentDto);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        // DELETE: api/students/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            var result = await _studentService.DeleteStudentAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
