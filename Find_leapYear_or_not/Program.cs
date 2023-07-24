using System;

namespace Find_leapYear_or_not
{
     class Program
    {
        static void Main(string[] args)
        {

            string decision;
            do
            {
                int year;
                Console.WriteLine("Enter the year here ");
                year = Int32.Parse(Console.ReadLine());


                Console.WriteLine(leap(year));

                Console.WriteLine("Enter yes if you wish to try again");
                decision = Console.ReadLine();
            }

            while (decision.Equals("yes"));
            
        }

        static string leap (int year)
        {

           
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    return "it is a leab year";
                }
                else
                {
                    return"it is not a leap year";
                }
               
            
           
        }
    }
}