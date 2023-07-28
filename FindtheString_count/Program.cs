namespace FindtheString_count
{
     class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefghijklmnopqerst(*76%$ASDFG#@23344";
            int lnt = s.Length;

            string  backup = string.Empty;
            char[] array = s.ToCharArray();

            Console.WriteLine("char " + array[1]);
            for (int i=0;i<lnt;i++)
            {
                if (array[i] >= 97 && array[i] <=122)
                {
                    Console.WriteLine("it is a lower case allp" + array[i]);
                }

                else if (array[i] >=60 && array[i] <=95)
                {
                    Console.WriteLine("it is a upper case"+array[i]);
                }
                else
                {
                    Console.WriteLine("nothing to say " + array[i]);
                }
            }
        }
    }
}