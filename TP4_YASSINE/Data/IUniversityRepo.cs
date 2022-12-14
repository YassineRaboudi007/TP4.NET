using TP4_YASSINE.Models;

namespace TP4_YASSINE.Data
{
    public interface IUniversityRepo
    {
        public IEnumerable<Student> GetAllStudents();
        public IQueryable<string> GetUniqueCourses();
        public IEnumerable<Student> GetStudentsByCourse(string course);

    }
}
