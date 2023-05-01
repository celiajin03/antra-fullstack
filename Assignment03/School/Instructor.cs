using System;
namespace School
{
    public class Instructor : Person
    {
        public string Department { get; set; }
        public bool IsHeadOfDepartment { get; set; }
        public DateTime JoinDate { get; set; }

        public int CalculateYearsOfExperience()
        {
            // Calculate the instructor's years of experience based on their join date.
            DateTime today = DateTime.Today;
            int yearsOfExperience = (int)today.Year - JoinDate.Year;
            return yearsOfExperience;
        }

        public decimal CalculateSalary()
        {
            // Calculate the instructor's salary based on their years of experience and bonus salary.
            decimal salary = base.CalculateSalary();
            int yearsOfExperience = CalculateYearsOfExperience();
            decimal bonusSalary = 100 * yearsOfExperience;
            salary += bonusSalary;
            return salary;
        }
    }
}

