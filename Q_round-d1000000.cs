using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1000000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int straight = 1;
                int N = int.Parse(Console.ReadLine());
                string[] dices_string = Console.ReadLine().Split(' ');
                List<int> dices = new List<int>();
                foreach (string dice in dices_string)
                {
                    dices.Add(int.Parse(dice));
                }
                var orderedDices = dices.OrderBy(x => x);
                foreach (int dice in orderedDices)
                {
                    if (dice >= straight)
                        straight++;
                }
                Console.WriteLine($"Case #{i+1}: {straight-1}");
            }
            Console.ReadLine();
        }
    }
}
