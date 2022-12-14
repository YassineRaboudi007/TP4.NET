using System;
using TP4_YASSINE.Models;

namespace TP4_YASSINE.Data
{
    public class UniversityRepo : IUniversityRepo
    {
        private readonly UnivsersityContext _context;

        public UniversityRepo(IConfiguration configuration)
        {
            _context = UnivsersityContext.Instantiate_UniversityContext(configuration);
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Student.ToList();
        }

        public IEnumerable<Student> GetStudentsByCourse(string course)
        {
            return _context.Student.Where(student => student.course == course).ToList();
        }

        public IQueryable<string> GetUniqueCourses()
        {
            return _context.Student.Select(student=> student.course).Distinct();

        }
    }
}
