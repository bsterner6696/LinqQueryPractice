using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryPractice
{
    class LinqPractice
    {

        public List<string> RemoveRepeatedValues(List<string> values)
        {
            var uniqueValues = values.Distinct();
            List<string> results = new List<string>();
            foreach (string x in uniqueValues)
            {
                results.Add(x);
            }
            return results;
        } 
    }
}
