namespace Sequential_removal
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<String> list = new List<String>();

            Console.WriteLine("enter the string value");
            string output, s = Console.ReadLine();
            int length = s.Length;
            output = string.Empty;
            //list.Add(s);
            //char[] arr = s.ToCharArray();
           // Console.WriteLine(length);
            int x = 0,y;
            // output = s.Substring(3, 2);
            int d = 1;
            for (int i = 2; i < 100; i = Convert.ToInt32(Math.Pow(2, d)))
            {
                Console.WriteLine(i);
                d++;
                output += s.Substring(x, i*2);
                x = i + 1;
                /* if (i == 2 ||  )
                 {
                     output = output + arr[i];
                 }*/
            }
            Console.WriteLine(output);
            //Console.WriteLine(list);
          
        /*    for (int i = 0; i < list.Count; i++)
            {
                if (i == 2 || i == i * 2)
                {
                    list.RemoveAt(i);
                }
            }*/
/*            foreach (var u in list)
            {
                Console.WriteLine(u);
            }*/
            /*  string MyString = " Big   ";
              Console.WriteLine("Hello{0}World!", MyString);
              string TrimString = MyString.Trim();
              Console.WriteLine("Hello{0}World!", TrimString);
              //       The example displays the following output:
              //             Hello Big   World!
              //             HelloBigWorld!*/
        }
    }
}