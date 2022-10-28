using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var input = Console.ReadLine();
                StringBuilder result = new StringBuilder();
                for (int j = 0; j < input.Length-1; j++)
                {
                    if (char.ToUpper(input[j]) < char.ToUpper(input[j + 1]))
                    {
                        result.Append(input[j]);
                        result.Append(input[j]);
                    }
                    else if(char.ToUpper(input[j]) > char.ToUpper(input[j + 1]))
                    {
                        result.Append(input[j]);
                    }
                    else if(char.ToUpper(input[j]) == char.ToUpper(input[j + 1]))
                    {
                        if(j+1==input.Length-1)
                        {
                            result.Append(input[j]);
                            break;
                        }
                        int check = 2;
                        while ((j+check)<=(input.Length-1))
                        {
                            if (j + check == (input.Length - 1) && char.ToUpper(input[j]) == char.ToUpper(input[j + check]))
                            {
                                result.Append(input[j]);
                                break ;
                            }
                            if (char.ToUpper(input[j]) < char.ToUpper(input[j + check]))
                            {
                                result.Append(input[j]);
                                result.Append(input[j]);
                                break;
                            }else if(char.ToUpper(input[j]) > char.ToUpper(input[j+check]))
                            {
                                result.Append(input[j]);
                                break;
                            }
                            check++;
                        }
                        
                    }
                }
                result.Append(input[input.Length-1]);
                Console.WriteLine($"Case #{i + 1}: {result}");
            }
            
            Console.ReadLine();
        }
    }
}
