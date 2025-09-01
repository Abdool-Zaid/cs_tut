namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            byte speed_limit;
            byte vehicle_speed;
            byte accumulated_points;
            System.Console.WriteLine("please enter the speed limit");
            speed_limit = Convert.ToByte(System.Console.ReadLine());
            System.Console.WriteLine("please enter the vehicle speed");
            vehicle_speed = Convert.ToByte(System.Console.ReadLine());

            if (speed_limit > vehicle_speed)
            {
                System.Console.WriteLine("not speeding");
            }
            else
            {
                accumulated_points = (byte)((vehicle_speed - speed_limit) / 5);
                if (accumulated_points < 12)
                {
                    System.Console.WriteLine("you have accumulated {0} points", accumulated_points);
                }else
                {
                    System.Console.WriteLine("your license has been suspended due to having 60accumulated {0} points", accumulated_points);
                }          
            }
        }
    }
    
}