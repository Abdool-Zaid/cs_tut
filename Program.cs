namespace Cs_tut
{
    public class Calculator
    {
        public int add(int a, int b) {
            return (a + b);
        }
         public int subtract(int a, int b) {
            return (a - b);
        }
        public int mul(int a, int b) {
            return (a * b);
        }
        public int div(int a, int b) {
            return (a / b);
        }


    }
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