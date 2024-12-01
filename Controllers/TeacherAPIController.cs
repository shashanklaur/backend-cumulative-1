using Microsoft.AspNetCore.Mvc;
using SchoolDatabase.Models;

[Route("api/[controller]")]
[ApiController]
public class TeacherAPIController : ControllerBase
{
	private readonly SchoolDbContext _context;

	public TeacherAPIController(SchoolDbContext context)
	{
		_context = context;
	}

	// GET: api/TeacherAPI
	[HttpGet]
	public ActionResult<IEnumerable<Teacher>> GetTeachers()
	{
		return _context.Teachers.ToList();
	}

	// GET: api/TeacherAPI/5
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

