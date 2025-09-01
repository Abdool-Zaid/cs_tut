namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

                System.Console.WriteLine(calc.add(9,10));
                System.Console.WriteLine(calc.subtract(9,10));
                System.Console.WriteLine(calc.mul(9,10));
                System.Console.WriteLine(calc.div(9,10));

        }
    }
    
}