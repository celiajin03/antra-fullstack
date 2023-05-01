using System;
namespace School
{
    public class Person : IPersonService
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> Addresses { get; set; }

        public int CalculateAge()
        {
            // Calculate the person's age based on their date of birth.
            DateTime today = DateTime.Today;
            int age = (int)today.Year - DateOfBirth.Year;
            return age;
        }

        public decimal CalculateSalary()
        {
            decimal salary = 0;
            // To be implementated: Salary Calculation

            // Salary cannot be negative number.
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative.");
            }
            return salary;
        }

        public List<string> GetAddresses()
        {
            // Get the person's addresses.
            return Addresses;
        }

        public void AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void RemovePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPeople()
        {
            throw new NotImplementedException();
        }
    }
}

