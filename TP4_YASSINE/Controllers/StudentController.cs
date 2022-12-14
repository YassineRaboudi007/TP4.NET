using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP4_YASSINE.Data;
using TP4_YASSINE.Models;

namespace TP4_YASSINE.Controllers
{
    [Route("")]
    [Route("Student")]
    public class StudentController : Controller
    {
        private readonly IUniversityRepo _universityRepo;

        public StudentController(IUniversityRepo universityRepo)
        {
            _universityRepo = universityRepo;
        }
        // GET: StudnetController
        [Route("")]
        [Route("Index")]
        public ActionResult Index()
        {

            IEnumerable<Student> allStudnets = _universityRepo.GetAllStudents();
            return View(allStudnets);
        }

        // GET: StudnetController/Details/5
        [HttpGet("Courses")]
        public ActionResult Courses()
        {
            IQueryable allCourses = _universityRepo.GetUniqueCourses();
            Console.WriteLine(allCourses);
            return View(allCourses);
        }

        [HttpGet("{course}")]
        public ActionResult GetStudentsForCourse(string course)
        {
            IEnumerable<Student> students = _universityRepo.GetStudentsByCourse(course);
            ViewData["course"] = course;
            return View(students);
        }
        

        

    }
}
