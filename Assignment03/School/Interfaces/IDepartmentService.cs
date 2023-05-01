using System;
namespace School
{
    public interface IDepartmentService
    {
        void AddDepartment(Department department);
        void RemoveDepartment(Department department);
        List<Department> GetAllDepartments();
    }
}

