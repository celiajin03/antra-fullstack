using School;


// Create a few people.
Person person1 = new Person() { Name = "Joe Bruin", DateOfBirth = new DateTime(1980, 1, 1) };

// Calculate their ages.
int age1 = person1.CalculateAge();

// Print out their ages.
Console.WriteLine("Joe Bruin is " + age1 + " years old.");

// Create an instructor.
Instructor instructor = new Instructor() { Name = "Professor Smith", DateOfBirth = new DateTime(1960, 3, 3), Department = "Computer Science", JoinDate = new DateTime(2000, 4, 4) };

// Calculate the instructor's years of experience.
int yearsOfExperience = instructor.CalculateYearsOfExperience();

// Print out the instructor's years of experience.
Console.WriteLine("Professor Smith has " + yearsOfExperience + " years of experience.");

// Calculate the instructor's salary.
decimal salary = instructor.CalculateSalary();

// Print out the instructor's salary.
Console.WriteLine("Professor Smith's salary is " + salary + ".");

// Create a student.
Student student = new Student() { Name = "Oski Bear", DateOfBirth = new DateTime(1990, 5, 5), Major = "Computer Science", CourseGrades = new Dictionary<string, string>() { { "CS101", "A" }, { "CS102", "B" }, { "CS103", "C" } } };

// Calculate the student's GPA.
decimal gpa = student.CalculateGPA();

// Print out the student's GPA.
Console.WriteLine("Oski Bear's GPA is " + gpa + ".");
