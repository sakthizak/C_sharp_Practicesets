namespace Check_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the input number to be checked palindrome or not");
            int input = Int32.Parse(Console.ReadLine());
            int reminder, reversed=0;
            int backup = input;
            while(input>0)
            {
                reminder = input % 10;
                reversed = reversed *10 + reminder;
                input = input / 10; 
            }
            Console.WriteLine(reversed);
            Console.WriteLine( input);
            if (backup == reversed)
            {
                Console.WriteLine("the given input is a palindrome");
            }
            else
            {
                Console.WriteLine(  "the given number is not a palindrome");
            }

        }
    }
}