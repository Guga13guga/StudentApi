using Microsoft.AspNetCore.Mvc;
using StudentApi.Database;
using StudentApi.Models;

namespace StudentApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly StudentsDbContext _context;

    public StudentsController(StudentsDbContext context)
    {
        _context = context;
    }
    //post, put, get, delete, head ,path

    [HttpPost("AddNewStudent")]
    public IActionResult AddNewStudent([FromBody]Students student)
    {
        try
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok("Warmatebit chaiwera");
        }
        catch (Exception)
        {
            return BadRequest();
            throw;
        }
    }

    [HttpGet("GetAllStudents")]
    public IActionResult GetStudents()
    {
        var allStudents = _context.Students;
        if (allStudents.Any())
        {
            return Ok(allStudents);
        }
        else
        {
            return NotFound("Studentis sia carielia");
        }
    }

    [HttpDelete("/{id}")]
    public IActionResult DeleteStudentById(int id)
    {
        try
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                return Ok("studenti wavshale");
            }
            return NotFound("msgavi studenti ar arsebobs");
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

}
