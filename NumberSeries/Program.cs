namespace NumberSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number d1");
            int d1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter the number d2");
            int d2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter the number r1");
            int r1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter the number r2");
            int r2 = Int32.Parse(Console.ReadLine());

            for(int i = r1; i <= r2; i++)
            {
                if(i%4 == 0 && i%5 == 0 )
                {
                    Console.WriteLine(i+",");
                }
            }

        }
    }
}