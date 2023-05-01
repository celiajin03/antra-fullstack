using System;
namespace School
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        void RemovePerson(Person person);
        List<Person> GetAllPeople();
    }
}

