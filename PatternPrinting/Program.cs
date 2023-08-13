namespace PatternPrinting
{
     class Program
    {
        static void Main(string[] args)
        {


            //plus();
            //floyd();
            //hex();
            //square();
            diamond();
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
            int n = 7;
            int x = n / 2 ;
            for (int i = 0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    /*  if(i == 2 && j ==0||i==1&&j==1 || i==1 && j ==3 || i==0 && j==2||i==2&&j==4||i==3&&j==1||i==3&&j==3||i==4&&j==2)
                      {
                          Console.Write("*");
                      }
                      else
                      {
                          Console.Write(" ");
                      }*/
                    //|| i % 2 != 0 && j % 2 != 0    || 
                    if (j==i+x  || j==x-i  )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                for(int j=n;j>0;j--)
                {
                    if(j == i - x )
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
        }

        static void square()
        {
            int n = 10;
            for (int i = 1;i<=n ; i++)
            {
                for( int j = 0;j<n; j++)
                {
                    if(i == 0 ||j==0 ||i==n||j==n)
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
        }

        static void diamond()
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
            for(int i=pat-1;i>=0;i--)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}