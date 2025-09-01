namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            int user_num;
            int res = 1;
            System.Console.Write("enter a number: ");
            user_num = Convert.ToInt32(System.Console.ReadLine());
            for (int i = user_num; i > 0; i--)
            {   
                res *= i;
            }
            System.Console.WriteLine("{0}! = {1}", user_num,res);
        }
    }
    
}