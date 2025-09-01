namespace Cs_tut
{
    public class Program{

        static void Main(string[] args)
        {
            var liked_by = new List<string>();
            while (true)
            {
                System.Console.WriteLine("enter a name");
                var name = System.Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {
                    liked_by.Add(name);
                    if (liked_by.Count == 1)
                    {
                        System.Console.WriteLine("{0} liked your post", name);
                    }
                    else if (liked_by.Count == 2)
                    {
                        System.Console.WriteLine("your post was liked by {0} and {1}", liked_by[0], liked_by[1]);
                    }
                    else if (liked_by.Count > 2)
                    {
                        System.Console.WriteLine("your post was liked by {0},{1} and {2} more ", liked_by[0], liked_by[1], (liked_by.Count-2));
                    }


                }

            }

        }
    }
    
}