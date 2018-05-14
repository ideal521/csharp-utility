using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class CriteriaMale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.getGender().ToUpper() == "MALE")
                {
                    malePersons.Add(person);
                }
            }

            return malePersons;
        }
    }
}
