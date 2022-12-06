using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class UserService
    {
        private readonly List<Person> _persons;
        public UserService()
        {
            var personseed = new Faker<Person>()
                .RuleFor(person => person.Id,
                faker => faker.IndexFaker + 1)
                .RuleFor(person => person.Name,
                faker => faker.Name.FirstName())
                .RuleFor(person => person.LastName,
                faker => faker.Name.LastName());
            _persons = personseed.Generate(200);
        }
        public List<Person> GetAllPersons() => _persons;

        public List<Person> SearchPersons(string name)
        {
            return _persons.Where(person => person.Name.Contains(name)).ToList();
        }
        public Person? PersonId(int id) =>
            _persons.FirstOrDefault(person => person.Id == id);

        public bool DeletePeson(int id)
        {
            var person = _persons.FirstOrDefault(_persons.FirstOrDefault(person => person.Id == id));
            if (person != null)
            {
                _persons.Remove(person);
                return true;
            }
            return false;
        }
            
            
             
    }
}
