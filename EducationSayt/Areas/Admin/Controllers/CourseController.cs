using EducationSayt.Data;
using EducationSayt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducationSayt.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {

        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> courses = await _context.Courses.Include(c=>c.CourseImages).Include(c=>c.Author).Where(m => !m.SoftDelete).ToListAsync();
            return View(courses);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();
            Course course = await _context.Courses.Include(c=>c.CourseImages).Include(c=>c.Author).FirstOrDefaultAsync(m => m.Id == id);
            if (course is null) return NotFound();
            return View(course);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
