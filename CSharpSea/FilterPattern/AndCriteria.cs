using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class AndCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public AndCriteria(Criteria criteria,Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.meetCriteria(persons);
            return otherCriteria.meetCriteria(firstCriteriaPersons);
        }
    }
}
