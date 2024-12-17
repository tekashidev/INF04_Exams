namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int A = int.Parse(a);
        int B = int.Parse(b);

        if (A != B)
        {
            if (A > B)
            {
                A = A - B;
            }
            else
            {
                B = B - A;
            }
            
            Console.WriteLine(A);
        }
        
    }
}