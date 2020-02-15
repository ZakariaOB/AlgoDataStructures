using System.Text;

namespace AlgoDts.ImplemNet.CodeWars.MakeComplement
{
    public class DnaTester
    {
        public static string MakeComplement(string dna)
        {
            StringBuilder result = new StringBuilder();
            foreach (char item in dna)
            {
                switch (item)
                {
                    case 'A':
                        result.Append("T");
                        break;
                    case 'T':
                        result.Append("A");
                        break;
                    case 'C':
                        result.Append("G");
                        break;
                    case 'G':
                        result.Append("C");
                        break;
                    default:
                        result.Append(item.ToString());
                        break;
                }
            }
            return result.ToString();
        }
    }
}
