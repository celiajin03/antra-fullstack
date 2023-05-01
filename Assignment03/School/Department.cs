using System;
namespace School
{
    public class Department : IDepartmentService
    {
        public string DepartmentName { get; set; }
        public Instructor DepartmentHead { get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; }

        void IDepartmentService.AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        List<Department> IDepartmentService.GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        void IDepartmentService.RemoveDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}

