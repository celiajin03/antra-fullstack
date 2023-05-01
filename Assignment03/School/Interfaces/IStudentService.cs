using System;
namespace School
{
    public interface IStudentService : IPersonService
    {
        decimal CalculateGPA();
    }
}

