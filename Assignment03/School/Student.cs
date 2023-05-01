using System;
namespace School
{
    public class Student : Person
    {
        public string Major { get; set; }
        public Dictionary<string, string> CourseGrades { get; set; }

        public decimal CalculateGPA()
        {
            // Calculate the student's GPA based on their grades for courses.
            decimal gradePoints = 0;
            int creditsAttempted = 0;
            foreach (var courseGrade in CourseGrades)
            {
                switch (courseGrade.Value)
                {
                    case "A":
                        gradePoints += 4;
                        creditsAttempted++;
                        break;
                    case "B":
                        gradePoints += 3;
                        creditsAttempted++;
                        break;
                    case "C":
                        gradePoints += 2;
                        creditsAttempted++;
                        break;
                    case "D":
                        gradePoints += 1;
                        creditsAttempted++;
                        break;
                    case "F":
                        break;
                }
            }
            decimal GPA = gradePoints / creditsAttempted;
            return GPA;
        }
    }
}

