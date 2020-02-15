using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoDts.ImplemNet.CodeWars.Brace
{
    public class Brace
    {
        public static bool ValidBraces(string braces)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>
            {
                {'(', 1 },
                {')', -1 },
                {'[', 2 },
                {']', -2 },
                {'{', 3 },
                {'}', -3 },
            };

            if (braces.Count() == 1)
            {
                return true;
            }

            if (braces.All(item => chars[item] < 0))
            {
                return false;
            }

            Stack<int> operands = new Stack<int>();
            var result = 0;
            foreach (char el in braces)
            {
                if (chars[el] > 0)
                {
                    operands.Push(chars[el]);
                }
                else
                {
                    if (operands.Count > 0)
                    {
                        var item = operands.Pop();
                        result = chars[el] + item;
                    }
                }
            }
            return result == 0 && operands.Count == 0;
        }
    }
}
