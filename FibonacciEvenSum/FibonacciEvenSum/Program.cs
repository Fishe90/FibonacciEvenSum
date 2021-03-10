using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {            
            int firstNum = 1;
            int secondNum = 0;
            int totalSumEven = 0;
            int totalSumAll = firstNum + secondNum;

            while (totalSumAll < 4000000)
            {
                firstNum = totalSumAll - firstNum;
                secondNum = totalSumAll;
                totalSumAll = firstNum + secondNum;
                if (totalSumAll%2 == 0)
                {
                    totalSumEven += totalSumAll;
                }
                Console.WriteLine(totalSumAll);
            }

            Console.WriteLine($"Sum of ALL Numbers in the Sequence: {totalSumAll}");
            Console.WriteLine($"Sum of EVEN Numbers in the Sequence: {totalSumEven}");
        }
    }
}
