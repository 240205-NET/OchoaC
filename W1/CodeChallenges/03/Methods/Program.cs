using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            Console.WriteLine("Hello, " + name +". You are my friend");
        }

        public static double GetNumber()
        {
            Console.WriteLine("Please enter a number: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                return number;
            }
            else
            {
                throw new FormatException("You did not enter a number.");
            }
        }

        public static int GetAction()
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");

            bool running = true;
            int action = -1;

            while (running)
            {
                if (int.TryParse(Console.ReadLine(), out action))
                {
                    if (action > 0 && action < 5)
                    {
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 0 and 5.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            return action;
        }

        public static double DoAction(double x, double y, int z)
        {
            double result = -1;

            if(
                z <=0 || z > 4
            ){
                throw new FormatException("Invalid operation selected.");
            }
            switch(z)
            {
                case 1:
                    result = x + y;
                    break;
                case 2:
                    result = x - y;
                    break;
                case 3:
                    result = x * y;
                    break;
                case 4:
                    result = x / y;
                    break;
            }

            return result;
        }
    }
}
