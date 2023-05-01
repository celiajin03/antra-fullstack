using System;
namespace School
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void RemoveCourse(Course course);
        List<Course> GetAllCourses();
    }
}

