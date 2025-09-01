namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            int user_num = 0;
            while (true)
            {
                System.Console.Write("ener a number: ");
                var temp = System.Console.ReadLine();
                if (temp == "ok")
                {
                    break;
                }
                else
                {
                    user_num += Convert.ToInt32(temp);
                    
                    System.Console.WriteLine("total : {0}", user_num);

                }
            }
        }
    }
    
}