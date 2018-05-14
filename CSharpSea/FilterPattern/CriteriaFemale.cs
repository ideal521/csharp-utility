using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalPersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.getGender().ToUpper() == "FEMALE")
                {
                    femalPersons.Add(person);
                }
            }

            return femalPersons;
        }
    }
}
