using Microsoft.AspNetCore.Mvc;
using SchoolDatabase.Models;

public class TeacherPageController : Controller
{
	private readonly SchoolDbContext _context;

	public TeacherPageController(SchoolDbContext context)
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

