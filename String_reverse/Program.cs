namespace String_reverse
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to be reversed");
            string input =Console.ReadLine();
            string b , reversed = string.Empty;
            int length = input.Length;
            char[] array = input.ToCharArray();
            
            for(int i=length-1;i>=0;i--)
            {
                reversed= reversed + array[i] ;
            }
            Console.WriteLine( "the reversed string is = "+reversed);
        }
    }
}