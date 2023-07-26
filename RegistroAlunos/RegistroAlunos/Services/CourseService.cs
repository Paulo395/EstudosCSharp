using Entities;

namespace Services
{
    internal class CourseService
    {
        public void AddStudent(Course course, Student student)
        {
            course.students.Add(student);
        }

        public void ListStudent(Course course)
        {
            Console.WriteLine(course.ToString());
        }
    }
}
