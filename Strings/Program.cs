using System.Security.Cryptography.X509Certificates;

class Program
{
    static int p1= 0, p2= 1,p3;
    static void Main(string[] args)
    {
        Console.WriteLine("input");
        int count =Int32.Parse(Console.ReadLine());
        Console.WriteLine(p1+ " " + p2);
        for(int i=2; i<count;i++)
        {
            p3 = p1 + p2;
            Console.WriteLine(" " + p2);
            p1 = p2;
            p2 = p3;

        }
        Console.WriteLine();
    }
}