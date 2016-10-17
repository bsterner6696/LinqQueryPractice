using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            LinqPractice linq = new LinqPractice();
            List<string> examples = new List<string> { "x", "x", "gon", "x", "give", "gon", "it", "to", "to", "x", "ya" };
            string gradeLine = "100,105,105,110";
            List<string> grades = new List<string> { "Student A: 100, 105, 105, 110", "Student B: 95, 100, 50, 90", "Student C: 100, 90, 85, 95", "Student D: 100, 100, 100, 100" };
            List<string> results = linq.RemoveRepeatedValues(examples);
            List<string> withTh = new List<string> { "father", "potato", "salmon" };
            foreach (string line in results)
            {
                Console.WriteLine(line);
            }
          
            List<decimal> intResults = linq.ConvertToDecimalList(gradeLine);
            intResults = linq.RemoveMinValue(intResults);

            foreach (decimal x in intResults)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(linq.AverageGradeStrings(grades));
            Console.WriteLine(linq.CheckForTh(grades));
            Console.WriteLine(linq.CheckForTh(withTh));
            Console.ReadLine();
        }
    }
}
