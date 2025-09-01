namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            byte user_num;
            System.Console.WriteLine("please enter a number between 1 to 10\n");
            user_num = Convert.ToByte(System.Console.ReadLine());

            if (user_num >0 && user_num <=10)
            {
                System.Console.WriteLine("number is valid");
            }
            else
            {
                System.Console.WriteLine("number is invalid");
                
            }
        }
    }
    
}