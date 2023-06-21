using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementations : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++) 
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }
    
        public Person FindById(long id)
        {
            return new Person
            {
                ID = IncrementAndGet(),
                FirstName = "João",
                LastName = "Silva",
                Adress = "Fortaleza - Ceará - Brasil",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                ID = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastNAme" + i,
                Adress = "Some Address" + i,
                Gender = "Male"

            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
