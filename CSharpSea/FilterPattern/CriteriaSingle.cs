using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach(Person person in persons)
            {
                if(person.getMaritalStatus().ToUpper() == "SINGLE")
                {
                    singlePersons.Add(person);
                }
            }

            return singlePersons;
        }
    }
}
