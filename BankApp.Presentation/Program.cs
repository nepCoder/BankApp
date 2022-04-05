using System;
class Program
{
    static void Main()
    {
        //Login Page
        Console.WriteLine("*** LOGIN PAGE***");

        //username
        Console.Write("Username: ");
        var userName = Console.ReadLine();

        //password [if username is 
        var password = "";

        if (userName != "")
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }


        //if username and password is correct show main menu
        if (userName != "nepcoder" || password != "nepcoder123")
        {
            Console.WriteLine("*** WRONG USERNAME OR PASSWORD! ***");
            
        }
        else
        {
            //declare variable to store menu choice
            int mainMenuChoice = -1;

            do
            {
                Console.WriteLine("\n:::MAIN MENU HERE:::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                mainMenuChoice = int.Parse(Console.ReadLine());
            }while(mainMenuChoice != 0);    
        }

        //thank you message
        Console.WriteLine("\n\n*** THANK YOU ***"); 
    }
}