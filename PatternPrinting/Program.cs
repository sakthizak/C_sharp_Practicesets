namespace PatternPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre the no to pattern");
            int pat = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < pat; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}