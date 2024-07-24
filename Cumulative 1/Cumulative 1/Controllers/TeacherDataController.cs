using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class TeacherDataController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public TeacherDataController(SchoolDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Teacher> GetTeachers()
    {
        return _context.Teachers.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Teacher> GetTeacher(int id)
    {
        var teacher = _context.Teachers.Find(id);

        if (teacher == null)
        {
            return NotFound();
        }

        return teacher;
    }
}
