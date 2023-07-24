namespace CheckA_string_palindrome
{
     class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to be checked as palindrome or not");
             string input = Console.ReadLine();

            // char[] array = input.ToCharArray();

            Console.WriteLine( "the reversed string is----"+reverse(input));

        }

        static String reverse(string input)
        {
            string backup = input;
            int length = input.Length;
            string reverse = string.Empty;
            while (length > 0)
            {
                reverse = reverse + input[length - 1];
                length--;
            }
            if (reverse == backup)
            {
                return "palindrome";
            }
            else
            {
                return "not a palindrome";
            }


        }

    }
}