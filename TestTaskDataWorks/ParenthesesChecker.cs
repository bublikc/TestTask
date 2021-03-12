using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks
{
    public static class ParenthesesChecker
    {
        public static bool Check(string stringForCheck)
        {
            int count = 0;
            for (int i = 0; i < stringForCheck.Length; i++)
            {
                if (stringForCheck[i] == '(')
                    count++;
                else if (stringForCheck[i] == ')')
                    count--;
                if (count < 0)
                    return false;
            }
            return count == 0;
        }
    }
}
