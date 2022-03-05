using System;
using System.Collections.Generic;
using System.Linq;

namespace task44
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> letters = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] symbols = Console.ReadLine().Split(' ');
                letters[symbols[0]] = symbols[1];
            }

            string code = Console.ReadLine();
            List<string> values = new List<string>(letters.Values);

            int k = 1;
            int ind = 0;
            string sub;
            string res = "";

            for (int i = 0; i < code.Length; i++)
            {
                sub = code.Substring(ind, k);

                if (values.Contains(sub))
                {
                    var l = letters.FirstOrDefault(x => x.Value == sub).Key;
                    res += l;
                    ind = i + 1;
                    k = 1;
                }
                else
                    k += 1;
            }

            Console.WriteLine(res);
        }
    }
}
