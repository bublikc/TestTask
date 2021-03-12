using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks
{
    public static class RomanNumbers
    {
        private static Dictionary<char, int> letters = new Dictionary<char, int> { { 'M', 1000 }, { 'D', 500 }, { 'C', 100 }, { 'L', 50 }, { 'X', 10 }, { 'V', 5 }, { 'I', 1 } };

        public static int ToInt(string romanNumber)
        {
            int result = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i == romanNumber.Length - 1)
                {
                    result += letters[romanNumber[i]];
                    continue;
                }

                if (letters[romanNumber[i]] >= letters[romanNumber[i + 1]])
                {
                    result += letters[romanNumber[i]];
                }
                else
                {
                    result += letters[romanNumber[i + 1]] - letters[romanNumber[i]];
                    i++;
                }
            }

            return result;
        }
    }
}
