using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.If_statements_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(4, 6));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
