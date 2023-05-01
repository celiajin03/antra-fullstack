using System;
namespace School
{
    public interface IInstructorService : IPersonService
    {
        int CalculateYearsOfExperience();
        decimal CalculateSalary();
    }
}

