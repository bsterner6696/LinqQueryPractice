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

        public List<decimal> ConvertToDecimalList(string line)
        {
            char[] characters = line.ToCharArray();
            List<decimal> results = new List<decimal>();
            int numberPlace = 1;
            decimal storedNumber = 0;
            bool wasNumber = false;
            int parsedNumber;
            for (int x = 0; x < characters.Count(); x++)
            {
                if (Int32.TryParse(characters[characters.Count() - 1 - x].ToString(), out parsedNumber))
                {
                    storedNumber += (parsedNumber * numberPlace);
                    numberPlace *= 10;
                    wasNumber = true;
                }
                else if (!Int32.TryParse(characters[characters.Count() - 1 - x].ToString(), out parsedNumber) && wasNumber == true)
                {
                    results.Add(storedNumber);
                    storedNumber = 0;
                    numberPlace = 1;
                    wasNumber = false;
                }
                if (characters.Count() - 1 -x == 0 && wasNumber)
                {
                    results.Add(storedNumber);
                }
            }
            return results;
        }
        public List<decimal> RemoveMinValue(List<decimal> inputs)
        {
            decimal lowest = inputs.Min();
            inputs.Remove(lowest);
            return inputs;
        }

        public decimal AverageDecimals(List<decimal> inputs)
        {
            decimal output = inputs.Average();
            return output;
        }

        public decimal AverageGradeStrings(List<string> inputs)
        {
            List<decimal> averageGrades = new List<decimal>();
            foreach (string line in inputs)
            {
                decimal result = AverageDecimals(RemoveMinValue(ConvertToDecimalList(line)));
                averageGrades.Add(result);
            }
            decimal output = averageGrades.Average();
            return output;
        }

        public bool CheckForTh(List<string> inputs)
        {
            var checkedInputs = inputs.Select(x => x.Contains("th"));
            bool result = checkedInputs.Contains(true);
            return result;
        }
    }
}
