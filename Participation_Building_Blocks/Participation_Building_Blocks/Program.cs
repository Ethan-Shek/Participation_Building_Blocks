namespace Participation_Building_Blocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            int num2 = 10;
            bool likeCake = false;
            string word = "Yippee";
            double dec = 3.1415;
            Console.WriteLine("int: " + num);
            Console.WriteLine("boolean: " + likeCake);
            Console.WriteLine("String: " + word);
            Console.WriteLine("float/double: " + dec);
            namePrint();
            Console.WriteLine("What's 9+10?");
            Console.WriteLine(numAdd(num, num2));

        }

        static void namePrint()
        {
            Console.WriteLine("My instuctor is Nick Buonarota!");
        }

        static int numAdd(int num, int num2)
        {

            return num + num2;
        }




    }
}
