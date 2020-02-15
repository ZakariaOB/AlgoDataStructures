using AlgoDts.Implementations.Process;
using System.Collections.Generic;
using System.Linq;

namespace AlgoDts.Implementations.CodeWars
{
    public class FindOddInt : IProcess
    {
        public void Main()
        {
            throw new System.NotImplementedException();
        }

        private int FindIt(int[] seq)
        {
            if (seq == null || !seq.Any())
            {
                return -1;
            }


            Dictionary<int, int> elements = new Dictionary<int, int>();
            foreach (int el in seq)
            {
                if (elements.ContainsKey(el))
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
