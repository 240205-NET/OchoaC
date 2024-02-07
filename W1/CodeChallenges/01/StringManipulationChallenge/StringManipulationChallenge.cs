using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            Console.WriteLine("Please enter a message: ");
            userInputString = Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            elementNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a character: ");
            char1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter your first name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            lName = Console.ReadLine();
            userFullName = ConcatNames(fName, lName);

            Console.WriteLine("The message in all upper case: " + StringToUpper(userInputString));
            Console.WriteLine("The message in all lower case: " + StringToLower(userInputString));
            Console.WriteLine("The message with whitespace trimmed: " + StringTrim(userInputString));
            Console.WriteLine("The substring of the message: " + StringSubstring(userInputString, elementNum));
            if(SearchChar(userInputString, char1) == -1)
                Console.WriteLine("The character is not in the message.");
            else
                Console.WriteLine("The index of the character in the message: " + SearchChar(userInputString, char1));
            Console.WriteLine("The user's full name: " + userFullName);


        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            return x.ToUpper();
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            return x.ToLower();

        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            return x.Trim();

        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            return x.Substring(elementNum);
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            return userInputString.IndexOf(x);
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            return fName + " " + lName;
        }



    }//end of program
}
