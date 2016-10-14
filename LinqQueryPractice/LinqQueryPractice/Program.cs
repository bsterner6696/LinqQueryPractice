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
            List<string> results = linq.RemoveRepeatedValues(examples);
            foreach (string line in results)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
