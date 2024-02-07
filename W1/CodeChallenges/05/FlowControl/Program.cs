using System;

namespace FlowControl
{
    public class Program
    {
        //create global variables to hold users login data.
        public static string username;
        public static string password;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Challenge 1. Temperature Advice
            int temp = GetValidTemperature();
            GiveActivityAdvice(temp);

            //Challenge 2. Login system.
            Register();
            if (Login())
            {
                Console.WriteLine("Congratulations, You successfully logged in.");
            }

            //Challenge 3. Ternary Operators
            temp = GetValidTemperature();
            GetTemperatureTernary(temp);
        }

        // This method gets a valid temperaturebetween -40 asnd 135 inclusive 
        // and returns the valid int.
        public static int GetValidTemperature()
        {
            Console.WriteLine("Please enter the temperature: ");
            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp) || temp < -40 || temp > 130)
            {
                Console.WriteLine("Please enter a valid temperature between -40 and 130.");
            }
            if( temp <-20){
                Console.WriteLine("Cover every part of your body.");
            }
            else if (temp < 0)
            {
                Console.WriteLine("Wear a heavy coat.");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Wear a coat.");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Wear a light coat.");
            }
            else if (temp < 60)
            {
                Console.WriteLine("Wear a sweater.");
            }
            else if (temp < 80)
            {
                Console.WriteLine("Wear a t-shirt.");
            }
            else if (temp < 90)
            {
                Console.WriteLine("Wear a tank top.");
            }
            else if (temp < 100)
            {
                Console.WriteLine("Wear a swimsuit.");
            }
            else
            {
                Console.WriteLine("Sweat and suffer.");
            }
            return temp;
        }

        // This method has one int parameter
        // It gives outdoor activity advice and temperature opinion based on 20 degree
        // increments starting at -20 and ending at 135 
        // n < -20 = hella cold
        // -20 <= n < 0 = pretty cold
        //  0 <= n < 20 = cold
        // 20 <= n < 40 = thawed out
        // 40 <= n < 60 = feels like Autumn
        // 60 <= n < 80 = perfect outdoor workout temperature
        // 80 <= n < 90 = niiice
        // 90 <= n < 100 = hella hot
        // 100 <= n < 135 = hottest
        public static void GiveActivityAdvice(int temp)
        {
            if( temp < -20)
            {
                Console.WriteLine("Hella cold");
            }
            else if (temp < 0)
            {
                Console.WriteLine("Pretty cold");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Cold");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Thawed out");
            }
            else if (temp < 60)
            {
                Console.WriteLine("Feels like Autumn");
            }
            else if (temp < 80)
            {
                Console.WriteLine("Perfect outdoor workout temperature");
            }
            else if (temp < 90)
            {
                Console.WriteLine("Niiice");
            }
            else if (temp < 100)
            {
                Console.WriteLine("Hella hot");
            }
            else
            {
                Console.WriteLine("Hottest");
            }  
        }

        // This method gets a username and password from the user
        // and stores that data in the global variables of the 
        // names in the method.
        public static void Register()
        {
            Console.WriteLine("Please enter a username: ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter a password: ");
            password = Console.ReadLine();
        }

        // This method gets username and password from the user and
        // compares them with the username and password global variables
        // or the names provided. If the password and username match,
        // the method returns true. If they do not match, the user is 
        // prompted again for the username and password.
        public static bool Login()
        {
            Console.WriteLine("Please enter your username: ");
            string user = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string pass = Console.ReadLine();
            if (user == username && pass == password)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return false;
            }
        }

        // This method as one int parameter.
        // It checks is the int is <=42, between
        // 43 and 78 inclusive, or > 78.
        // For each temperature range, a different 
        // advice is given. 
        public static void GetTemperatureTernary(int temp)
        {
            string advice = temp <= 42 ? temp + "is too cold!" : (temp <= 78 ? temp + "is an ok temperature" : temp +" is too hot!");
            Console.WriteLine(advice);
        }
    }//end of Program()
}
