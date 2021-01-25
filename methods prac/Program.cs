using System;

namespace methods_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetUsersInput("What is your name?");
            
            string age = GetUsersInput("What is your age?");

            string animal = GetUsersInput("What is your favorite animal?");

            string band = GetUsersInput("What is your favorite band");

            Console.WriteLine($"What is your name {name} and how old are you {age}. so how would you like too buy a {animal} from me?" + 
               $" you can bring it everywhere even too a live show of you favorite {band}");
            // exercise 2 of methods

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Give me a number to add too the first one");
            int num2 = int.Parse(Console.ReadLine());

            int add = Sum(num1, num2);
            Console.WriteLine($"The sum {add}");

            Console.WriteLine("Give me a number to multiply");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply too the first one");
            int num4 = int.Parse(Console.ReadLine());

            int times = Mult(num3, num4);
            Console.WriteLine($"The amount is {times}");
        }
        public static string GetUsersInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
          public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Mult(int num3, int num4)
        {
            return num3 * num4;
        }
            
        
    }
}
