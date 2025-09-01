namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            byte user_num_1;
            byte user_num_2;
            System.Console.WriteLine("please enter the first number\n");
            user_num_1 = Convert.ToByte(System.Console.ReadLine());
            System.Console.WriteLine("please enter the second number\n");
            user_num_2 = Convert.ToByte(System.Console.ReadLine());

            if (user_num_1 > user_num_2)
            {
                System.Console.WriteLine("largest number is {0}", user_num_1);
            }
            else
            {
                System.Console.WriteLine("largest number is {0}", user_num_2);
            }
        }
    }
    
}