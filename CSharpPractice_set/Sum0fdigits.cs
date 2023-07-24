using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_set
{
     class Sum0fdigits
    {
        static void Main (string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int sum=0,remainder;

            while (number > 0) {
                remainder = number % 10;
                sum =sum + remainder;
                number = number / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
