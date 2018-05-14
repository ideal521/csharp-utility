using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.meetCriteria(persons));

            Console.WriteLine("Females: ");
            printPersons(female.meetCriteria(persons));

            Console.WriteLine("Single Males: ");
            printPersons(singleMale.meetCriteria(persons));

            Console.WriteLine("Single or Females: ");
            printPersons(singleOrFemale.meetCriteria(persons));

            Console.ReadKey();
        }

        public static void printPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.getName()
                   + ", Gender : " + person.getGender()
                   + ", Marital Status : " + person.getMaritalStatus()
                   + " ]");
            }
        }
    }
}
