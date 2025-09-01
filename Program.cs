namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {

           int[] numlist = new int[5] { 0,0,0,0,0};
            for (int i = 0; i < 5; i++)
            {
                int temp;
                System.Console.WriteLine("enter a number: ");
                temp = Convert.ToInt32(System.Console.ReadLine());
                while (numlist.Contains(temp))
                {
                    System.Console.WriteLine("please try a different number");
                    temp = Convert.ToInt32(System.Console.ReadLine());
                }
                numlist[i] = temp;
            }
            foreach (var item in numlist)
            {
                System.Console.WriteLine(item);
            }

        }
    }
    
}