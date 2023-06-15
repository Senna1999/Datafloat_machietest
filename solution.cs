using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senna_M_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an odd number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Invalid");
                return;
            }

            int num = 1;
            int num1 = 1;
            int i;
            //int indentation = (n - 1) * 4;
            for (i = 1; i <= n; i += 2)
            {
                string spaces = new string(' ', n - i);
                string row = spaces;

                for (int j = 0; j < i; j++)
                {
                    row += num + " ";
                    num += 2;
                }

                Console.WriteLine(row);

                if (i < n)
                    num = ++num1;
                //num -= 1;
            }

            Console.Read();
        }
    }
}    
