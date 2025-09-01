namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine("{0} is divisible by 3", i);
                }
            }
        }
    }
    
}