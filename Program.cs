//MJ Eng [.NET24]
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number input
            int x = 6;

            //output if number is bigger or smaller than 10
            if (x > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else if (x < 10)
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            //String
            Console.WriteLine("Vad heter du?");

            //Input of username
            string userName = Console.ReadLine();
            //Output of username
            Console.WriteLine($"Hej {userName}");

            //loop som skriver ut alla tal från noll upp till det nummer som du satte i int x
            int[] numbers = new int[x + 1];
            Console.WriteLine($"Alla tal från noll till nummer x: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"nummer {i}, ");
            }
           

       }
    }
}
