// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Transactions;
using Inlämning;


bool running = true; // Correct declaration


    // storing all user inputs
    List <User> users = new List<User>();
    List<Item> items = new List<Item>();
    
     void Main(string[] args)
{
    bool running = true;
}

//main loop of program

    while (running)
    {

    Console.WriteLine("=== MIni Trading Platform ===");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. UploadItem");
    Console.WriteLine("4. ViewItems");
    Console.WriteLine("5. Exit");
    Console.WriteLine("Choose an Option");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Register();
            break;
        case "2":
            Login();
            break;
        case "3":
            UploadItem();
            break;
        case "4":
            ViewItems();
            break;
        case "5":
            running = false;
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid Option, try again.");
            break;


    }

}

 void Register()
{
    Console.WriteLine("Enter Username:");
    string Username = Console.ReadLine();
 
    Console.WriteLine($"User '{Username}' registered succesfully!");
 }

 void Login()
{
    Console.Write("Enter Username to login: ");
    string username = Console.ReadLine();
    if (username.Contains(username))
    {
        Console.WriteLine($"User '{username}'logged in succesfully!");
    }

    else
    {
        Console.WriteLine("User not found. Please register first.");
    }
    
}


    void UploadItem()
    {
    Console.Write("Enter item name;");
    String item = Console.ReadLine();
    
    Console.WriteLine($"Item ' {item}' uploaded succesfully!");
}
      void ViewItems()
{
    Console.WriteLine("=== All Items ===");

        foreach (Item item in items)
        {
            Console.WriteLine(item);
        }
    }
      
    




 


    





