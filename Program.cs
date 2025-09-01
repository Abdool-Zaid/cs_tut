namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            byte image_width;
            byte image_height;
            System.Console.WriteLine("please enter the image's width\n");
            image_width = Convert.ToByte(System.Console.ReadLine());
            System.Console.WriteLine("please enter the image's height\n");
            image_height = Convert.ToByte(System.Console.ReadLine());

            if (image_width > image_height)
            {
                System.Console.WriteLine("image is landscape");
            }
            else
            {
                System.Console.WriteLine("image is portrait");
            }
        }
    }
    
}