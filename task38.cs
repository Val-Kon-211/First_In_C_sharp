using System;

namespace task38
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int maxLength = 0;
            int curLength = 0;

            foreach (char c in text)
            {
                int unicode = c;

                if ((unicode >= 65 && unicode <= 90) || (unicode >= 97 && unicode <= 122))
                    curLength += 1;

                else if(c == text[text.Length - 1] && curLength > maxLength)
                    maxLength = curLength;
                else
                {
                    if (curLength > maxLength)
                        maxLength = curLength;
                    curLength = 0;
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}
