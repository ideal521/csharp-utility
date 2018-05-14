using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public interface Criteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
