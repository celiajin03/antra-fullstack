using System;
namespace School
{
    public class Course : ICourseService
    {
        public string CourseName { get; set; }
        public Instructor Instructor { get; set; }
        public List<Student> Students { get; set; }

        void ICourseService.AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        void ICourseService.RemoveCourse(Course course)
        {
            throw new NotImplementedException();
        }

        List<Course> ICourseService.GetAllCourses()
        {
            throw new NotImplementedException();
        }
    }
}

