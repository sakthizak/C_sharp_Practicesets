namespace PatternPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            plus();
            floyd();
            hex();
        }

        static void floyd()
        {
            Console.WriteLine("entre the no to pattern");
            int pat = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < pat; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }

        static void plus()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (i == 2 || j == 2)
                    {
                        Console.Write("*");
                    }


                    else
                    {
                        Console.Write(" ");
                    }
                }



                Console.WriteLine();
            }


                /* int n = 5;
                 for (int i = 0; i < n; i++)
                 {
                     for (int j = 0; j <= n; j++)
                     {
                         if (i == 0 && j == 3 || i == 1 && j == 3 || i == 3 && j == 3  || i == 4 && j == 3 || i == 5 && j == 3|| i == 3 && j == 0 || i == 3 && j == 1 || i == 3 && j == 2 || i == 3 && j == 3 || i == 3 && j == 4 || i == 3 && j == 5)
                         {
                             Console.Write(" * ");
                         }

                         else
                         {
                             Console.Write("    ");
                         }
                     }
                     Console.WriteLine();
                 }*/

            }

            /*int n = 5;
            for (int i = 0; i < n; i++)
            {
                if (i == 3)
                for (int j = 0; j <= n; j++)
                {
                        Console.Write(" * ");


                }

                Console.WriteLine();
            }*/

        

        static void hex ()
        {
            int n = 5;
            for (int i = 0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {

                }
            }
        }
    }
}