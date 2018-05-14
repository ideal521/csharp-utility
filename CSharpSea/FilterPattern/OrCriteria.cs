using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class OrCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public OrCriteria(Criteria criteria,Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = criteria.meetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.meetCriteria(persons);

            foreach(Person person in otherCriteriaItems)
            {
                if(!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }

            return firstCriteriaItems;
        }
    }
}
