using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using System.Linq;

public class TeacherController : Controller
{
    private readonly SchoolDbContext _context;

    public TeacherController(SchoolDbContext context)
    {
        _context = context;
    }

    public IActionResult List()
    {
        var teachers = _context.Teachers.ToList();
        return View(teachers);
    }

    public IActionResult Show(int id)
    {
        var teacher = _context.Teachers.Find(id);

        if (teacher == null)
        {
            return NotFound();
        }

        return View(teacher);
    }
}
