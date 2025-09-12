using System.ComponentModel;
using System.Numerics;

namespace MethodsExercise
{
    public class Program
    {
        public static void getInput()
        {
            string verse1, verse2, verse3, verse4;

            Console.WriteLine($"What is your name?");
            string userName = Console.ReadLine(); // inputConsole.WriteLine("What is your name?");

            Console.WriteLine($"What is your favorite color?");
            string favColor = Console.ReadLine(); // input

            // Console.WriteLine($"What is your favorite animal?");
            // string favAnimal = Console.ReadLine(); // input

            // Poem verses
            verse1 = "Hickory Dickory Dock";
            verse2 = userName + " forgot to set the clock";
            verse3 = string.Format("Maybe because I didn't notice the fancy {0} shirt", favColor);
            verse4 = "Silly me I'm late for work";

            // Print poem
            printOutput(verse1, verse2, verse3, verse4);
        }

        static void Main(string[] args)
        {
            // get input from user and print story
            getInput();

            // print math
            Console.WriteLine($"\n2 + 3 + 4 + 5 + 6 = {Add(2,3,4,5,6)}");
            Console.WriteLine($"5 - 3 = {Subtract( 5, 3 )}");
            Console.WriteLine($"2 * 3 = {Multiply( 2, 3 )}");
            Console.WriteLine($"6 / 3 = {Divide( 6, 3 )}");

        }

        public static void printOutput(params string[] verses)
        {
            foreach (string verse in verses)
            {
                Console.WriteLine(verse);
            }
        }
        
        public static int Add(params int[] numbers )
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static int Subtract(int num1, int num2 )
        {
            return num1 - num2;

        }
        public static int Multiply(int num1, int num2)
        {
            return num1* num2;
        }
        
        public static int Divide( int num1, int num2 )
        {
            return num1 / num2;
        }
    }
}
