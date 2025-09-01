namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            String name;
            System.Console.WriteLine("please enter a name");
            name = System.Console.ReadLine();
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            var rev_name = new String(charArray);

            System.Console.WriteLine(rev_name);

        }
    }
    
}