namespace ReverseNos
{
    internal class Program
    {
        
            static void Main(string[] args )
            {
                Console.WriteLine("enter the number to be reversed");
                int number = Int32.Parse(Console.ReadLine());
                int remainder;
                int reversednumber=0;

                while ( number > 0 )
                {
                    remainder = number % 10;
                    reversednumber = reversednumber * 10 + remainder ;

                    number = number / 10;
                }
            Console.WriteLine( "the reversed number is ="+reversednumber);

        }
    }
}