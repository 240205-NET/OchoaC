using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Project.Logic
{
    public class Menu
    {

        public Menu()
        {
            Start();
        }

        public static void Start()
        {

            Login();

        }

        public static void Login()
        {

            WriteLine("Login / Register");
            WriteLine("----------------");
            WriteLine("1. Login");
            WriteLine("2. Register");
            WriteLine("3. Exit");

            string choice = ReadLine() ?? "";

            using FileStream fileStream = new FileStream("people.xml", FileMode.Open);
            switch (choice)
            {
                case "1":
                    WriteLine("Enter your username: ");
                    string username = ReadLine() ?? "";
                    WriteLine("Enter your password: ");
                    string password = ReadLine() ?? "";

                    

                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("Invalid choice");
                    break;
            }


        }

        public static void Register()
        {
            WriteLine("Enter your name: ");
            string name = ReadLine() ?? "";
            WriteLine("Enter your email: ");
            string email = ReadLine() ?? "";
            WriteLine("Enter your phone number: ");
            string phoneNumber = ReadLine() ?? "";
            WriteLine("Enter your username: ");
            string username = ReadLine() ?? "";
            WriteLine("Enter your password: ");
            string password = ReadLine() ?? "";
        }

        public static void DisplayMenu()
        {
            WriteLine("1. Create a new client");
            WriteLine("2. Create a new employee");
            WriteLine("3. Create a new appointment");
            WriteLine("4. Display all clients");
            WriteLine("5. Display all employees");
            WriteLine("6. Display all appointments");
            WriteLine("7. Exit");
        }

        public static void DisplayClientMenu()
        {
            WriteLine("1. Display all clients");
            WriteLine("2. Display a client's appointments");
            WriteLine("3. Exit");
        }

        public static void DisplayEmployeeMenu()
        {
            WriteLine("1. Display all employees");
            WriteLine("2. Display an employee's appointments");
            WriteLine("3. Exit");
        }

        


    }
}
