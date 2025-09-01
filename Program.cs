namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            var rand = new Random();
            byte total_guesses = 4;
            byte secret_num = (byte)rand.Next(1, 10);

            Console.WriteLine("guess a number between 1 and 10");
            for (int i = 0; i < total_guesses; i++)
            {
                if (Convert.ToByte(System.Console.ReadLine()) == secret_num)
                {
                    System.Console.WriteLine("you guessed correctly");
                    break;
                }
                else
                {
                    System.Console.WriteLine("try again");
                }
            }
            System.Console.WriteLine("answer was {0}", secret_num);

        }
    }
    
}