
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    internal class Program
    {
        static Dictionary<char, int> GetFrequency(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ' || c == ',') // Skip spaces and commas
                    continue;

                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            return freq;
        }

        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            // Split multiple strings separated by comma
            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                string trimmed = part.Trim();
                Dictionary<char, int> result = GetFrequency(trimmed);

                Console.WriteLine("\nString: " + trimmed);
                foreach (var item in result)
                {
                    Console.Write(item.Key + "=" + item.Value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}