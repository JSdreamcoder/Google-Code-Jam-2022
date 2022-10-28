using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dprinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalInk = 1000000;
            int T = int.Parse(Console.ReadLine());
            List<int[]> result = new List<int[]>(); 
            string[] print1 = new string[4];
            string[] print2 = new string[4];
            string[] print3 = new string[4];


            for (int i = 0; i <= T - 1; i++)
            {
                
                result.Add(new int[] { 0,0,0,0});
                
                print1= Console.ReadLine().Split(' ');
                print2= Console.ReadLine().Split(' ');
                print3= Console.ReadLine().Split(' ');
                List<int> C = new List<int>()
                { int.Parse(print1[0]),
                  int.Parse(print2[0]),
                  int.Parse(print3[0]),
                };
                List<int> M = new List<int>()
                { int.Parse(print1[1]),
                  int.Parse(print2[1]),
                  int.Parse(print3[1]),
                };
                List<int> Y = new List<int>()
                { int.Parse(print1[2]),
                  int.Parse(print2[2]),
                  int.Parse(print3[2]),
                };
                List<int> K = new List<int>()
                { int.Parse(print1[3]),
                  int.Parse(print2[3]),
                  int.Parse(print3[3]),
                };

                int sumInk = 0;
                sumInk = C.Min();
                if (sumInk == TotalInk)
                {
                    result[i][0] = C.Min();
                }else
                {
                    result[i][0] = C.Min();
                }
                

                sumInk += M.Min();
                if (sumInk >= TotalInk)
                {
                    
                    result[i][1] = TotalInk-C.Min();
                    sumInk = TotalInk;
                }
                else
                {
                result[i][1] = M.Min();
                }

                sumInk += Y.Min();
                if (sumInk >= TotalInk)
                {
                   
                    result[i][2] = TotalInk-(sumInk-Y.Min());
                    sumInk = TotalInk;
                }
                else
                {
                result[i][2] = Y.Min();
                }

                sumInk +=K.Min();
                if (sumInk >= TotalInk)
                {
                    result[i][3] = TotalInk - (sumInk-K.Min());
                }
                
                
            }

            int caseNumber = 0;
            foreach (var arry in result)
            {
                caseNumber++;
                if (arry[0] + arry[1] + arry[2] + arry[3] == TotalInk)
                {
                    Console.WriteLine($"Case #{caseNumber}: {arry[0]}  {arry[1]}  {arry[2]} {arry[3]}");
                }else
                {
                    Console.WriteLine($"Case #{caseNumber}: IMPOSSIBLE");
                }
                

            };
            Console.ReadLine();
        }
    }
}
